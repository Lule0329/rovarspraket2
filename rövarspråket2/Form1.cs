using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rövarspråket2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void main()
        {
            int length = textBox1.Text.Length;
            string str = textBox1.Text;

            for (int i = 0; i < length; i++)
            {
                str.Replace("b", "bob");
                str.Replace("c", "coc");
                str.Replace("d", "dod");
                str.Replace("f", "fof");
                str.Replace("g", "gog");
                str.Replace("h", "hoh");
                str.Replace("j", "joj");
                str.Replace("k", "kok");
                str.Replace("l", "lol");
                str.Replace("m", "mom");
                str.Replace("n", "non");
                str.Replace("p", "pop");
                str.Replace("q", "qoq");
                str.Replace("r", "ror");
                str.Replace("s", "sos");
                str.Replace("t", "tot");
                str.Replace("v", "vov");
                str.Replace("w", "wow");
                str.Replace("x", "xox");
                str.Replace("z", "zoz");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            main();
        }
    }
}
