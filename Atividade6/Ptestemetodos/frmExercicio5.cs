﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptestemetodos
{
    public partial class frmExercicio5 : Form
    {
        public frmExercicio5()
        {
            InitializeComponent();
        }

        private void btnSortear_Click(object sender, EventArgs e)
        {
            Random sortearNumero = new Random();
            int sortearValorInteiro = sortearNumero.Next(Convert.ToInt32(txtNumero1.Text), Convert.ToInt32(txtNumero2.Text));

            MessageBox.Show("O número sorteado foi: " + sortearValorInteiro);
        }
    }
}
