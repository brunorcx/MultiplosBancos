namespace FormularioGrafica.MongoDB {
    partial class Form1Mongo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Mongo));
            this.buttonRemover = new System.Windows.Forms.Button();
            this.buttonPesquisar = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.backgroundWorkerMongo = new System.ComponentModel.BackgroundWorker();
            this.labelStatus = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxBusca = new System.Windows.Forms.TextBox();
            this.buttonCartao = new System.Windows.Forms.Button();
            this.buttonPanfletos = new System.Windows.Forms.Button();
            this.buttonAdesivos = new System.Windows.Forms.Button();
            this.buttonBanners = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.buttonCadastrarI = new System.Windows.Forms.Button();
            this.cartoes1 = new FormularioGrafica.MongoDB.Cartoes();
            this.cadastrarImagens1 = new FormularioGrafica.MongoDB.CadastrarImagens();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemover
            // 
            this.buttonRemover.BackColor = System.Drawing.Color.Green;
            this.buttonRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemover.Location = new System.Drawing.Point(417, 488);
            this.buttonRemover.Name = "buttonRemover";
            this.buttonRemover.Size = new System.Drawing.Size(133, 34);
            this.buttonRemover.TabIndex = 146;
            this.buttonRemover.Text = "Remover";
            this.buttonRemover.UseVisualStyleBackColor = false;
            // 
            // buttonPesquisar
            // 
            this.buttonPesquisar.BackColor = System.Drawing.Color.Green;
            this.buttonPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPesquisar.Location = new System.Drawing.Point(574, 488);
            this.buttonPesquisar.Name = "buttonPesquisar";
            this.buttonPesquisar.Size = new System.Drawing.Size(133, 34);
            this.buttonPesquisar.TabIndex = 145;
            this.buttonPesquisar.Text = "Pesquisar";
            this.buttonPesquisar.UseVisualStyleBackColor = false;
            this.buttonPesquisar.Click += new System.EventHandler(this.buttonPesquisar_Click);
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.BackColor = System.Drawing.Color.Green;
            this.buttonCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrar.Location = new System.Drawing.Point(574, 541);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(133, 34);
            this.buttonCadastrar.TabIndex = 144;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = false;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.BackColor = System.Drawing.Color.Green;
            this.buttonAlterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.Location = new System.Drawing.Point(417, 541);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(133, 34);
            this.buttonAlterar.TabIndex = 143;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.UseVisualStyleBackColor = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(753, 462);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(338, 147);
            this.richTextBox1.TabIndex = 149;
            this.richTextBox1.Text = "";
            // 
            // backgroundWorkerMongo
            // 
            this.backgroundWorkerMongo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMongo_DoWork);
            this.backgroundWorkerMongo.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMongo_RunWorkerCompleted);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.labelStatus.Font = new System.Drawing.Font("Constantia", 12F);
            this.labelStatus.ForeColor = System.Drawing.Color.Crimson;
            this.labelStatus.Location = new System.Drawing.Point(142, 39);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(158, 19);
            this.labelStatus.TabIndex = 150;
            this.labelStatus.Text = "Status: Desconectado";
            // 
            // button1
            // 
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.button1.Size = new System.Drawing.Size(136, 692);
            this.button1.TabIndex = 151;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(171, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1006, 30);
            this.button2.TabIndex = 159;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // textBoxBusca
            // 
            this.textBoxBusca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxBusca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBusca.Location = new System.Drawing.Point(176, 6);
            this.textBoxBusca.MaxLength = 30;
            this.textBoxBusca.Name = "textBoxBusca";
            this.textBoxBusca.Size = new System.Drawing.Size(922, 24);
            this.textBoxBusca.TabIndex = 160;
            this.textBoxBusca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxBusca_KeyUp);
            // 
            // buttonCartao
            // 
            this.buttonCartao.BackColor = System.Drawing.Color.Green;
            this.buttonCartao.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCartao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCartao.Location = new System.Drawing.Point(12, 132);
            this.buttonCartao.Name = "buttonCartao";
            this.buttonCartao.Size = new System.Drawing.Size(115, 35);
            this.buttonCartao.TabIndex = 163;
            this.buttonCartao.Text = "Cartões";
            this.buttonCartao.UseVisualStyleBackColor = false;
            this.buttonCartao.Click += new System.EventHandler(this.buttonCartao_Click);
            // 
            // buttonPanfletos
            // 
            this.buttonPanfletos.BackColor = System.Drawing.Color.Green;
            this.buttonPanfletos.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonPanfletos.FlatAppearance.BorderSize = 0;
            this.buttonPanfletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPanfletos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonPanfletos.Location = new System.Drawing.Point(12, 173);
            this.buttonPanfletos.Name = "buttonPanfletos";
            this.buttonPanfletos.Size = new System.Drawing.Size(115, 35);
            this.buttonPanfletos.TabIndex = 164;
            this.buttonPanfletos.Text = "Panfletos";
            this.buttonPanfletos.UseVisualStyleBackColor = false;
            this.buttonPanfletos.Click += new System.EventHandler(this.buttonPanfletos_Click);
            // 
            // buttonAdesivos
            // 
            this.buttonAdesivos.BackColor = System.Drawing.Color.Green;
            this.buttonAdesivos.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonAdesivos.FlatAppearance.BorderSize = 0;
            this.buttonAdesivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdesivos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdesivos.Location = new System.Drawing.Point(12, 214);
            this.buttonAdesivos.Name = "buttonAdesivos";
            this.buttonAdesivos.Size = new System.Drawing.Size(115, 35);
            this.buttonAdesivos.TabIndex = 165;
            this.buttonAdesivos.Text = "Adesivos";
            this.buttonAdesivos.UseVisualStyleBackColor = false;
            this.buttonAdesivos.Click += new System.EventHandler(this.buttonAdesivos_Click);
            // 
            // buttonBanners
            // 
            this.buttonBanners.BackColor = System.Drawing.Color.Green;
            this.buttonBanners.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonBanners.FlatAppearance.BorderSize = 0;
            this.buttonBanners.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBanners.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonBanners.Location = new System.Drawing.Point(12, 255);
            this.buttonBanners.Name = "buttonBanners";
            this.buttonBanners.Size = new System.Drawing.Size(115, 35);
            this.buttonBanners.TabIndex = 166;
            this.buttonBanners.Text = "Banners";
            this.buttonBanners.UseVisualStyleBackColor = false;
            this.buttonBanners.Click += new System.EventHandler(this.buttonBanners_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(135, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 161;
            this.pictureBox4.TabStop = false;
            // 
            // buttonCadastrarI
            // 
            this.buttonCadastrarI.BackColor = System.Drawing.Color.Green;
            this.buttonCadastrarI.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.buttonCadastrarI.FlatAppearance.BorderSize = 0;
            this.buttonCadastrarI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCadastrarI.Location = new System.Drawing.Point(12, 296);
            this.buttonCadastrarI.Name = "buttonCadastrarI";
            this.buttonCadastrarI.Size = new System.Drawing.Size(115, 35);
            this.buttonCadastrarI.TabIndex = 168;
            this.buttonCadastrarI.Text = "Cadastrar";
            this.buttonCadastrarI.UseVisualStyleBackColor = false;
            this.buttonCadastrarI.Click += new System.EventHandler(this.buttonCadastrarI_Click);
            // 
            // cartoes1
            // 
            this.cartoes1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cartoes1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartoes1.Location = new System.Drawing.Point(0, 0);
            this.cartoes1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cartoes1.Name = "cartoes1";
            this.cartoes1.Size = new System.Drawing.Size(1200, 692);
            this.cartoes1.TabIndex = 167;
            // 
            // cadastrarImagens1
            // 
            this.cadastrarImagens1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.cadastrarImagens1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastrarImagens1.Location = new System.Drawing.Point(0, 0);
            this.cadastrarImagens1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cadastrarImagens1.Name = "cadastrarImagens1";
            this.cadastrarImagens1.Size = new System.Drawing.Size(1200, 692);
            this.cadastrarImagens1.TabIndex = 169;
            this.cadastrarImagens1.Visible = false;
            // 
            // Form1Mongo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.buttonCadastrarI);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.buttonBanners);
            this.Controls.Add(this.buttonAdesivos);
            this.Controls.Add(this.buttonPanfletos);
            this.Controls.Add(this.buttonCartao);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.textBoxBusca);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonRemover);
            this.Controls.Add(this.buttonPesquisar);
            this.Controls.Add(this.buttonCadastrar);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.cartoes1);
            this.Controls.Add(this.cadastrarImagens1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1Mongo";
            this.Text = "Form1Mongo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1Mongo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRemover;
        private System.Windows.Forms.Button buttonPesquisar;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMongo;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxBusca;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button buttonCartao;
        private System.Windows.Forms.Button buttonPanfletos;
        private System.Windows.Forms.Button buttonAdesivos;
        private System.Windows.Forms.Button buttonBanners;
        private Cartoes cartoes1;
        private System.Windows.Forms.Button buttonCadastrarI;
        private CadastrarImagens cadastrarImagens1;
    }
}