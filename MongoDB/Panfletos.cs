using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioGrafica.MongoDB {

    public partial class Panfletos : UserControl {
        private bool terminou = true;
        private DBConnect dBConnect;

        public Panfletos() {
            InitializeComponent();
        }

        public void CarregarPanfletos() {
            if (terminou)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            terminou = false;
            dBConnect = new DBConnect(); //Remover essa conexão
            if (dBConnect.ListarDatabases().Count != 0) {
                try {
                    AtualizarImagens();
                }
                catch (Exception) {
                    MessageBox.Show("Não foi possível carregar as imagens do banco");
                }

            }

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            terminou = true;
        }

        private void AtualizarImagens() {
            Image image;
            image = dBConnect.BuscarImagem("Flyer1_inicial.png");
            pictureBox1.Image = image;

            image = dBConnect.BuscarImagem("Cartaz2_inicial.png");
            pictureBox2.Image = image;

            image = dBConnect.BuscarImagem("Folder3_inicial.png");
            pictureBox3.Image = image;

            image = dBConnect.BuscarImagem("Folder4_inicial.png");
            pictureBox4.Image = image;
        }
    }
}