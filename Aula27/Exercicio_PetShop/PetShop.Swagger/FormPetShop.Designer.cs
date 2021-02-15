namespace PetShop.Swagger
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonAnimal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(12, 34);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(171, 80);
            this.buttonCliente.TabIndex = 0;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.ButtonCliente_Click);
            // 
            // buttonAnimal
            // 
            this.buttonAnimal.Location = new System.Drawing.Point(204, 34);
            this.buttonAnimal.Name = "buttonAnimal";
            this.buttonAnimal.Size = new System.Drawing.Size(171, 80);
            this.buttonAnimal.TabIndex = 1;
            this.buttonAnimal.Text = "Animal";
            this.buttonAnimal.UseVisualStyleBackColor = true;
            this.buttonAnimal.Click += new System.EventHandler(this.buttonAnimal_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 147);
            this.Controls.Add(this.buttonAnimal);
            this.Controls.Add(this.buttonCliente);
            this.Name = "FormPrincipal";
            this.Text = "Swagger - PetShop";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonAnimal;
    }
}