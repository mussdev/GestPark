﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestPark
{
    public partial class FormApropos : Form
    {
        public FormApropos()
        {
            InitializeComponent();
        }

        private void btnCloseFormApropos_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
