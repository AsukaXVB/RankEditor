using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {
            Form1.championUpdate(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString());
            this.Dispose();
        }
    }
}
