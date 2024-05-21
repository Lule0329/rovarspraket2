using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
        }

        bool block = false;

        private void main()
        {
            string str = textBox1.Text; // går igenom alla konsonanter och byter ut dem till "bob" varianter
            string result = str;

            result = result.Replace("b", "bob");
            result = result.Replace("c", "coc");
            result = result.Replace("d", "dod");
            result = result.Replace("f", "fof");
            result = result.Replace("g", "gog");
            result = result.Replace("h", "hoh");
            result = result.Replace("j", "joj");
            result = result.Replace("k", "kok");
            result = result.Replace("l", "lol");
            result = result.Replace("m", "mom");
            result = result.Replace("n", "non");
            result = result.Replace("p", "pop");
            result = result.Replace("q", "qoq");
            result = result.Replace("r", "ror");
            result = result.Replace("s", "sos");
            result = result.Replace("t", "tot");
            result = result.Replace("v", "vov");
            result = result.Replace("w", "wow");
            result = result.Replace("x", "xox");
            result = result.Replace("z", "zoz");

            textBox2.Text = result;
        }

        private void main2()
        {
            string str = textBox2.Text; // gör om rövarspråk till svenska
            string result = str;

            result = result.Replace("bob", "b");
            result = result.Replace("coc", "c");
            result = result.Replace("dod", "d");
            result = result.Replace("fof", "f");
            result = result.Replace("gog", "g");
            result = result.Replace("hoh", "h");
            result = result.Replace("joj", "j");
            result = result.Replace("kok", "k");
            result = result.Replace("lol", "l");
            result = result.Replace("mom", "m");
            result = result.Replace("non", "n");
            result = result.Replace("pop", "p");
            result = result.Replace("qoq", "q");
            result = result.Replace("ror", "r");
            result = result.Replace("sos", "s");
            result = result.Replace("tot", "t");
            result = result.Replace("vov", "v");
            result = result.Replace("wow", "w");
            result = result.Replace("xox", "x");
            result = result.Replace("zoz", "z");

            textBox1.Text = result;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (block) return; // gör så att båda fönstrena inte checkar varandra hela tiden
            block = true;
            
            main();

            block = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (block) return; // gör så att båda fönstrena inte checkar varandra hela tiden
            block = true;

            main2();

            block = false;
        }
    }
}
