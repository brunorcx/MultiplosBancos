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

    public partial class Adesivos : UserControl {
        private bool terminou = true;
        private DBConnect dBConnect;

        public Adesivos() {
            InitializeComponent();
        }

        public void CarregarAdesivos() {
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
            image = dBConnect.BuscarImagem("Ima1_inicial.png");
            pictureBox1.Image = image;

            image = dBConnect.BuscarImagem("Adesivos2_inicial.png");
            pictureBox2.Image = image;

            image = dBConnect.BuscarImagem("Tag3_inicial.png");
            pictureBox3.Image = image;

            image = dBConnect.BuscarImagem("Adesivo4_inicial.png");
            pictureBox4.Image = image;
        }
    }
}