﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppBuffetFrancisco.View
{
    public partial class TelaFechaVenda : Form
        
    {
        private int totalfinal;

        public TelaFechaVenda(int totalfinal)
        {
            this.totalfinal = totalfinal;
            InitializeComponent();
        }
        
        private void TelaFechaVenda_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToString();
            label9.Text = "R$:" + totalfinal + ",00".ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
