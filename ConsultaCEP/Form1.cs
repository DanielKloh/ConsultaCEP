﻿using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCEP
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            

        }

        private void btnBuscarCEP_Click_1(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.ShowDialog();
            txtEndereco.Text = form2.Endereco;
        }
    }
}