namespace PetShop.Swagger
{
    partial class FormAnimal
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
            this.buttonCachorro = new System.Windows.Forms.Button();
            this.buttonGato = new System.Windows.Forms.Button();
            this.buttonPeixe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCachorro
            // 
            this.buttonCachorro.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCachorro.Location = new System.Drawing.Point(12, 129);
            this.buttonCachorro.Name = "buttonCachorro";
            this.buttonCachorro.Size = new System.Drawing.Size(210, 123);
            this.buttonCachorro.TabIndex = 1;
            this.buttonCachorro.Text = "Cachorro";
            this.buttonCachorro.UseVisualStyleBackColor = true;
            this.buttonCachorro.Click += new System.EventHandler(this.buttonCachorro_Click);
            // 
            // buttonGato
            // 
            this.buttonGato.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGato.Location = new System.Drawing.Point(307, 129);
            this.buttonGato.Name = "buttonGato";
            this.buttonGato.Size = new System.Drawing.Size(210, 123);
            this.buttonGato.TabIndex = 2;
            this.buttonGato.Text = "Gato";
            this.buttonGato.UseVisualStyleBackColor = true;
            this.buttonGato.Click += new System.EventHandler(this.buttonGato_Click);
            // 
            // buttonPeixe
            // 
            this.buttonPeixe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPeixe.Location = new System.Drawing.Point(578, 129);
            this.buttonPeixe.Name = "buttonPeixe";
            this.buttonPeixe.Size = new System.Drawing.Size(210, 123);
            this.buttonPeixe.TabIndex = 3;
            this.buttonPeixe.Text = "Peixe";
            this.buttonPeixe.UseVisualStyleBackColor = true;
            this.buttonPeixe.Click += new System.EventHandler(this.buttonPeixe_Click);
            // 
            // FormAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPeixe);
            this.Controls.Add(this.buttonGato);
            this.Controls.Add(this.buttonCachorro);
            this.Name = "FormAnimal";
            this.Text = "Pet Shop";
            this.Load += new System.EventHandler(this.FormAnimal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCachorro;
        private System.Windows.Forms.Button buttonGato;
        private System.Windows.Forms.Button buttonPeixe;
    }
}

