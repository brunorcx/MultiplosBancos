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

    public partial class Banners : UserControl {
        private bool terminou = true;
        private DBConnect dBConnect;

        public Banners() {
            InitializeComponent();
        }

        public void CarregarBanners() {
            if (terminou)
                backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            terminou = false;
            dBConnect = new DBConnect();
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
            image = dBConnect.BuscarImagem("Banner1_inicial.png");
            pictureBox1.Image = image;

            image = dBConnect.BuscarImagem("Banners2_inicial.png");
            pictureBox2.Image = image;

            image = dBConnect.BuscarImagem("Banners3_inicial.png");
            pictureBox3.Image = image;

            image = dBConnect.BuscarImagem("Banners4_inicial.png");
            pictureBox4.Image = image;
        }
    }
}

// Imagens de banners https://www.vistaprint.com/
// https://outreach.com/
// https://www.orientaltrading.com/party-supplies/party-decorations/banners/graduation-a1-551269+1256-1.fltr