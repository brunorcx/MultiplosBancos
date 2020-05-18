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

    public partial class Cartoes : UserControl {
        private DBConnect dBConnect;
        private bool detalhes;

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
        }

        private void pictureBox1_Click(object sender, EventArgs e) {
            if (detalhes) {
                detalhes = false;

                pictureBox1.Controls.Clear();
            }
            else {
                detalhes = true;

                Label label = new Label();
                label.Text = "AAAAAAAAA";
                label.Location = new Point(0, 0);

                pictureBox1.Controls.Add(pictureBoxDetalhes);
                pictureBoxDetalhes.Dock = DockStyle.Fill;
                pictureBox1.Controls.Add(label);
                label.BringToFront();
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e) {
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Cursor = Cursors.Default;
        }

    }
}