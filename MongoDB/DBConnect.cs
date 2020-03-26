using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioGrafica.MongoDB {

    internal class DBConnect {
        static private MongoClient dbClient;

        public DBConnect() {
            dbClient = new MongoClient("mongodb://admin:admin123@clustermonline-shard-00-00-zd9mu.mongodb.net:27017,clustermonline-shard-00-01-zd9mu.mongodb.net:27017,clustermonline-shard-00-02-zd9mu.mongodb.net:27017/test?ssl=true&replicaSet=ClusterMOnline-shard-0&authSource=admin&retryWrites=true&w=majority");

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

    }
}

// Site cloud neo4j https://gcp-testdrive.orbitera.com/