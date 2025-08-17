using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_LeagueOfLegends
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Form2 Registrarse = new Form2();
            Registrarse.MdiParent = this;
            Registrarse.Show();
        }

        private void btnCampeones_Click(object sender, EventArgs e)
        {                

            Form3 Campeones = new Form3();
            Campeones.MdiParent = this;
            Campeones.Show();
        }
    }
}
