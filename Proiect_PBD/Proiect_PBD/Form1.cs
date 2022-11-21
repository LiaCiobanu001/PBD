namespace Proiect_PBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VizualizareClient_BT_Click(object sender, EventArgs e)
        {
            Form f = new Vizualizare_Client();   
            f.ShowDialog();
           
        }

        private void AdaugareClientBT_Click(object sender, EventArgs e)
        {
            Form f = new AdaugareClient();
            f.ShowDialog();
        }

        private void VizualizareAchizitiiBT_Click(object sender, EventArgs e)
        {
            Form f=new VizualizareAchizitii();
            f.ShowDialog();
        }

        private void AdaugareAchizitieBT_Click(object sender, EventArgs e)
        {
            Form f= new AdaugareAchizitie();
            f.ShowDialog();
        }
    }
}