﻿using MongoDB.Bson;
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
    public partial class AdmPeliculas : Form
    {
        private Conexion conexionMongo;
        public AdmPeliculas()
        {
            InitializeComponent();            
            conexionMongo = new Conexion();            
            dgvPeliculas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            leerBD();
        }

        public void llenarColumnasPeliculas()
        {
            dgvPeliculas.Columns.Add("Identificador", "Identificador");
            dgvPeliculas.Columns.Add("Nombre", "Nombre");
            dgvPeliculas.Columns.Add("Género","Género");
            dgvPeliculas.Columns.Add("Dirección","Dirección");
            dgvPeliculas.Columns.Add("Franquicia","Franquicia");
            dgvPeliculas.Columns.Add("País","País");
            dgvPeliculas.Columns.Add("Año de estreno","Año de estreno");
            dgvPeliculas.Columns.Add("Duración en minutos","Duración en minutos");
            dgvPeliculas.Columns.Add("Compañia productura","Compañia productora");
            dgvPeliculas.Columns.Add("Actores","Actores");
            dgvPeliculas.Columns[9].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }
        public void llenarPeliculas(BindingList<Pelicula> peliculas)
        {
            for (int i = 0; i != peliculas.Count; i++)
            {
                Pelicula nuevaP = peliculas[i];
                String actores = obtenerActores(nuevaP.Actores);
                dgvPeliculas.Rows.Add(nuevaP.Id, nuevaP.Nombre, nuevaP.Genero, nuevaP.Director, nuevaP.Franquicia, 
                    nuevaP.PaisP, nuevaP.AnnioEstreno,nuevaP.Duracion, nuevaP.Productora, actores);
            }
        }
        public String obtenerActores(List<String> listaActores)
        {
            String salida= "";
            for (int i=0;listaActores!=null&&i!=listaActores.Count;i++)
            {
                if (i+1 == listaActores.Count)
                    salida = salida + listaActores[i];
                else
                    salida = salida +  listaActores[i]+" , " ;
            }
            return salida;
        }
        public void leerBD()
        {
            dgvPeliculas.Rows.Clear();
            dgvPeliculas.Columns.Clear();
            BindingList<Pelicula> peliculas = conexionMongo.leerPeliculas();
            llenarColumnasPeliculas();
            llenarPeliculas(peliculas);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ObjectId id = ObjectId.Parse(Convert.ToString( dgvPeliculas.CurrentRow.Cells[0].Value));
            string nombre = tbNombre.Text;
            string genero = tbGenero.Text;
            string direccion = tbDirector.Text;
            string franquicia = tbFranquicia.Text;

            string pais = tbPais.Text;
            int annio = Convert.ToInt32( tbAnnio.Text);
            int duracion = Convert.ToInt32(tbDuracion.Text);
            string productor = tbProductor.Text;
            List<string> actores = (tbActores.Text).Split(',').ToList<string>();

            //List<string> nombre = ;
            conexionMongo.modificarPelicula(id,nombre,genero,direccion,franquicia,pais,annio,duracion,productor,actores);
            MessageBox.Show("Película modificada");
            leerBD();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {            
            string nombre = tbNombre.Text;
            string genero = tbGenero.Text;
            string direccion = tbDirector.Text;
            string franquicia = tbFranquicia.Text;

            string pais = tbPais.Text;
            int annio = Convert.ToInt32(tbAnnio.Text);
            int duracion = Convert.ToInt32(tbDuracion.Text);
            string productor = tbProductor.Text;
            List<string> actores = (tbActores.Text).Split(',').ToList<string>();

            conexionMongo.insertarPelicula(nombre,genero,direccion,franquicia,pais,annio,duracion,productor,actores);

            MessageBox.Show("Película insertada");
            leerBD();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ObjectId id = ObjectId.Parse(Convert.ToString(dgvPeliculas.CurrentRow.Cells[0].Value));
            conexionMongo.eliminarElemento(id,0);
            MessageBox.Show("Película eliminada");
            leerBD();
        }
    }
}
