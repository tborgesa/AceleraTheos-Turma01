namespace Theos.SistemaEscolar.Swagger
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
            this.btnProfessorContratado = new System.Windows.Forms.Button();
            this.btnProfessorHorista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProfessorContratado
            // 
            this.btnProfessorContratado.Location = new System.Drawing.Point(12, 12);
            this.btnProfessorContratado.Name = "btnProfessorContratado";
            this.btnProfessorContratado.Size = new System.Drawing.Size(106, 44);
            this.btnProfessorContratado.TabIndex = 0;
            this.btnProfessorContratado.Text = "Professor contratado";
            this.btnProfessorContratado.UseVisualStyleBackColor = true;
            this.btnProfessorContratado.Click += new System.EventHandler(this.btnProfessorContratado_Click);
            // 
            // btnProfessorHorista
            // 
            this.btnProfessorHorista.Location = new System.Drawing.Point(160, 12);
            this.btnProfessorHorista.Name = "btnProfessorHorista";
            this.btnProfessorHorista.Size = new System.Drawing.Size(106, 44);
            this.btnProfessorHorista.TabIndex = 1;
            this.btnProfessorHorista.Text = "Professor horista";
            this.btnProfessorHorista.UseVisualStyleBackColor = true;
            this.btnProfessorHorista.Click += new System.EventHandler(this.btnProfessorHorista_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 75);
            this.Controls.Add(this.btnProfessorHorista);
            this.Controls.Add(this.btnProfessorContratado);
            this.Name = "FormPrincipal";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProfessorContratado;
        private System.Windows.Forms.Button btnProfessorHorista;
    }
}

