namespace UaiQueijos.Swagger
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
            this.buttonFornecedor = new System.Windows.Forms.Button();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFornecedor
            // 
            this.buttonFornecedor.Location = new System.Drawing.Point(29, 25);
            this.buttonFornecedor.Name = "buttonFornecedor";
            this.buttonFornecedor.Size = new System.Drawing.Size(119, 69);
            this.buttonFornecedor.TabIndex = 0;
            this.buttonFornecedor.Text = "Fornecedor";
            this.buttonFornecedor.UseVisualStyleBackColor = true;
            this.buttonFornecedor.Click += new System.EventHandler(this.buttonFornecedor_Click);
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(234, 25);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(119, 69);
            this.buttonCliente.TabIndex = 1;
            this.buttonCliente.Text = "Cliente";
            this.buttonCliente.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 131);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.buttonFornecedor);
            this.Name = "FormPrincipal";
            this.Text = "Swagger - Uai Queijos";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFornecedor;
        private System.Windows.Forms.Button buttonCliente;
    }
}

