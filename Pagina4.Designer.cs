﻿namespace FormularioGrafica {
    partial class Pagina4 {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxServico = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Constantia", 12F);
            this.label13.Location = new System.Drawing.Point(150, 20);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 19);
            this.label13.TabIndex = 62;
            this.label13.Text = "Pagina 4";
            // 
            // comboBoxServico
            // 
            this.comboBoxServico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.comboBoxServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxServico.Font = new System.Drawing.Font("Constantia", 12F);
            this.comboBoxServico.FormattingEnabled = true;
            this.comboBoxServico.Items.AddRange(new object[] {
            "Item 1",
            "Item 2"});
            this.comboBoxServico.Location = new System.Drawing.Point(312, 160);
            this.comboBoxServico.MaxLength = 40;
            this.comboBoxServico.Name = "comboBoxServico";
            this.comboBoxServico.Size = new System.Drawing.Size(121, 27);
            this.comboBoxServico.TabIndex = 63;
            // 
            // Pagina4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.comboBoxServico);
            this.Controls.Add(this.label13);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.Name = "Pagina4";
            this.Size = new System.Drawing.Size(744, 346);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBoxServico;
    }
}
