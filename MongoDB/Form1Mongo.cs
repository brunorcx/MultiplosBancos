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
            cartoes1.AtualizarImagens();
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

            textBoxBusca.Show();
            button2.Show();
            pictureBox4.Show();

        }

        private void buttonAdesivos_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 0;
            buttonPanfletos.FlatAppearance.BorderSize = 0;
            buttonAdesivos.FlatAppearance.BorderSize = 1;
            buttonBanners.FlatAppearance.BorderSize = 0;
            buttonCadastrarI.FlatAppearance.BorderSize = 0;

            textBoxBusca.Show();
            button2.Show();
            pictureBox4.Show();

        }

        private void buttonBanners_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 0;
            buttonPanfletos.FlatAppearance.BorderSize = 0;
            buttonAdesivos.FlatAppearance.BorderSize = 0;
            buttonBanners.FlatAppearance.BorderSize = 1;
            buttonCadastrarI.FlatAppearance.BorderSize = 0;

            textBoxBusca.Show();
            button2.Show();
            pictureBox4.Show();

        }

        private void buttonCadastrarI_Click(object sender, EventArgs e) {
            buttonCartao.FlatAppearance.BorderSize = 0;
            buttonPanfletos.FlatAppearance.BorderSize = 0;
            buttonAdesivos.FlatAppearance.BorderSize = 0;
            buttonBanners.FlatAppearance.BorderSize = 0;
            buttonCadastrarI.FlatAppearance.BorderSize = 1;

            cartoes1.Hide();
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