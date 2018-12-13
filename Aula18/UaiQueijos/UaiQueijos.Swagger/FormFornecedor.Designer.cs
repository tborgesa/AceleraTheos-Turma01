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
            this.buttonBuscarTodos = new System.Windows.Forms.Button();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.tabPageBuscarById = new System.Windows.Forms.TabPage();
            this.buttonExecutarId = new System.Windows.Forms.Button();
            this.textBoxSaidaBuscarId = new System.Windows.Forms.TextBox();
            this.textBoxExemploId = new System.Windows.Forms.TextBox();
            this.textBoxEntradaBuscarId = new System.Windows.Forms.TextBox();
            this.tabPageInserir = new System.Windows.Forms.TabPage();
            this.buttonExecutarInserir = new System.Windows.Forms.Button();
            this.textBoxSaidaInserir = new System.Windows.Forms.TextBox();
            this.textBoxExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabPageAtualizar = new System.Windows.Forms.TabPage();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.textBoxSaidaAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxExemploAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxEntradaAtualizar = new System.Windows.Forms.TextBox();
            this.tabPageExcluir = new System.Windows.Forms.TabPage();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxSaidaExcluir = new System.Windows.Forms.TextBox();
            this.textBoxExemploExcluir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaExcluir = new System.Windows.Forms.TextBox();
            this.tabControlFornecedor.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageBuscarById.SuspendLayout();
            this.tabPageInserir.SuspendLayout();
            this.tabPageAtualizar.SuspendLayout();
            this.tabPageExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlFornecedor
            // 
            this.tabControlFornecedor.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlFornecedor.Controls.Add(this.tabPageBuscarById);
            this.tabControlFornecedor.Controls.Add(this.tabPageInserir);
            this.tabControlFornecedor.Controls.Add(this.tabPageAtualizar);
            this.tabControlFornecedor.Controls.Add(this.tabPageExcluir);
            this.tabControlFornecedor.Location = new System.Drawing.Point(12, 12);
            this.tabControlFornecedor.Name = "tabControlFornecedor";
            this.tabControlFornecedor.SelectedIndex = 0;
            this.tabControlFornecedor.Size = new System.Drawing.Size(983, 809);
            this.tabControlFornecedor.TabIndex = 0;
            // 
            // tabPageBuscarTodos
            // 
            this.tabPageBuscarTodos.Controls.Add(this.buttonBuscarTodos);
            this.tabPageBuscarTodos.Controls.Add(this.textBoxBuscarTodos);
            this.tabPageBuscarTodos.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarTodos.Name = "tabPageBuscarTodos";
            this.tabPageBuscarTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarTodos.Size = new System.Drawing.Size(975, 783);
            this.tabPageBuscarTodos.TabIndex = 0;
            this.tabPageBuscarTodos.Text = "Buscar Todos";
            this.tabPageBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // buttonBuscarTodos
            // 
            this.buttonBuscarTodos.Location = new System.Drawing.Point(6, 6);
            this.buttonBuscarTodos.Name = "buttonBuscarTodos";
            this.buttonBuscarTodos.Size = new System.Drawing.Size(133, 30);
            this.buttonBuscarTodos.TabIndex = 11;
            this.buttonBuscarTodos.Text = "EXECUTAR";
            this.buttonBuscarTodos.UseVisualStyleBackColor = true;
            this.buttonBuscarTodos.Click += new System.EventHandler(this.buttonBuscarTodos_Click);
            // 
            // textBoxBuscarTodos
            // 
            this.textBoxBuscarTodos.Location = new System.Drawing.Point(6, 42);
            this.textBoxBuscarTodos.Multiline = true;
            this.textBoxBuscarTodos.Name = "textBoxBuscarTodos";
            this.textBoxBuscarTodos.ReadOnly = true;
            this.textBoxBuscarTodos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBuscarTodos.Size = new System.Drawing.Size(963, 735);
            this.textBoxBuscarTodos.TabIndex = 10;
            // 
            // tabPageBuscarById
            // 
            this.tabPageBuscarById.Controls.Add(this.buttonExecutarId);
            this.tabPageBuscarById.Controls.Add(this.textBoxSaidaBuscarId);
            this.tabPageBuscarById.Controls.Add(this.textBoxExemploId);
            this.tabPageBuscarById.Controls.Add(this.textBoxEntradaBuscarId);
            this.tabPageBuscarById.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarById.Name = "tabPageBuscarById";
            this.tabPageBuscarById.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarById.Size = new System.Drawing.Size(975, 783);
            this.tabPageBuscarById.TabIndex = 1;
            this.tabPageBuscarById.Text = "Buscar Por Id";
            this.tabPageBuscarById.UseVisualStyleBackColor = true;
            // 
            // buttonExecutarId
            // 
            this.buttonExecutarId.Location = new System.Drawing.Point(420, 6);
            this.buttonExecutarId.Name = "buttonExecutarId";
            this.buttonExecutarId.Size = new System.Drawing.Size(133, 38);
            this.buttonExecutarId.TabIndex = 7;
            this.buttonExecutarId.Text = "EXECUTAR";
            this.buttonExecutarId.UseVisualStyleBackColor = true;
            this.buttonExecutarId.Click += new System.EventHandler(this.buttonExecutarId_Click);
            // 
            // textBoxSaidaBuscarId
            // 
            this.textBoxSaidaBuscarId.Location = new System.Drawing.Point(6, 50);
            this.textBoxSaidaBuscarId.Multiline = true;
            this.textBoxSaidaBuscarId.Name = "textBoxSaidaBuscarId";
            this.textBoxSaidaBuscarId.ReadOnly = true;
            this.textBoxSaidaBuscarId.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaidaBuscarId.Size = new System.Drawing.Size(963, 727);
            this.textBoxSaidaBuscarId.TabIndex = 6;
            // 
            // textBoxExemploId
            // 
            this.textBoxExemploId.Location = new System.Drawing.Point(591, 6);
            this.textBoxExemploId.Multiline = true;
            this.textBoxExemploId.Name = "textBoxExemploId";
            this.textBoxExemploId.ReadOnly = true;
            this.textBoxExemploId.Size = new System.Drawing.Size(378, 38);
            this.textBoxExemploId.TabIndex = 5;
            // 
            // textBoxEntradaBuscarId
            // 
            this.textBoxEntradaBuscarId.Location = new System.Drawing.Point(6, 6);
            this.textBoxEntradaBuscarId.Multiline = true;
            this.textBoxEntradaBuscarId.Name = "textBoxEntradaBuscarId";
            this.textBoxEntradaBuscarId.Size = new System.Drawing.Size(378, 38);
            this.textBoxEntradaBuscarId.TabIndex = 4;
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
            this.textBoxSaidaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaidaInserir.Size = new System.Drawing.Size(963, 440);
            this.textBoxSaidaInserir.TabIndex = 2;
            // 
            // textBoxExemploInserir
            // 
            this.textBoxExemploInserir.Location = new System.Drawing.Point(591, 6);
            this.textBoxExemploInserir.Multiline = true;
            this.textBoxExemploInserir.Name = "textBoxExemploInserir";
            this.textBoxExemploInserir.ReadOnly = true;
            this.textBoxExemploInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxExemploInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxExemploInserir.TabIndex = 1;
            // 
            // textBoxEntradaInserir
            // 
            this.textBoxEntradaInserir.Location = new System.Drawing.Point(6, 6);
            this.textBoxEntradaInserir.Multiline = true;
            this.textBoxEntradaInserir.Name = "textBoxEntradaInserir";
            this.textBoxEntradaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEntradaInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxEntradaInserir.TabIndex = 0;
            // 
            // tabPageAtualizar
            // 
            this.tabPageAtualizar.Controls.Add(this.buttonAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxSaidaAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxExemploAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxEntradaAtualizar);
            this.tabPageAtualizar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAtualizar.Name = "tabPageAtualizar";
            this.tabPageAtualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAtualizar.Size = new System.Drawing.Size(975, 783);
            this.tabPageAtualizar.TabIndex = 3;
            this.tabPageAtualizar.Text = "Atualizar";
            this.tabPageAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(432, 103);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(133, 94);
            this.buttonAtualizar.TabIndex = 7;
            this.buttonAtualizar.Text = "EXECUTAR";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxSaidaAtualizar
            // 
            this.textBoxSaidaAtualizar.Location = new System.Drawing.Point(6, 337);
            this.textBoxSaidaAtualizar.Multiline = true;
            this.textBoxSaidaAtualizar.Name = "textBoxSaidaAtualizar";
            this.textBoxSaidaAtualizar.ReadOnly = true;
            this.textBoxSaidaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaidaAtualizar.Size = new System.Drawing.Size(963, 440);
            this.textBoxSaidaAtualizar.TabIndex = 6;
            // 
            // textBoxExemploAtualizar
            // 
            this.textBoxExemploAtualizar.Location = new System.Drawing.Point(591, 6);
            this.textBoxExemploAtualizar.Multiline = true;
            this.textBoxExemploAtualizar.Name = "textBoxExemploAtualizar";
            this.textBoxExemploAtualizar.ReadOnly = true;
            this.textBoxExemploAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxExemploAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxExemploAtualizar.TabIndex = 5;
            // 
            // textBoxEntradaAtualizar
            // 
            this.textBoxEntradaAtualizar.Location = new System.Drawing.Point(6, 6);
            this.textBoxEntradaAtualizar.Multiline = true;
            this.textBoxEntradaAtualizar.Name = "textBoxEntradaAtualizar";
            this.textBoxEntradaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxEntradaAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxEntradaAtualizar.TabIndex = 4;
            // 
            // tabPageExcluir
            // 
            this.tabPageExcluir.Controls.Add(this.buttonExcluir);
            this.tabPageExcluir.Controls.Add(this.textBoxSaidaExcluir);
            this.tabPageExcluir.Controls.Add(this.textBoxExemploExcluir);
            this.tabPageExcluir.Controls.Add(this.textBoxEntradaExcluir);
            this.tabPageExcluir.Location = new System.Drawing.Point(4, 22);
            this.tabPageExcluir.Name = "tabPageExcluir";
            this.tabPageExcluir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExcluir.Size = new System.Drawing.Size(975, 783);
            this.tabPageExcluir.TabIndex = 4;
            this.tabPageExcluir.Text = "Excluir";
            this.tabPageExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(420, 6);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(133, 38);
            this.buttonExcluir.TabIndex = 11;
            this.buttonExcluir.Text = "EXECUTAR";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxSaidaExcluir
            // 
            this.textBoxSaidaExcluir.Location = new System.Drawing.Point(6, 50);
            this.textBoxSaidaExcluir.Multiline = true;
            this.textBoxSaidaExcluir.Name = "textBoxSaidaExcluir";
            this.textBoxSaidaExcluir.ReadOnly = true;
            this.textBoxSaidaExcluir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaidaExcluir.Size = new System.Drawing.Size(963, 727);
            this.textBoxSaidaExcluir.TabIndex = 10;
            // 
            // textBoxExemploExcluir
            // 
            this.textBoxExemploExcluir.Location = new System.Drawing.Point(591, 6);
            this.textBoxExemploExcluir.Multiline = true;
            this.textBoxExemploExcluir.Name = "textBoxExemploExcluir";
            this.textBoxExemploExcluir.ReadOnly = true;
            this.textBoxExemploExcluir.Size = new System.Drawing.Size(378, 38);
            this.textBoxExemploExcluir.TabIndex = 9;
            // 
            // textBoxEntradaExcluir
            // 
            this.textBoxEntradaExcluir.Location = new System.Drawing.Point(6, 6);
            this.textBoxEntradaExcluir.Multiline = true;
            this.textBoxEntradaExcluir.Name = "textBoxEntradaExcluir";
            this.textBoxEntradaExcluir.Size = new System.Drawing.Size(378, 38);
            this.textBoxEntradaExcluir.TabIndex = 8;
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
            this.tabPageBuscarTodos.ResumeLayout(false);
            this.tabPageBuscarTodos.PerformLayout();
            this.tabPageBuscarById.ResumeLayout(false);
            this.tabPageBuscarById.PerformLayout();
            this.tabPageInserir.ResumeLayout(false);
            this.tabPageInserir.PerformLayout();
            this.tabPageAtualizar.ResumeLayout(false);
            this.tabPageAtualizar.PerformLayout();
            this.tabPageExcluir.ResumeLayout(false);
            this.tabPageExcluir.PerformLayout();
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
        private System.Windows.Forms.Button buttonExecutarId;
        private System.Windows.Forms.TextBox textBoxSaidaBuscarId;
        private System.Windows.Forms.TextBox textBoxExemploId;
        private System.Windows.Forms.TextBox textBoxEntradaBuscarId;
        private System.Windows.Forms.Button buttonBuscarTodos;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.TabPage tabPageAtualizar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.TextBox textBoxSaidaAtualizar;
        private System.Windows.Forms.TextBox textBoxExemploAtualizar;
        private System.Windows.Forms.TextBox textBoxEntradaAtualizar;
        private System.Windows.Forms.TabPage tabPageExcluir;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxSaidaExcluir;
        private System.Windows.Forms.TextBox textBoxExemploExcluir;
        private System.Windows.Forms.TextBox textBoxEntradaExcluir;
    }
}