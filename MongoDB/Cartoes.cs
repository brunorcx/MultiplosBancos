using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;

namespace FormularioGrafica.MongoDB {

    public partial class Cartoes : UserControl {
        private DBConnect dBConnect;
        private bool detalhes;
        private bool detalhes2;
        private BsonArray vetorBson;

        public Cartoes() {
            InitializeComponent();

        }

        public void AtualizarImagens() {
            Image image;
            dBConnect = new DBConnect();
            image = dBConnect.BuscarImagem("Cartao2_inicial.png");
            pictureBox2.Image = image;

            image = dBConnect.BuscarImagem("Cartao3_inicial.png");
            pictureBox3.Image = image;

            image = dBConnect.BuscarImagem("Cartao4_inicial.png");
            pictureBox4.Image = image;

            image = dBConnect.BuscarImagem("Cartao5_inicial.png");
            pictureBox5.Image = image;

            backgroundWorker1.RunWorkerAsync(); // Carregar campos
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            if (detalhes) {
                detalhes = false;
                pictureBox1.Controls.Clear();
            }
            else {
                if (detalhes2) {
                    detalhes2 = false;
                    pictureBox2.Controls.Clear();
                }

                detalhes = true;
                int altura = 0;
                var listaElementos = vetorBson[0].AsBsonDocument.GetElement(6).Value.ToBsonDocument();
                foreach (var elemento in listaElementos) {
                    Label label1 = new Label();
                    label1.AutoSize = true;
                    label1.Text = elemento.ToString();
                    label1.Location = new Point(0, altura);
                    pictureBox1.Controls.Add(label1);
                    label1.BringToFront();
                    altura += 20;
                }

                pictureBox1.Controls.Add(pictureBoxDetalhes);
                pictureBoxDetalhes.Dock = DockStyle.Fill;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e) {
            if (detalhes2) {
                detalhes2 = false;
                pictureBox2.Controls.Clear();
            }
            else {
                if (detalhes) {
                    detalhes = false;
                    pictureBox1.Controls.Clear();
                }

                detalhes2 = true;
                int altura = 0;
                var listaElementos = vetorBson[1].AsBsonDocument.GetElement(6).Value.ToBsonDocument();
                foreach (var elemento in listaElementos) {
                    Label label1 = new Label();
                    label1.AutoSize = true;
                    label1.Text = elemento.ToString();
                    label1.Location = new Point(0, altura);
                    pictureBox2.Controls.Add(label1);
                    label1.BringToFront();
                    altura += 20;
                }

                pictureBox2.Controls.Add(pictureBoxDetalhes);
                pictureBoxDetalhes.Dock = DockStyle.Fill;
            }
        }

        //Efeito de entrar e sair
        private void pictureBox1_MouseEnter(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Cursor = Cursors.Default;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e) {
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.Cursor = Cursors.Hand;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e) {
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.Cursor = Cursors.Default;
        }

        //Fim Efeito de entrar e sair

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            carregarCampos();
        }

        private void carregarCampos() {
            vetorBson = new BsonArray();
            dBConnect = new DBConnect("imagens.files");

            vetorBson.Add(dBConnect.BuscaDocumento("Cartao1_inicial.png"));
            vetorBson.Add(dBConnect.BuscaDocumento("Cartao2_inicial.png"));
            //vetorBson.Add(dBConnect.BuscaDocumento("Cartao3_inicial.png"));
            //vetorBson.Add(dBConnect.BuscaDocumento("Cartao4_inicial.png"));
            //vetorBson.Add(dBConnect.BuscaDocumento("Cartao5_inicial.png"));
        }

    }
}