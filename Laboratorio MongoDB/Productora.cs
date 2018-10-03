using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_MongoDB
{
    public class Productora
    {
        private ObjectId id;
        private string nombre;
        private int annioFundacion;
        private string dirWeb;

        public Productora(string nombre, int annioFundacion, string dirWeb)
        {
            this.nombre = nombre;
            this.annioFundacion = annioFundacion;
            this.dirWeb = dirWeb;
        }

        public ObjectId Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int AnnioFundacion { get => annioFundacion; set => annioFundacion = value; }
        public string DirWeb { get => dirWeb; set => dirWeb = value; }
        
    }
}
