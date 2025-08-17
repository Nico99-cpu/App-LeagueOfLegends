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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Id = txtId.Text;
            string Mail = txtMail.Text;

            lvLista.Items.Add("Tu nombre es: " + Nombre);
            lvLista.Items.Add("Tu apellido es: " + Apellido);
            lvLista.Items.Add("Tu id es: " + Id);
            lvLista.Items.Add("Tu mail es: " + Mail);
        }
    }
}
