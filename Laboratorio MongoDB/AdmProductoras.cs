using MongoDB.Bson;
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
    public partial class AdmProductoras : Form
    {
        Conexion conexionMongo;
        public AdmProductoras()
        {
            InitializeComponent();
            conexionMongo= new Conexion();
            leerBDProdu();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;

            string web = tbWeb.Text;
            int annio = Convert.ToInt32(tbAnnioF.Text);
            conexionMongo.insertarProductora(nombre,annio,web);
            MessageBox.Show("Productora registrada");
            leerBDProdu();
        }
        private void leerBDProdu()
        {
            dgvProductoras.Rows.Clear();
            dgvProductoras.Columns.Clear();
            dgvProductoras.DataSource = conexionMongo.leerProductoras();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjectId id = ObjectId.Parse(Convert.ToString(dgvProductoras.CurrentRow.Cells[0].Value));
            conexionMongo.eliminarElemento(id, 1);
            MessageBox.Show("Productora eliminada");
            leerBDProdu();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            ObjectId id = ObjectId.Parse(Convert.ToString(dgvProductoras.CurrentRow.Cells[0].Value));
            string web = tbWeb.Text;
            int annio = Convert.ToInt32(tbAnnioF.Text);
            conexionMongo.modificarProductora(id,nombre, annio, web);
            MessageBox.Show("Productora modificada");
            leerBDProdu();
        }
    }
}
