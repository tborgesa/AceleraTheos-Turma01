namespace UaiQueijos.Swagger
{
    partial class FormFornecedor
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
            this.tabControlFornecedor = new System.Windows.Forms.TabControl();
            this.tabPageBuscarTodos = new System.Windows.Forms.TabPage();
            this.tabPageBuscarById = new System.Windows.Forms.TabPage();
            this.tabPageInserir = new System.Windows.Forms.TabPage();
            this.buttonExecutarInserir = new System.Windows.Forms.Button();
            this.textBoxSaidaInserir = new System.Windows.Forms.TextBox();
            this.textBoxExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabControlFornecedor.SuspendLayout();
            this.tabPageInserir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFornecedor
            // 
            this.tabControlFornecedor.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlFornecedor.Controls.Add(this.tabPageBuscarById);
            this.tabControlFornecedor.Controls.Add(this.tabPageInserir);
            this.tabControlFornecedor.Location = new System.Drawing.Point(12, 12);
            this.tabControlFornecedor.Name = "tabControlFornecedor";
            this.tabControlFornecedor.SelectedIndex = 0;
            this.tabControlFornecedor.Size = new System.Drawing.Size(983, 809);
            this.tabControlFornecedor.TabIndex = 0;
            // 
            // tabPageBuscarTodos
            // 
            this.tabPageBuscarTodos.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarTodos.Name = "tabPageBuscarTodos";
            this.tabPageBuscarTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarTodos.Size = new System.Drawing.Size(975, 783);
            this.tabPageBuscarTodos.TabIndex = 0;
            this.tabPageBuscarTodos.Text = "Buscar Todos";
            this.tabPageBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // tabPageBuscarById
            // 
            this.tabPageBuscarById.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarById.Name = "tabPageBuscarById";
            this.tabPageBuscarById.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarById.Size = new System.Drawing.Size(975, 783);
            this.tabPageBuscarById.TabIndex = 1;
            this.tabPageBuscarById.Text = "Buscar Por Id";
            this.tabPageBuscarById.UseVisualStyleBackColor = true;
            // 
            // tabPageInserir
            // 
            this.tabPageInserir.Controls.Add(this.buttonExecutarInserir);
            this.tabPageInserir.Controls.Add(this.textBoxSaidaInserir);
            this.tabPageInserir.Controls.Add(this.textBoxExemploInserir);
            this.tabPageInserir.Controls.Add(this.textBoxEntradaInserir);
            this.tabPageInserir.Location = new System.Drawing.Point(4, 22);
            this.tabPageInserir.Name = "tabPageInserir";
            this.tabPageInserir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInserir.Size = new System.Drawing.Size(975, 783);
            this.tabPageInserir.TabIndex = 2;
            this.tabPageInserir.Text = "Inserir";
            this.tabPageInserir.UseVisualStyleBackColor = true;
            // 
            // buttonExecutarInserir
            // 
            this.buttonExecutarInserir.Location = new System.Drawing.Point(432, 103);
            this.buttonExecutarInserir.Name = "buttonExecutarInserir";
            this.buttonExecutarInserir.Size = new System.Drawing.Size(133, 94);
            this.buttonExecutarInserir.TabIndex = 3;
            this.buttonExecutarInserir.Text = "EXECUTAR";
            this.buttonExecutarInserir.UseVisualStyleBackColor = true;
            this.buttonExecutarInserir.Click += new System.EventHandler(this.buttonExecutarInserir_Click);
            // 
            // textBoxSaidaInserir
            // 
            this.textBoxSaidaInserir.Location = new System.Drawing.Point(6, 337);
            this.textBoxSaidaInserir.Multiline = true;
            this.textBoxSaidaInserir.Name = "textBoxSaidaInserir";
            this.textBoxSaidaInserir.ReadOnly = true;
            this.textBoxSaidaInserir.Size = new System.Drawing.Size(963, 440);
            this.textBoxSaidaInserir.TabIndex = 2;
            // 
            // textBoxExemploInserir
            // 
            this.textBoxExemploInserir.Location = new System.Drawing.Point(591, 6);
            this.textBoxExemploInserir.Multiline = true;
            this.textBoxExemploInserir.Name = "textBoxExemploInserir";
            this.textBoxExemploInserir.ReadOnly = true;
            this.textBoxExemploInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxExemploInserir.TabIndex = 1;
            // 
            // textBoxEntradaInserir
            // 
            this.textBoxEntradaInserir.Location = new System.Drawing.Point(6, 6);
            this.textBoxEntradaInserir.Multiline = true;
            this.textBoxEntradaInserir.Name = "textBoxEntradaInserir";
            this.textBoxEntradaInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxEntradaInserir.TabIndex = 0;
            // 
            // FormFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 846);
            this.Controls.Add(this.tabControlFornecedor);
            this.Name = "FormFornecedor";
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.FormFornecedor_Load);
            this.tabControlFornecedor.ResumeLayout(false);
            this.tabPageInserir.ResumeLayout(false);
            this.tabPageInserir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlFornecedor;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TabPage tabPageBuscarById;
        private System.Windows.Forms.TabPage tabPageInserir;
        private System.Windows.Forms.Button buttonExecutarInserir;
        private System.Windows.Forms.TextBox textBoxSaidaInserir;
        private System.Windows.Forms.TextBox textBoxExemploInserir;
        private System.Windows.Forms.TextBox textBoxEntradaInserir;
    }
}