using System;
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
    public partial class VizualizareAchizitii : Form
    {
        public VizualizareAchizitii()
        {
            InitializeComponent();
        }

        private void AdaugareBT_Click(object sender, EventArgs e)
        {
            Form f = new AdaugareAchizitie();
            f.ShowDialog();
        }

        private void StergeBT_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Esti sigura ca doresti sa stergi aceasta achizitie?", "Warning",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {

            }
            else
            {

            }
        }

        private void MeniuBT_Click(object sender, EventArgs e)
        {
            Form f = new Form1();
            f.ShowDialog();
        }
    }
}
