﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_Hello_World
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSoma_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "")
            {
                int valor1, valor2, resul;
                valor1 = Convert.ToInt32(textBox1.Text);
                valor2 = Convert.ToInt32(textBox2.Text);

                resul = valor1 + valor2;
                lblRe.Text = resul.ToString();
            }
            else{
                MessageBox.Show("Insira um valor");
            }

                }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblnumb1_Click(object sender, EventArgs e)
        {

        }
    }
}
