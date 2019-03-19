using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static WindowsFormsApp1.CRC32;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        static int offset;
        //static byte[] empty = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public Form1()
        {
            InitializeComponent();
        }

        static byte[] StringToHex(string str)
        {
            byte[] arrByte = Encoding.GetEncoding("shift_jis").GetBytes(str);
            return arrByte;
        }

        static string HexToString(byte[] data)
        {
            string String = Encoding.GetEncoding("shift_jis").GetString(data);
            return String;
        }
        
        static byte[] IntToHex(int i)
        {
            byte[] arrByte = new byte[0x4];
            try
            {
                arrByte[0] = (byte)i;
                arrByte[1] = (byte)(i >> 8);
                arrByte[2] = (byte)(i >> 16);
                arrByte[3] = (byte)(i >> 24);
            }
            catch
            {
                MessageBox.Show("Too long number", "Invaild number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrByte;
        }

        static int HexToInt(byte[] data)
        {
            int sum = BitConverter.ToInt32(data, 0);
            return sum;
        }

        static int TimeToInt(string Time)
        {
            int i = Int32.Parse(Time);
            int tSec = i / 100000 % 10 * 60000 + i - i / 100000 % 10 * 100000;
            return tSec;
        }

        static string IntToTime(int i)
        {
            int milisec, sec;
            int min = 0;
            sec = i / 1000;
            milisec = i % 1000;
            if (sec > 60)
            {
                min = sec / 60;
                sec = sec % 60;
            }

            string time = min.ToString() + "'" + sec.ToString("D2") + "''" + milisec.ToString("D3");
            return time;
        }

        static byte[] read(int offset)
        {
            FileStream fs = File.Open("SBZZ_sram.bin", FileMode.Open, FileAccess.Read);
            //FileStream fs = File.Open("Test.txt", FileMode.Open, FileAccess.Read);
            fs.Seek(offset, SeekOrigin.Begin);
            BinaryReader reader = new BinaryReader(fs);
            byte[] data = reader.ReadBytes(0x30);
            fs.Close();
            return data;
        }

        /*static void sCRC32()
        {
            FileStream fs = File.Open("SBZZ_sram.bin", FileMode.Open, FileAccess.ReadWrite);
            fs.Seek(0x40004, SeekOrigin.Begin);
            BinaryReader reader = new BinaryReader(fs);
            byte[] data = reader.ReadBytes(0x2DFFB);
            byte[] hash = new byte[0x4];
            uint crc32 = GetCRC32(data);
            write(offset, StringToHex(crc32.ToString()));
            fs.Close();
        }*/

        static DateTime HexToDate(byte[] data)
        {
            string UnixTime = BitConverter.ToInt32(data, 0).ToString();
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new System.DateTime(1970, 1, 1));
            DateTime TranslateDate = startTime.AddSeconds(double.Parse(UnixTime));
            return TranslateDate;
        }

        static byte[] DateToHex(DateTime date)
        {
            long UnixDate = (date.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
            byte[] arrByte = new byte[0x4];
            try
            {
                arrByte[0] = (byte)UnixDate;
                arrByte[1] = (byte)(UnixDate >> 8);
                arrByte[2] = (byte)(UnixDate >> 16);
                arrByte[3] = (byte)(UnixDate >> 24);
            }
            catch
            {
                MessageBox.Show("Too long number", "Invaild number", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return arrByte;
        }

        static void write(int offset, byte[] data)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open("SBZZ_sram.bin", FileMode.Open, FileAccess.ReadWrite)))
            //using (BinaryWriter writer = new BinaryWriter(File.Open("Test.txt", FileMode.Open, FileAccess.ReadWrite)))
            {
                writer.Seek(offset, SeekOrigin.Begin); 
                writer.Write(data);     
            }
        }

        public void locate()
        {
            //int allnet_id = cb_Online.SelectedIndex;
            int course_id = cb_Course.SelectedIndex;
            int direct_id = cb_Direction.SelectedIndex;

            offset = 0x65809 + 0x00060 * course_id + 0x00030 * direct_id /*+ 0x06000 * allnet_id*/;

            //lbTest.Text = "0x" + Convert.ToString(offset, 16);
        }

        public void reloadDgv()
        {
            byte[] name = new byte[0xC];
            byte[] car_maker = new byte[0x1];
            byte[] car = new byte[0x1];
            byte[] area = new byte[0x1];
            byte[] tTime = new byte[0x4];
            byte[] date = new byte[0x4];

            gvRank.Rows.Clear();

            for (int index = 0; index < 10; index++)
            {
                gvRank.Rows.Add();
                byte[] temp = read(offset + 0x600 * index);

                Array.Copy(temp, 0x00, name, 0, 0xC);
                Array.Copy(temp, 0x14, car_maker, 0, 0x1);
                Array.Copy(temp, 0x15, car, 0, 0x1);
                Array.Copy(temp, 0x16, area, 0, 0x1);
                Array.Copy(temp, 0x2C, tTime, 0, 0x4);
                Array.Copy(temp, 0x1C, date, 0, 0x4);


                gvRank.Rows[index].Cells[0].Value = index + 0x1;
                gvRank.Rows[index].Cells[1].Value = HexToString(name);
                gvRank.Rows[index].Cells[2].Value = IntToTime(HexToInt(tTime));
                gvRank.Rows[index].Cells[3].Value = car_maker[0] + " of " + car[0];
                gvRank.Rows[index].Cells[4].Value = area[0];
                gvRank.Rows[index].Cells[5].Value = HexToDate(date);
            }
        }

        private void txtTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                if(e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }

        static bool isLeftLarger(int l, int r)
        {
            if (l > r)
            {
                return true;
            }
            else
                return false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //int ranktype = cb_ranktype.SelectedIndex;
            //locate(ranktype, 0);
            /*sCRC32();
            byte[] data = new byte[] 
            {
                0x8F, 0x48, 0x8E, 0x52, 0x82, 0xCC, 0x90, 0xE1, 0x99, 0x5C, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                0x00, 0x00, 0x00, 0x00, 0x03, 0x04, 0x30, 0x00, 0x00, 0x00, 0x00, 0x00, 0x5F, 0xA0, 0x87, 0x5C,
                0xE7, 0xFA, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x9B, 0xEB, 0x01, 0x00
            };
            write(offset, data);
            DateTime date = new DateTime(2019, 03, 12);
            write(offset +0x30, DateToHex(date));
            //write(offset + 0x30, IntToHex(TimeToInt(txtTime.Text)));*/

            for (int index = 0; index < 10; index++)
            {
                write(offset + 0x00 + 0x600 * index, StringToHex(gvRank.Rows[index].Cells[1].Value.ToString()));
                write(offset + 0x2C + 0x600 * index, IntToHex(TimeToInt(gvRank.Rows[index].Cells[2].Value.ToString().Replace("'", ""))));
                write(offset + 0x16 + 0x600 * index, IntToHex(Int32.Parse(gvRank.Rows[index].Cells[4].Value.ToString())));
                write(offset + 0x1C + 0x600 * index, DateToHex(DateTime.Parse(gvRank.Rows[index].Cells[5].Value.ToString())));
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Course.SelectedIndex = 0;
            cb_Direction.SelectedIndex = 0;
            cb_ranktype.SelectedIndex = 0;
            cb_Online.SelectedIndex = 0;
            locate();
            reloadDgv();
        }

        public void cbCarManage()
        {
            int maker = cb_maker.SelectedIndex;
            switch(maker)
            {
                case (0):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "TRUENO GT-APEX (AE86)",
                        "LEVIN GT-APEX (AE86)",
                        "LEVIN SR (AE85)",
                        "MR2 G-Limited (SW20)",
                        "ALTEZZA RS200 (SXE10)",
                        "MR-S (ZZW30)",
                        "SUPRA RZ (JZA80)",
                        "86 GT (ZN6)",
                        "PRIUS (ZVW30)",
                        "TRUENO 2door GT-APEX (AE86)",
                        "CELICA GT-FOUR (ST205)",
                    });
                    break;
                case (1):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "SKYLINE GT-R (BNR32)",
                        "SKYLINE GT-R (BNR34)",
                        "SILVIA K's (S13)",
                        "Silvia Q's (S14)",
                        "Silvia spec-R (S15)",
                        "180SX TYPE ࡱ (RPS13)",
                        "FAIRLADY Z (Z33)",
                        "GT-R NISMO (R35)",
                        "SKYLINE 25GT TURBO (ER34)"
                    });
                    break;

            }
        }

        private void cb_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            locate();
            reloadDgv();
        }

        private void cb_Direction_SelectedIndexChanged(object sender, EventArgs e)
        {
            locate();
            reloadDgv();
        }

        private void cb_Online_SelectedIndexChanged(object sender, EventArgs e)
        {
            locate();
            reloadDgv();
        }

        private void cb_maker_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCarManage();
            cb_car.SelectedIndex = 0;
        }
    }
}
