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
        private DBConnect dBConnect;

        public Form1Mongo() {
            InitializeComponent();

        }

        public void ConectarBanco() {
            backgroundWorkerMongo.RunWorkerAsync();
        }

        private void backgroundWorkerMongo_DoWork(object sender, DoWorkEventArgs e) {
            dBConnect = new DBConnect(); //Remover essa conexão
            listaDatabases = dBConnect.ListarDatabases();//Remover listar databases
            try {
                cartoes1.AtualizarImagens();
            }
            catch (Exception) {
                MessageBox.Show("Não foi possível carregar as imagens do banco");
            }
        }

        private void Form1Mongo_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void backgroundWorkerMongo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (listaDatabases.Count != 0) {
                labelStatus.ForeColor = Color.DodgerBlue;
                labelStatus.Text = "Status: Conectado";
            }
        }

        private void buttonCartao_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 1;
            buttonPanfletos.FlatAppearance.BorderSize = 0;
            buttonAdesivos.FlatAppearance.BorderSize = 0;
            buttonBanners.FlatAppearance.BorderSize = 0;
            buttonCadastrarI.FlatAppearance.BorderSize = 0;

            cartoes1.Show();
            panfletos1.Hide();
            adesivos1.Hide();
            banners1.Hide();
            cadastrarImagens1.Hide();
            textBoxBusca.Show();
            button2.Show();
            pictureBox4.Show();

            //cartoes1.AtualizarImagens();
        }

        private void buttonPanfletos_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 0;
            buttonPanfletos.FlatAppearance.BorderSize = 1;
            buttonAdesivos.FlatAppearance.BorderSize = 0;
            buttonBanners.FlatAppearance.BorderSize = 0;
            buttonCadastrarI.FlatAppearance.BorderSize = 0;

            cartoes1.Hide();
            panfletos1.Show();
            adesivos1.Hide();
            banners1.Hide();
            cadastrarImagens1.Hide();
            textBoxBusca.Show();
            button2.Show();
            pictureBox4.Show();

            panfletos1.CarregarPanfletos();

        }

        private void buttonAdesivos_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 0;
            buttonPanfletos.FlatAppearance.BorderSize = 0;
            buttonAdesivos.FlatAppearance.BorderSize = 1;
            buttonBanners.FlatAppearance.BorderSize = 0;
            buttonCadastrarI.FlatAppearance.BorderSize = 0;

            cartoes1.Hide();
            panfletos1.Hide();
            adesivos1.Show();
            banners1.Hide();
            cadastrarImagens1.Hide();
            textBoxBusca.Show();
            button2.Show();
            pictureBox4.Show();

            adesivos1.CarregarAdesivos();
        }

        private void buttonBanners_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 0;
            buttonPanfletos.FlatAppearance.BorderSize = 0;
            buttonAdesivos.FlatAppearance.BorderSize = 0;
            buttonBanners.FlatAppearance.BorderSize = 1;
            buttonCadastrarI.FlatAppearance.BorderSize = 0;

            cartoes1.Hide();
            panfletos1.Hide();
            adesivos1.Hide();
            banners1.Show();
            cadastrarImagens1.Hide();
            textBoxBusca.Show();
            button2.Show();
            pictureBox4.Show();

            banners1.CarregarBanners();

        }

        private void buttonCadastrarI_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 0;
            buttonPanfletos.FlatAppearance.BorderSize = 0;
            buttonAdesivos.FlatAppearance.BorderSize = 0;
            buttonBanners.FlatAppearance.BorderSize = 0;
            buttonCadastrarI.FlatAppearance.BorderSize = 1;

            cartoes1.Hide();
            panfletos1.Hide();
            adesivos1.Hide();
            banners1.Hide();
            cadastrarImagens1.Show();
            textBoxBusca.Hide();
            button2.Hide();
            pictureBox4.Hide();
        }

        private void textBoxBusca_KeyUp(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                //enter key is down
            }
        }

    }
}

// Imagens retiradas do site https://www.360imprimir.com.br/grupo/cartoes