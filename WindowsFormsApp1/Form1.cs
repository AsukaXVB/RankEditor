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
        static string[,] table_Cars = new string[9, 11] {
                {
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
                    "CELICA GT-FOUR (ST205)"
                } ,
                {
                    "SKYLINE GT-R (BNR32)",
                    "SKYLINE GT-R (BNR34)",
                    "SILVIA K's (S13)",
                    "Silvia Q's (S14)",
                    "Silvia spec-R (S15)",
                    "180SX TYPE Ⅱ (RPS13)",
                    "FAIRLADY Z (Z33)",
                    "GT-R NISMO (R35)",
                    "SKYLINE 25GT TURBO (ER34)","",""
                } ,
                {
                    "Civic SiR·Ⅱ (EG6)",
                    "CIVIC TYPE R (EK9)",
                    "INTEGRA TYPE R (DC2)",
                    "S2000 (AP1)",
                    "NSX (NA1)","","", "","","",""
                },
                {
                    "RX-7 ∞Ⅲ (FC3S)",
                    "RX-7 Type R (FD3S)",
                    "RX-8 Type S (SE3P)",
                    "ROADSTER (NA6CE)",
                    "ROADSTER RS (NB8C)",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                },
                {
                    "IMPREZA STi Ver.Ⅴ (GC8)",
                    "IMPREZA STI (GDBF)",
                    "IMPREZA STi (GDBA)",
                    "BRZ S  (ZC6)",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                },
                {
                    "LANCER Evolution Ⅲ (CE9A)",
                    "LANCER EVOLUTION Ⅳ (CN9A)",
                    "LANCER Evolution Ⅸ (CT9A)",
                    "LANCER EVOLUTION Ⅶ (CT9A)",
                    "LANCER EVOLUTION Ⅹ (CZ4A)",
                    "LANCER EVOLUTION Ⅴ (CP9A)",
                    "LANCER EVOLUTION Ⅵ (CP9A)",
                    "",
                    "",
                    "",
                    ""
                },
                {
                    "Cappuccino (EA11R)",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                },
                {
                    "SILEIGHTY",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                },
                {
                    "幻気-7 (FD3S)",
                    "MONSTER CIVIC R (EK9)",
                    "S2000 GT1 (AP1)",
                    "G-FORCE SUPRA (JZA80改)",
                    "ROADSTER C-SPEC (NA8C改)",
                    "NSX-R GT (NA2)",
                    "",
                    "",
                    "",
                    "",
                    ""
                },
            };
        static string[] table_Area = new string[]{
            "北海道",
            "青森県",
            "岩手県",
            "宮城県",
            "福島県",
            "山形県",
            "秋田県",
            "茨城県",
            "栃木県",
            "群馬県",
            "千葉県",
            "埼玉県",
            "東京都",
            "神奈川県",
            "山梨県",
            "新潟県",
            "長野県",
            "富山県",
            "石川県",
            "愛知県",
            "静岡県",
            "岐阜県",
            "三重県",
            "福井県",
            "大阪府",
            "京都府",
            "奈良県",
            "滋賀県",
            "和歌山県",
            "兵庫県",
            "広島県",
            "鳥取県",
            "島根県",
            "岡山県",
            "山口県",
            "徳島県",
            "香川県",
            "愛媛県",
            "高知県",
            "福岡県",
            "佐賀県",
            "長崎県",
            "熊本県",
            "大分県",
            "宮崎県",
            "鹿児島県",
            "沖縄県",
            "China / Macau",
            "Hong Kong",
            "Korea",
            "Malaysia",
            "Singapore",
            "Taiwan",
            "Indonesia",
            "Philippine",
            "Thailand",
            "America",
            "* * *"};

        public Form1()
        {
            InitializeComponent();
        }

        static byte[] StringToHex(string str)
        {
            byte[] arrByte = Encoding.GetEncoding("shift_jis").GetBytes(str);
            return arrByte;
        }

        public static String ToSBC(String input)
        {
            char[] c = input.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == 32)
                {
                    c[i] = (char)12288;
                    continue;
                }
                if (c[i] < 127)
                    c[i] = (char)(c[i] + 65248);
            }
            return new String(c);
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

        static int TimeToInt(string time)
        {
            int i = Int32.Parse(time);
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
                Array.Copy(temp, 0x15, car_maker, 0, 0x1);
                Array.Copy(temp, 0x14, car, 0, 0x1);
                Array.Copy(temp, 0x16, area, 0, 0x1);
                Array.Copy(temp, 0x2C, tTime, 0, 0x4);
                Array.Copy(temp, 0x1C, date, 0, 0x4);

                gvRank.Rows[index].Cells[0].Value = index + 0x1;
                gvRank.Rows[index].Cells[1].Value = HexToString(name);
                gvRank.Rows[index].Cells[2].Value = IntToTime(HexToInt(tTime));
                gvRank.Rows[index].Cells[3].Value = table_Cars[car_maker[0] & 0xff, car[0] & 0xff];
                gvRank.Rows[index].Cells[4].Value = table_Area[area[0] & 0xff];
                gvRank.Rows[index].Cells[5].Value = HexToDate(date);
                gvRank.Rows[index].Cells[6].Value = car_maker[0] & 0xff;
                gvRank.Rows[index].Cells[7].Value = car[0] & 0xff;
                gvRank.Rows[index].Cells[8].Value = area[0] & 0xff;

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
            for (int index = 0; index < 10; index++)
            {
                byte[] arrByte = new byte[0x3];
                arrByte[0] = (byte)Int32.Parse(gvRank.Rows[index].Cells[7].Value.ToString());
                arrByte[1] = (byte)Int32.Parse(gvRank.Rows[index].Cells[6].Value.ToString());
                arrByte[2] = (byte)Int32.Parse(gvRank.Rows[index].Cells[8].Value.ToString());

                byte[] nullByte = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

                write(offset + 0x00 + 0x600 * index, nullByte);
                write(offset + 0x00 + 0x600 * index, StringToHex(gvRank.Rows[index].Cells[1].Value.ToString()));
                write(offset + 0x2C + 0x600 * index, IntToHex(TimeToInt(gvRank.Rows[index].Cells[2].Value.ToString().Replace("'", ""))));
                write(offset + 0x1C + 0x600 * index, DateToHex(DateTime.Parse(gvRank.Rows[index].Cells[5].Value.ToString())));
                write(offset + 0x14 + 0x600 * index, arrByte);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_Course.SelectedIndex = 0;
            cb_Direction.SelectedIndex = 0;
            cb_ranktype.SelectedIndex = 1;
            cb_Online.SelectedIndex = 0;
            locate();
            reloadDgv();
        }

        public void cbCarManage()
        {
            int maker = cb_maker.SelectedIndex;
            switch (maker)
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
                        "CELICA GT-FOUR (ST205)"
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
                        "180SX TYPE Ⅱ (RPS13)",
                        "FAIRLADY Z (Z33)",
                        "GT-R NISMO (R35)",
                        "SKYLINE 25GT TURBO (ER34)"
                    });
                    break;
                case (2):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "Civic SiR·Ⅱ (EG6)",
                        "CIVIC TYPE R (EK9)",
                        "INTEGRA TYPE R (DC2)",
                        "S2000 (AP1)",
                        "NSX (NA1)"
                    });
                    break;
                case (3):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "RX-7 ∞Ⅲ (FC3S)",
                        "RX-7 Type R (FD3S)",
                        "RX-8 Type S (SE3P)",
                        "ROADSTER (NA6CE)",
                        "ROADSTER RS (NB8C)"
                    });
                    break;
                case (4):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "IMPREZA STi Ver.Ⅴ (GC8)",
                        "IMPREZA STI (GDBF)",
                        "IMPREZA STi (GDBA)",
                        "BRZ S  (ZC6)"
                    });
                    break;
                case (5):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "LANCER Evolution Ⅲ (CE9A)",
                        "LANCER EVOLUTION Ⅳ (CN9A)",
                        "LANCER Evolution Ⅸ (CT9A)",
                        "LANCER EVOLUTION Ⅶ (CT9A)",
                        "LANCER EVOLUTION Ⅹ (CZ4A)",
                        "LANCER EVOLUTION Ⅴ (CP9A)",
                        "LANCER EVOLUTION Ⅵ (CP9A)"
                    });
                    break;
                case (6):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "Cappuccino (EA11R)"
                    });
                    break;
                case (7):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "SILEIGHTY"
                    });
                    break;
                case (8):
                    cb_car.Items.Clear();
                    cb_car.Items.AddRange(new object[] {
                        "幻気-7 (FD3S)",
                        "MONSTER CIVIC R (EK9)",
                        "S2000 GT1 (AP1)",
                        "G-FORCE SUPRA (JZA80改)",
                        "ROADSTER C-SPEC (NA8C改)",
                        "NSX-R GT (NA2)"
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int newOrder = 0;
            bool ifUpdate = false;

            for (int index = 0; index < 10; index++)
            {
                if (isLeftLarger(TimeToInt(txtTime.Text.ToString().Replace("'", "")), TimeToInt(gvRank.Rows[index].Cells[2].Value.ToString().Replace("'", ""))))
                {
                    newOrder = index + 1;
                    //lbTest.Text = "true, is larger than " + index;
                    if(newOrder <= 9)
                        ifUpdate = true;
                }
            }
            if (ifUpdate)
            {
                for (int index = 9; index >= newOrder; index--)
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        gvRank.Rows[index].Cells[i].Value = gvRank.Rows[index - 1].Cells[i].Value;
                    }
                }
                gvRank.Rows[newOrder].Cells[1].Value = ToSBC(txtName.Text);
                gvRank.Rows[newOrder].Cells[2].Value = IntToTime(TimeToInt(txtTime.Text.ToString().Replace("'", "")));
                gvRank.Rows[newOrder].Cells[3].Value = table_Cars[cb_maker.SelectedIndex, cb_car.SelectedIndex];
                gvRank.Rows[newOrder].Cells[4].Value = table_Area[cbArea.SelectedIndex];
                gvRank.Rows[newOrder].Cells[5].Value = dateTimePicker1.Value;
                gvRank.Rows[newOrder].Cells[6].Value = cb_maker.SelectedIndex;
                gvRank.Rows[newOrder].Cells[7].Value = cb_car.SelectedIndex;
                gvRank.Rows[newOrder].Cells[8].Value = cbArea.SelectedIndex;
            }
        }
    }
}
