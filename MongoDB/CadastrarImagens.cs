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
using MongoDB.Bson;

namespace FormularioGrafica.MongoDB {

    public partial class CadastrarImagens : UserControl {
        private byte[] conteudo;// verificar se precisa dar new
        private DBConnect dBConnect;
        private int numCampo;
        private BsonDocument document = new BsonDocument();

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
            if (textBoxCampo.Text == string.Empty || textBoxValor.Text == string.Empty || conteudo == null) {
                if (conteudo == null)
                    MessageBox.Show("Por favor selecione a figura.");
                else
                    MessageBox.Show("Por favor preencha o Campo e o valor.");
            }
            else {
                dBConnect = new DBConnect("imagens.files");
                if (dBConnect.ListarDatabases().Count != 0) { // verificar conexão
                    var id = dBConnect.InserirImagem(textBoxNome.Text, conteudo, document);
                    //document.Add("ID", id);
                    //dBConnect.InserirDocumento(document);
                    //dBConnect.updateDocumento(id, document);
                }
                MessageBox.Show("Imagem Cadastrada com sucesso!");

                //Limpar documento
                document = new BsonDocument();
                textBoxCampo.Clear();
                textBoxValor.Clear();
                labelCampo.Text = "Campo 1";
                labelValor.Text = "Valor 1";
                numCampo = 0;
            }
        }

        private void CadastrarImagens_Load(object sender, EventArgs e) {
        }

        private void buttonAnterior_Click(object sender, EventArgs e) {
            if (numCampo == 0)
                numCampo = 0;
            else
                numCampo--;

            try {
                //textBoxCampo.Text = document.GetElement(numCampo).Name.ToString();
                textBoxCampo.Text = document.GetElement(numCampo).Name.ToString();
                textBoxValor.Text = document.Elements.ElementAt(numCampo).Value.AsString;
            }
            catch (Exception) {
            }
            labelCampo.Text = "Campo " + (numCampo + 1).ToString();
            labelValor.Text = "Valor " + (numCampo + 1).ToString();

        }

        private void buttonProximo_Click(object sender, EventArgs e) {
            //Inserir o elemento já na posição correta
            //document.InsertAt(numCampo, new BsonElement(textBoxCampo.Text, textBoxValor.Text));

            if (textBoxCampo.Text == string.Empty || textBoxValor.Text == string.Empty)
                MessageBox.Show("Por favor preencha o Campo e o valor.");
            else {
                try {
                    document.SetElement(numCampo, new BsonElement(textBoxCampo.Text, textBoxValor.Text));
                    // document.InsertAt(numCampo, new BsonElement(textBoxCampo.Text, textBoxValor.Text));
                    //document[numCampo] = new BsonDocument(textBoxCampo.Text, textBoxValor.Text);
                }
                catch (Exception) {
                    document.Add(textBoxCampo.Text, textBoxValor.Text);
                }

                numCampo++;
                labelCampo.Text = "Campo " + (numCampo + 1).ToString();
                labelValor.Text = "Valor " + (numCampo + 1).ToString();

                try {
                    textBoxCampo.Text = document.GetElement(numCampo).Name.ToString();
                    textBoxValor.Text = document.Elements.ElementAt(numCampo).Value.AsString;
                }
                catch (Exception) {
                    textBoxCampo.Clear();
                    textBoxValor.Clear();
                }

            }

        }
    }
}

// Função readfully https://stackoverflow.com/questions/221925/creating-a-byte-array-from-a-stream