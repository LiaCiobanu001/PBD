﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PBD
{
    public partial class AdaugareClient : Form
    {
        public AdaugareClient()
        {
            InitializeComponent();
        }

        private void AdaugareClientBT_Click(object sender, EventArgs e)
        {
            
        }

        private void MeniuBT_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.ShowDialog();
        }
    }
}
