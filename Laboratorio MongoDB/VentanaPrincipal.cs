using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio_MongoDB
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnPeli_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ventanaPeliculas = new AdmPeliculas();
            ventanaPeliculas.Closed += (s, args) => this.Close();
            ventanaPeliculas.Show();
        }

        private void btnProdu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ventanaProductoras = new AdmProductoras();
            ventanaProductoras.Closed += (s, args) => this.Close();
            ventanaProductoras.Show();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ventanaInfo = new ventanaInformacion();
            ventanaInfo.Closed += (s, args) => this.Close();
            ventanaInfo.Show();
        }
    }
}
