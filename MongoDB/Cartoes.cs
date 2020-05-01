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
            image = dBConnect.buscarImagem("Cartao2_inicial.png");
            pictureBox2.Image = image;
        }
    }
}