using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.GridFS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioGrafica.MongoDB {

    internal class DBConnect {
        static private MongoClient dbClient;
        static private IMongoDatabase database;
        static private IMongoCollection<BsonDocument> collection;

        public DBConnect() {
            dbClient = new MongoClient("mongodb://admin:admin123@clustermonline-shard-00-00-zd9mu.mongodb.net:27017,clustermonline-shard-00-01-zd9mu.mongodb.net:27017,clustermonline-shard-00-02-zd9mu.mongodb.net:27017/test?ssl=true&replicaSet=ClusterMOnline-shard-0&authSource=admin&retryWrites=true&w=majority");
            database = dbClient.GetDatabase("testeDatabase");
            collection = database.GetCollection<BsonDocument>("testeCollection");
        }

        public List<object> ListarDatabases() {
            List<object> listaTemp = new List<object>();

            try {
                var dbList = dbClient.ListDatabases().ToList();
                foreach (var db in dbList) {
                    listaTemp.Add(db);
                }

            }
            catch (Exception) {
                MessageBox.Show("Não foi possível conectar com o banco!");
            }

            return listaTemp;
        }

        public void InserirItem() {
            string palavra = "yo";
            BsonArray bLista = new BsonArray();
            bLista.Add(new BsonDocument("campo", "valor"));
            bLista.Add(new BsonDocument("campo2", "valor2"));

            var document = new BsonDocument
            {
                { "name", "MongoDB" },
                { "type", bLista },
                { "campo", palavra },
                { "tipo", 45.6 },
                { "count", 1 },
                { "info", new BsonDocument
                    {
                        { "x", 203 },
                        { "y", 102 }
                    }}
            };
            collection.InsertOne(document);
        }// fim inserir

        public void InserirDocumento(BsonDocument bsonElements) {
            collection.InsertOne(bsonElements);
        }

        public void InserirImagem(string nome, byte[] conteudo) {
            var bucket = new GridFSBucket(database, new GridFSBucketOptions {
                BucketName = "imagens",
                //ChunkSizeBytes = 1048576, 1MB
                WriteConcern = WriteConcern.WMajority,
                ReadPreference = ReadPreference.Secondary
            });
            var id = bucket.UploadFromBytes(nome, conteudo);
            //result = Convert.ToByte(number);
        }

        public BsonArray Busca(BsonArray vetorDocumentos) {
            return vetorDocumentos;

        }

        public Image buscarImagem(string nome) {
            Image image;
            GridFSBucket bucket = new GridFSBucket(database, new GridFSBucketOptions {
                BucketName = "imagens",// Bucket name tem que ser igual
                WriteConcern = WriteConcern.WMajority,
                ReadPreference = ReadPreference.Secondary
            });
            // var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, "Cartao2_inicial.png");
            // var buscal = bucket.Find(filter);
            var bytes = bucket.DownloadAsBytesByName(nome);
            image = Image.FromStream(new System.IO.MemoryStream(bytes));

            //using (image = Image.FromStream(new System.IO.MemoryStream(bytes))) {
            //    image.Save("output.jpg", ImageFormat.Png);  // Or Png
            //}

            return image;

        }

    }
}

// Site cloud neo4j https://gcp-testdrive.orbitera.com/
// Documentação c# http://mongodb.github.io/mongo-csharp-driver/2.11/getting_started/quick_tour/