using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Linq;
using System.ComponentModel;

namespace Laboratorio_MongoDB
{
    class Conexion
    {
        private String connectionString = "mongodb://localhost";
        private MongoDatabase database;
        public Conexion()
        {
            MongoClient client = new MongoClient(connectionString);
            MongoServer server = client.GetServer();
            database = server.GetDatabase("Laboratorio");            
        }

        public BindingList<Pelicula> leerPeliculas()
        {
            var collection = database.GetCollection<Pelicula>("Peliculas");
            BindingList<Pelicula> doclist = new BindingList<Pelicula>();
            foreach (var deger in collection.FindAll())
            {
                doclist.Add(deger);    
            }
            return doclist;
        }

        
    }
}
