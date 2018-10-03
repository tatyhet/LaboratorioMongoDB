using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

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
        public void modificarPelicula(ObjectId id, string nNombre, string nGenero, string nDirector, string nFranquicia, string nPais,
            int nAnnio, int nDuracion, string nProductor, List<string> nActores)
        {
            var collection = database.GetCollection<Pelicula>("Peliculas");
            var query = from Pelicula in collection.AsQueryable<Pelicula>()
                        where Pelicula.Id == id
                        select Pelicula;
            var mongoQuery = ((MongoQueryable<Pelicula>)query).GetMongoQuery();
            var update = Update.Set("Nombre", nNombre);
            update.Set("Genero", nGenero);
            update.Set("Director", nDirector);
            update.Set("Franquicia", nFranquicia);
            update.Set("PaisP", nPais);
            update.Set("AnnioEstreno", nAnnio);
            update.Set("Duracion", nDuracion);
            update.Set("Productora", nProductor);
            update.Set("Actores",  BsonValue.Create( nActores.ToArray()));

            collection.Update(mongoQuery, update);

        }

        public void insertarPelicula(string nNombre, string nGenero, string nDirector, string nFranquicia, string nPais,
            int nAnnio, int nDuracion, string nProductor, List<string> nActores)
        {
            var collection = database.GetCollection<BsonDocument>("Peliculas");
            Pelicula nuevaP= new Pelicula(nNombre, nGenero, nDirector, nFranquicia, nPais,nAnnio,nDuracion,nProductor,nActores);         
            collection.Insert(nuevaP);
        }

        public void eliminarPelicula(ObjectId id)
        {
            var query = Query.EQ("_id",id);
            var collection = database.GetCollection<BsonDocument>("Peliculas");
            collection.Remove(query);
        }
    }
}
