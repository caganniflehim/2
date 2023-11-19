using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin1 = this.textBox1.Text;
            Form2 frm2 = new Form2();
            frm2.label1.Text = metin1;
            frm2.metin2 = metin1;
            frm2.ShowDialog();
        }
    }
}
