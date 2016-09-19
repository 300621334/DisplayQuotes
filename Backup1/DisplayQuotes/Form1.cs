using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisplayQuotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseEnter(object sender, EventArgs e)
        {
        }
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.BackColor = Color.White;
        }
        
        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.BackColor = Color.White;
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.BackColor = Color.White;
        }

       
    }
}