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

    public partial class Panfletos : UserControl {
        private bool terminou = true;
        private DBConnect dBConnect;
        private bool detalhes;
        private bool detalhes2;
        private bool detalhes3;
        private bool detalhes4;
        private BsonArray vetorBson;

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

            carregarCampos();
        }

        private void carregarCampos() {
            vetorBson = new BsonArray();
            dBConnect = new DBConnect("imagens.files");

            vetorBson.Add(dBConnect.BuscaDocumento("Flyer1_inicial.png"));
            vetorBson.Add(dBConnect.BuscaDocumento("Cartaz2_inicial.png"));
            vetorBson.Add(dBConnect.BuscaDocumento("Folder3_inicial.png"));
            vetorBson.Add(dBConnect.BuscaDocumento("Folder4_inicial.png"));
        }

        //Picture box mouse click
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
                else if (detalhes3) {
                    detalhes3 = false;
                    pictureBox3.Controls.Clear();
                }
                else if (detalhes4) {
                    detalhes4 = false;
                    pictureBox4.Controls.Clear();
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
                else if (detalhes3) {
                    detalhes3 = false;
                    pictureBox3.Controls.Clear();
                }
                else if (detalhes4) {
                    detalhes4 = false;
                    pictureBox4.Controls.Clear();
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

        private void pictureBox3_Click(object sender, EventArgs e) {
            if (detalhes3) {
                detalhes3 = false;
                pictureBox3.Controls.Clear();
            }
            else {
                if (detalhes) {
                    detalhes = false;
                    pictureBox1.Controls.Clear();
                }
                else if (detalhes2) {
                    detalhes2 = false;
                    pictureBox2.Controls.Clear();
                }
                else if (detalhes4) {
                    detalhes4 = false;
                    pictureBox4.Controls.Clear();
                }

                detalhes3 = true;
                int altura = 0;
                var listaElementos = vetorBson[2].AsBsonDocument.GetElement(6).Value.ToBsonDocument();
                foreach (var elemento in listaElementos) {
                    Label label1 = new Label();
                    label1.AutoSize = true;
                    label1.Text = elemento.ToString();
                    label1.Location = new Point(0, altura);
                    pictureBox3.Controls.Add(label1);
                    label1.BringToFront();
                    altura += 20;
                }

                pictureBox3.Controls.Add(pictureBoxDetalhes);
                pictureBoxDetalhes.Dock = DockStyle.Fill;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e) {
            if (detalhes4) {
                detalhes4 = false;
                pictureBox4.Controls.Clear();
            }
            else {
                if (detalhes) {
                    detalhes = false;
                    pictureBox1.Controls.Clear();
                }
                else if (detalhes2) {
                    detalhes2 = false;
                    pictureBox2.Controls.Clear();
                }
                else if (detalhes3) {
                    detalhes3 = false;
                    pictureBox3.Controls.Clear();
                }

                detalhes4 = true;
                int altura = 0;
                var listaElementos = vetorBson[3].AsBsonDocument.GetElement(6).Value.ToBsonDocument();
                foreach (var elemento in listaElementos) {
                    Label label1 = new Label();
                    label1.AutoSize = true;
                    label1.Text = elemento.ToString();
                    label1.Location = new Point(0, altura);
                    pictureBox4.Controls.Add(label1);
                    label1.BringToFront();
                    altura += 20;
                }

                pictureBox4.Controls.Add(pictureBoxDetalhes);
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

        private void pictureBox3_MouseEnter(object sender, EventArgs e) {
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.Cursor = Cursors.Hand;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e) {
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.Cursor = Cursors.Default;
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e) {
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.Cursor = Cursors.Hand;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e) {
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.Cursor = Cursors.Default;
        }

        //Fim Efeito de entrar e sair

    }
}