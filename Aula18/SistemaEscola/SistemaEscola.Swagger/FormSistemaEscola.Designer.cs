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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonContratado
            // 
            this.buttonContratado.Location = new System.Drawing.Point(60, 57);
            this.buttonContratado.Name = "buttonContratado";
            this.buttonContratado.Size = new System.Drawing.Size(210, 123);
            this.buttonContratado.TabIndex = 0;
            this.buttonContratado.Text = "Contratado";
            this.buttonContratado.UseVisualStyleBackColor = true;
            this.buttonContratado.Click += new System.EventHandler(this.buttonContratado_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 123);
            this.button1.TabIndex = 1;
            this.button1.Text = "Horista (DEV)";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormSistemaEscola
            // 
            this.ClientSize = new System.Drawing.Size(656, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonContratado);
            this.Name = "FormSistemaEscola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFornecedor;
        private System.Windows.Forms.Button buttonContratado;
        private System.Windows.Forms.Button button1;
    }
}

