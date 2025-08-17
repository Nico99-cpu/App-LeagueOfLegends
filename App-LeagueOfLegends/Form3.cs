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
    public partial class Form3 : Form
    {
        private List<Champions> listaCampeones;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ChampionTienda tienda = new ChampionTienda();
            listaCampeones = tienda.listar();
            dgvCampeones.DataSource = listaCampeones;
            pbCampeones.Load(listaCampeones[0].UrlImagen);
        }

        private void dgvPokemon_SelectionChanged(object sender, EventArgs e)
        {
            Champions seleccionado = (Champions)dgvCampeones.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pbCampeones.Load(imagen);
            }
            catch (Exception ex)
            {
                pbCampeones.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }
    }
}
