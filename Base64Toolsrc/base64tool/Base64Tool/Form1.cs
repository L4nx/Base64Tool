using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string x = richTextBox1.Text;
            byte[] b = System.Text.Encoding.UTF8.GetBytes(x);
           string C = Convert.ToBase64String(b);
            richTextBox2.Text = C;
		}

        private void button2_Click(object sender, EventArgs e)
        {
            string x = richTextBox1.Text; //sry
            byte[] C = Convert.FromBase64String(x);
            string b = System.Text.Encoding.UTF8.GetString(C);
            richTextBox2.Text = b;
        }
    }
}
