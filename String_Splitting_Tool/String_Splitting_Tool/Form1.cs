using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Splitting_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Length > 0)
            {
                string[] output = richTextBox1.Text.Split(new string[] { textBox1.Text }, StringSplitOptions.RemoveEmptyEntries);
                StringBuilder sb = new StringBuilder();
                foreach (string s in output)
                {
                    sb.Append(s.Trim() + "\r\n");
                }
                sb.Remove(sb.Length - 2, 2);
                richTextBox2.Text = sb.ToString();
                Clipboard.SetText(sb.ToString());
            }
        }
    }
}
