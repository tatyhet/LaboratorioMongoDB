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
    public partial class ventanaInformacion : Form
    {
        private Conexion conexionMongo;
        public ventanaInformacion()
        {
            InitializeComponent();
            conexionMongo = new Conexion();
            dgvInfo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            for(int i= 2018; i >= 1895; i--)
            {
                cbAFecha.Items.Add(i);
                cbDFecha.Items.Add(i);
            }
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            leerBD();
        }

        public void llenarColumnasPeliculas()
        {
            dgvInfo.Columns.Add("Identificador", "Identificador");
            dgvInfo.Columns.Add("Nombre", "Nombre");
            dgvInfo.Columns.Add("Género", "Género");
            dgvInfo.Columns.Add("Dirección", "Dirección");
            dgvInfo.Columns.Add("Franquicia", "Franquicia");
            dgvInfo.Columns.Add("País", "País");
            dgvInfo.Columns.Add("Año de estreno", "Año de estreno");
            dgvInfo.Columns.Add("Duración en minutos", "Duración en minutos");
            dgvInfo.Columns.Add("Compañia productura", "Compañia productora");
            dgvInfo.Columns.Add("Actores", "Actores");
            dgvInfo.Columns[9].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        public void llenarPeliculas(List<Pelicula> peliculas)
        {
            for (int i = 0; i != peliculas.Count; i++)
            {
                Pelicula nuevaP = peliculas[i];
                String actores = obtenerActores(nuevaP.Actores);
                dgvInfo.Rows.Add(nuevaP.Id, nuevaP.Nombre, nuevaP.Genero, nuevaP.Director, nuevaP.Franquicia,
                    nuevaP.PaisP, nuevaP.AnnioEstreno, nuevaP.Duracion, nuevaP.Productora, actores);
            }
        }
        public String obtenerActores(List<String> listaActores)
        {
            String salida = "";
            for (int i = 0; listaActores != null && i != listaActores.Count; i++)
            {
                if (i + 1 == listaActores.Count)
                    salida = salida + listaActores[i];
                else
                    salida = salida + listaActores[i] + " , ";
            }
            return salida;
        }
        public void leerBD()
        {
            dgvInfo.Rows.Clear();
            dgvInfo.Columns.Clear();
            List<Pelicula> peliculas= new List<Pelicula>();
            if (tbNombre.Text != "")
            {
                peliculas = conexionMongo.buscarNombre(tbNombre.Text);
                MessageBox.Show("Buscando por nombre...");
            }else if (tbFranquicia.Text != "")
            {
                peliculas = conexionMongo.buscarFranquicia(tbFranquicia.Text);
                MessageBox.Show("Buscando por franquicia...");
            }else if (cbAFecha.SelectedIndex> -1 && cbDFecha.SelectedIndex> -1)
            {
                peliculas = conexionMongo.buscarEntreAnnios(Convert.ToInt32(cbDFecha.SelectedItem),Convert.ToInt32 (cbAFecha.SelectedItem));
                MessageBox.Show("Buscando por Años...");
            }
            llenarColumnasPeliculas();
            llenarPeliculas(peliculas);
        }
    }
}
