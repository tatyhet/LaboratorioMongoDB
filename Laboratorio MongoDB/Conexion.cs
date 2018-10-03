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

        public BindingList<Productora> leerProductoras()
        {
            var collection = database.GetCollection<Productora>("Productoras");
            BindingList<Productora> doclist = new BindingList<Productora>();
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

        public void modificarProductora(ObjectId id, string nNombre,int nAnnio, string nWeb)
        {
            var collection = database.GetCollection<Productora>("Productoras");
            var query = from Productora in collection.AsQueryable<Productora>()
                        where Productora.Id == id
                        select Productora;
            var mongoQuery = ((MongoQueryable<Productora>)query).GetMongoQuery();
            var update = Update.Set("Nombre", nNombre);
            update.Set("AnnioFundacion", nAnnio);
            update.Set("DirWeb", nWeb);
            collection.Update(mongoQuery, update);
        }

        public void insertarPelicula(string nNombre, string nGenero, string nDirector, string nFranquicia, string nPais,
            int nAnnio, int nDuracion, string nProductor, List<string> nActores)
        {
            var collection = database.GetCollection<BsonDocument>("Peliculas");
            Pelicula nuevaP= new Pelicula(nNombre, nGenero, nDirector, nFranquicia, nPais,nAnnio,nDuracion,nProductor,nActores);         
            collection.Insert(nuevaP);
        }

        public void insertarProductora(string nNombre, int nAnnioFundacion, string nWeb)
        {
            var collection = database.GetCollection<BsonDocument>("Productoras");
            Productora nuevaP = new Productora(nNombre, nAnnioFundacion, nWeb);
            collection.Insert(nuevaP);
        }

        public void eliminarElemento(ObjectId id,byte filtradorBorrado)
        {
            var query = Query.EQ("_id",id);
            MongoCollection<BsonDocument> collection= null;
            if(filtradorBorrado==0)
                 collection = database.GetCollection<BsonDocument>("Peliculas");
            else
                collection = database.GetCollection<BsonDocument>("Productoras");
            collection.Remove(query);
        }
        public List<Pelicula> buscarNombre(string nombre)
        {
            MongoCollection<Pelicula> collection = database.GetCollection<Pelicula>("Peliculas");
            var query = Query<Pelicula>.EQ(u => u.Nombre, nombre);

            List<Pelicula> list = collection.Find(query).ToList<Pelicula>();
            return list;
        }
        public List<Pelicula> buscarFranquicia(string franquicia)
        {
            MongoCollection<Pelicula> collection = database.GetCollection<Pelicula>("Peliculas");
            var query = Query<Pelicula>.EQ(u => u.Franquicia, franquicia);

            List<Pelicula> list = collection.Find(query).ToList<Pelicula>();
            return list;
        }


    }
}
