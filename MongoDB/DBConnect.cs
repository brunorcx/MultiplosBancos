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

        public DBConnect(string imagens) {
            dbClient = new MongoClient("mongodb://admin:admin123@clustermonline-shard-00-00-zd9mu.mongodb.net:27017,clustermonline-shard-00-01-zd9mu.mongodb.net:27017,clustermonline-shard-00-02-zd9mu.mongodb.net:27017/test?ssl=true&replicaSet=ClusterMOnline-shard-0&authSource=admin&retryWrites=true&w=majority");
            database = dbClient.GetDatabase("testeDatabase");
            collection = database.GetCollection<BsonDocument>(imagens);
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

        public ObjectId InserirImagem(string nome, byte[] conteudo) {
            var bucket = new GridFSBucket(database, new GridFSBucketOptions {
                BucketName = "imagens",
                //ChunkSizeBytes = 1048576, 1MB
                WriteConcern = WriteConcern.WMajority,
                ReadPreference = ReadPreference.Secondary
            });
            var id = bucket.UploadFromBytes(nome, conteudo);

            return id;
            //result = Convert.ToByte(number);
        }

        public ObjectId InserirImagem(string nome, byte[] conteudo, BsonDocument documento) {
            var bucket = new GridFSBucket(database, new GridFSBucketOptions {
                BucketName = "imagens",
                //ChunkSizeBytes = 1048576, 1MB
                WriteConcern = WriteConcern.WMajority,
                ReadPreference = ReadPreference.Secondary
            });

            var options = new GridFSUploadOptions {
                Metadata = documento
            };

            var id = bucket.UploadFromBytes(nome, conteudo, options);

            return id;
        }

        public BsonArray Busca(BsonArray vetorDocumentos) {
            return vetorDocumentos;
        }

        public Image BuscarImagem(string nome) {
            Image image;
            GridFSBucket bucket = new GridFSBucket(database, new GridFSBucketOptions {
                BucketName = "imagens",// Bucket name tem que ser igual
                WriteConcern = WriteConcern.WMajority,
                ReadPreference = ReadPreference.Secondary
            });
            // var filter = Builders<GridFSFileInfo>.Filter.Eq(x => x.Filename, "Cartao2_inicial.png");
            // var buscal = bucket.Find(filter);

            var bytes = bucket.DownloadAsBytesByName(nome); // CASO NÃO ENCONTRE DARÁ ERRO
            image = Image.FromStream(new System.IO.MemoryStream(bytes));

            //using (image = Image.FromStream(new System.IO.MemoryStream(bytes))) {
            //    image.Save("output.jpg", ImageFormat.Png);  // Or Png
            //}

            return image;

        }

        public void updateDocumento(ObjectId id, BsonDocument documento) {
            var filter = Builders<BsonDocument>.Filter.Eq("id", id);
            //var update = Builders<BsonDocument>.Update.Set(documento.First().Name, documento.First().Value);
            //collection.UpdateOne(filter, documento);
            collection.UpdateOneAsync(filter, documento);
        }

        //public BsonDocument buscarCampos() {
        //    ObjectId id = collection.Find()
        // }

    }
}

// Site cloud neo4j https://gcp-testdrive.orbitera.com/
// Documentação c# http://mongodb.github.io/mongo-csharp-driver/2.11/getting_started/quick_tour/