using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormularioGrafica.MongoDB {

    public partial class CadastrarImagens : UserControl {
        private byte[] conteudo;// verificar se precisa dar new
        private DBConnect dBConnect;

        public CadastrarImagens() {
            InitializeComponent();
        }

        public static byte[] ReadFully(Stream input) {
            using (MemoryStream ms = new MemoryStream()) {
                input.CopyTo(ms);
                return ms.ToArray();
            }
        }

        private void buttonAbrir_Click(object sender, EventArgs e) {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                //Get the path of specified file
                textBoxNome.Text = openFileDialog.SafeFileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                conteudo = ReadFully(fileStream);

            }
        }

        private void buttonCadastrar_Click(object sender, EventArgs e) {
            dBConnect = new DBConnect();
            if (dBConnect.ListarDatabases().Count != 0) // verificar conexão
                dBConnect.InserirImagem(textBoxNome.Text, conteudo);
        }

        private void CadastrarImagens_Load(object sender, EventArgs e) {

        }
    }
}

// Função readfully https://stackoverflow.com/questions/221925/creating-a-byte-array-from-a-stream