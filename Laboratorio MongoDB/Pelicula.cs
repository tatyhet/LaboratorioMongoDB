using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.ComponentModel;

namespace Laboratorio_MongoDB
{
    class Pelicula
    {
        private ObjectId id;
        private string nombre;
        private string genero;
        private string director;
        private string franquicia;
        private string paisP;
        private int annioEstreno;
        private int duracion;
        private string productora;
        private List<string> actores;

        public ObjectId Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Director { get => director; set => director = value; }
        public string Franquicia { get => franquicia; set => franquicia = value; }
        public string PaisP { get => paisP; set => paisP = value; }
        public int AnnioEstreno { get => annioEstreno; set => annioEstreno = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public string Productora { get => productora; set => productora = value; }
        public List<string> Actores { get => actores; set => actores = value; }
    }
}
