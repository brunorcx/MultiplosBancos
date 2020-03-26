using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioGrafica.MongoDB {

    public partial class Form1Mongo : Form {
        private List<object> listaDatabases = new List<object>();

        public Form1Mongo() {
            InitializeComponent();
        }

        public void ConectarBanco() {
            backgroundWorkerMongo.RunWorkerAsync();
        }

        private void backgroundWorkerMongo_DoWork(object sender, DoWorkEventArgs e) {
            DBConnect dBConnect = new DBConnect();
            listaDatabases = dBConnect.ListarDatabases();

        }

        private void Form1Mongo_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void buttonPesquisar_Click(object sender, EventArgs e) {
            if (listaDatabases.Count != 0) {
                foreach (var database in listaDatabases) {
                    richTextBox1.Text += database.ToString() + "\n";
                }
            }
        }

        private void backgroundWorkerMongo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (listaDatabases.Count != 0) {
                labelStatus.ForeColor = Color.DodgerBlue;
                labelStatus.Text = "Status: Conectado";
            }
        }
    }
}