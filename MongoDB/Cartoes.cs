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
    }
}