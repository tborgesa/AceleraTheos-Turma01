namespace SistemaEscola.Swagger
{
    partial class FormSistemaEscola
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonContratado = new System.Windows.Forms.Button();
            this.buttonHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContratado
            // 
            this.buttonContratado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContratado.Location = new System.Drawing.Point(60, 57);
            this.buttonContratado.Name = "buttonContratado";
            this.buttonContratado.Size = new System.Drawing.Size(210, 123);
            this.buttonContratado.TabIndex = 0;
            this.buttonContratado.Text = "Contratado";
            this.buttonContratado.UseVisualStyleBackColor = true;
            this.buttonContratado.Click += new System.EventHandler(this.buttonContratado_Click);
            // 
            // buttonHorista
            // 
            this.buttonHorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHorista.Location = new System.Drawing.Point(358, 57);
            this.buttonHorista.Name = "buttonHorista";
            this.buttonHorista.Size = new System.Drawing.Size(210, 123);
            this.buttonHorista.TabIndex = 1;
            this.buttonHorista.Text = "Horista";
            this.buttonHorista.UseVisualStyleBackColor = true;
            this.buttonHorista.Click += new System.EventHandler(this.buttonHorista_Click);
            // 
            // FormSistemaEscola
            // 
            this.ClientSize = new System.Drawing.Size(656, 261);
            this.Controls.Add(this.buttonHorista);
            this.Controls.Add(this.buttonContratado);
            this.Name = "FormSistemaEscola";
            this.Load += new System.EventHandler(this.FormSistemaEscola_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonContratado;
        private System.Windows.Forms.Button buttonHorista;
    }
}

