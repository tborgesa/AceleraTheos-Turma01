namespace PetShop.Swagger
{
    partial class FormCliente
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
            this.tabControlCliente = new System.Windows.Forms.TabControl();
            this.tabPageBuscarTodos = new System.Windows.Forms.TabPage();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.buttonBuscarTodos = new System.Windows.Forms.Button();
            this.tabPageBuscarById = new System.Windows.Forms.TabPage();
            this.textBoxSaidaBuscarPorId = new System.Windows.Forms.TextBox();
            this.buttonExecutarId = new System.Windows.Forms.Button();
            this.textBoxExemploId = new System.Windows.Forms.TextBox();
            this.textBoxEntradaBuscarPorId = new System.Windows.Forms.TextBox();
            this.tabPageInserir = new System.Windows.Forms.TabPage();
            this.textBoxSaidaInserir = new System.Windows.Forms.TextBox();
            this.buttonExecurarInserir = new System.Windows.Forms.Button();
            this.textBoxExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabPageAtualizar = new System.Windows.Forms.TabPage();
            this.textBoxSaidaAtualizar = new System.Windows.Forms.TextBox();
            this.buttonAtualizar = new System.Windows.Forms.Button();
            this.textBoxExemploAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxEntradaAtualizar = new System.Windows.Forms.TextBox();
            this.tabPageCliente = new System.Windows.Forms.TabPage();
            this.textBoxSaidaExcluir = new System.Windows.Forms.TextBox();
            this.buttonExecutarExcluir = new System.Windows.Forms.Button();
            this.textBoxExemploExcluir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaExcluir = new System.Windows.Forms.TextBox();
            this.tabControlCliente.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageBuscarById.SuspendLayout();
            this.tabPageInserir.SuspendLayout();
            this.tabPageAtualizar.SuspendLayout();
            this.tabPageCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlCliente.Controls.Add(this.tabPageBuscarById);
            this.tabControlCliente.Controls.Add(this.tabPageInserir);
            this.tabControlCliente.Controls.Add(this.tabPageAtualizar);
            this.tabControlCliente.Controls.Add(this.tabPageCliente);
            this.tabControlCliente.Location = new System.Drawing.Point(3, 2);
            this.tabControlCliente.Name = "tabControlCliente";
            this.tabControlCliente.SelectedIndex = 0;
            this.tabControlCliente.Size = new System.Drawing.Size(796, 535);
            this.tabControlCliente.TabIndex = 0;
            // 
            // tabPageBuscarTodos
            // 
            this.tabPageBuscarTodos.Controls.Add(this.textBoxBuscarTodos);
            this.tabPageBuscarTodos.Controls.Add(this.buttonBuscarTodos);
            this.tabPageBuscarTodos.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarTodos.Name = "tabPageBuscarTodos";
            this.tabPageBuscarTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarTodos.Size = new System.Drawing.Size(788, 509);
            this.tabPageBuscarTodos.TabIndex = 0;
            this.tabPageBuscarTodos.Text = "Buscar Todos";
            this.tabPageBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarTodos
            // 
            this.textBoxBuscarTodos.Location = new System.Drawing.Point(7, 50);
            this.textBoxBuscarTodos.Multiline = true;
            this.textBoxBuscarTodos.Name = "textBoxBuscarTodos";
            this.textBoxBuscarTodos.Size = new System.Drawing.Size(775, 449);
            this.textBoxBuscarTodos.TabIndex = 1;
            // 
            // buttonBuscarTodos
            // 
            this.buttonBuscarTodos.Location = new System.Drawing.Point(7, 7);
            this.buttonBuscarTodos.Name = "buttonBuscarTodos";
            this.buttonBuscarTodos.Size = new System.Drawing.Size(151, 36);
            this.buttonBuscarTodos.TabIndex = 0;
            this.buttonBuscarTodos.Text = "EXECUTAR";
            this.buttonBuscarTodos.UseVisualStyleBackColor = true;
            this.buttonBuscarTodos.Click += new System.EventHandler(this.buttonBuscarTodos_Click);
            // 
            // tabPageBuscarById
            // 
            this.tabPageBuscarById.Controls.Add(this.textBoxSaidaBuscarPorId);
            this.tabPageBuscarById.Controls.Add(this.buttonExecutarId);
            this.tabPageBuscarById.Controls.Add(this.textBoxExemploId);
            this.tabPageBuscarById.Controls.Add(this.textBoxEntradaBuscarPorId);
            this.tabPageBuscarById.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarById.Name = "tabPageBuscarById";
            this.tabPageBuscarById.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarById.Size = new System.Drawing.Size(788, 509);
            this.tabPageBuscarById.TabIndex = 1;
            this.tabPageBuscarById.Text = "Buscar por Id";
            this.tabPageBuscarById.UseVisualStyleBackColor = true;
            // 
            // textBoxSaidaBuscarPorId
            // 
            this.textBoxSaidaBuscarPorId.Location = new System.Drawing.Point(4, 59);
            this.textBoxSaidaBuscarPorId.Multiline = true;
            this.textBoxSaidaBuscarPorId.Name = "textBoxSaidaBuscarPorId";
            this.textBoxSaidaBuscarPorId.Size = new System.Drawing.Size(778, 444);
            this.textBoxSaidaBuscarPorId.TabIndex = 3;
            // 
            // buttonExecutarId
            // 
            this.buttonExecutarId.Location = new System.Drawing.Point(330, 7);
            this.buttonExecutarId.Name = "buttonExecutarId";
            this.buttonExecutarId.Size = new System.Drawing.Size(127, 47);
            this.buttonExecutarId.TabIndex = 2;
            this.buttonExecutarId.Text = "EXECUTAR";
            this.buttonExecutarId.UseVisualStyleBackColor = true;
            this.buttonExecutarId.Click += new System.EventHandler(this.buttonExecutarId_Click);
            // 
            // textBoxExemploId
            // 
            this.textBoxExemploId.Location = new System.Drawing.Point(463, 6);
            this.textBoxExemploId.Multiline = true;
            this.textBoxExemploId.Name = "textBoxExemploId";
            this.textBoxExemploId.Size = new System.Drawing.Size(319, 48);
            this.textBoxExemploId.TabIndex = 1;
            // 
            // textBoxEntradaBuscarPorId
            // 
            this.textBoxEntradaBuscarPorId.Location = new System.Drawing.Point(4, 7);
            this.textBoxEntradaBuscarPorId.Multiline = true;
            this.textBoxEntradaBuscarPorId.Name = "textBoxEntradaBuscarPorId";
            this.textBoxEntradaBuscarPorId.Size = new System.Drawing.Size(319, 48);
            this.textBoxEntradaBuscarPorId.TabIndex = 0;
            // 
            // tabPageInserir
            // 
            this.tabPageInserir.Controls.Add(this.textBoxSaidaInserir);
            this.tabPageInserir.Controls.Add(this.buttonExecurarInserir);
            this.tabPageInserir.Controls.Add(this.textBoxExemploInserir);
            this.tabPageInserir.Controls.Add(this.textBoxEntradaInserir);
            this.tabPageInserir.Location = new System.Drawing.Point(4, 22);
            this.tabPageInserir.Name = "tabPageInserir";
            this.tabPageInserir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInserir.Size = new System.Drawing.Size(788, 509);
            this.tabPageInserir.TabIndex = 2;
            this.tabPageInserir.Text = "Inserir";
            this.tabPageInserir.UseVisualStyleBackColor = true;
            this.tabPageInserir.Click += new System.EventHandler(this.tabPageInserir_Click);
            // 
            // textBoxSaidaInserir
            // 
            this.textBoxSaidaInserir.Location = new System.Drawing.Point(4, 266);
            this.textBoxSaidaInserir.Multiline = true;
            this.textBoxSaidaInserir.Name = "textBoxSaidaInserir";
            this.textBoxSaidaInserir.Size = new System.Drawing.Size(778, 233);
            this.textBoxSaidaInserir.TabIndex = 3;
            // 
            // buttonExecurarInserir
            // 
            this.buttonExecurarInserir.Location = new System.Drawing.Point(335, 76);
            this.buttonExecurarInserir.Name = "buttonExecurarInserir";
            this.buttonExecurarInserir.Size = new System.Drawing.Size(115, 114);
            this.buttonExecurarInserir.TabIndex = 2;
            this.buttonExecurarInserir.Text = "EXECUTAR";
            this.buttonExecurarInserir.UseVisualStyleBackColor = true;
            this.buttonExecurarInserir.Click += new System.EventHandler(this.buttonExecutarInserir_Click);
            // 
            // textBoxExemploInserir
            // 
            this.textBoxExemploInserir.Location = new System.Drawing.Point(457, 6);
            this.textBoxExemploInserir.Multiline = true;
            this.textBoxExemploInserir.Name = "textBoxExemploInserir";
            this.textBoxExemploInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxExemploInserir.Size = new System.Drawing.Size(325, 252);
            this.textBoxExemploInserir.TabIndex = 1;
            this.textBoxExemploInserir.TextChanged += new System.EventHandler(this.textBoxExemploInserir_TextChanged);
            // 
            // textBoxEntradaInserir
            // 
            this.textBoxEntradaInserir.Location = new System.Drawing.Point(4, 7);
            this.textBoxEntradaInserir.Multiline = true;
            this.textBoxEntradaInserir.Name = "textBoxEntradaInserir";
            this.textBoxEntradaInserir.Size = new System.Drawing.Size(325, 252);
            this.textBoxEntradaInserir.TabIndex = 0;
            this.textBoxEntradaInserir.TextChanged += new System.EventHandler(this.textBoxEntradaInserir_TextChanged);
            // 
            // tabPageAtualizar
            // 
            this.tabPageAtualizar.Controls.Add(this.textBoxSaidaAtualizar);
            this.tabPageAtualizar.Controls.Add(this.buttonAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxExemploAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxEntradaAtualizar);
            this.tabPageAtualizar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAtualizar.Name = "tabPageAtualizar";
            this.tabPageAtualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAtualizar.Size = new System.Drawing.Size(788, 509);
            this.tabPageAtualizar.TabIndex = 3;
            this.tabPageAtualizar.Text = "Atualizar";
            this.tabPageAtualizar.UseVisualStyleBackColor = true;
            // 
            // textBoxSaidaAtualizar
            // 
            this.textBoxSaidaAtualizar.Location = new System.Drawing.Point(5, 268);
            this.textBoxSaidaAtualizar.Multiline = true;
            this.textBoxSaidaAtualizar.Name = "textBoxSaidaAtualizar";
            this.textBoxSaidaAtualizar.Size = new System.Drawing.Size(778, 233);
            this.textBoxSaidaAtualizar.TabIndex = 7;
            // 
            // buttonAtualizar
            // 
            this.buttonAtualizar.Location = new System.Drawing.Point(336, 78);
            this.buttonAtualizar.Name = "buttonAtualizar";
            this.buttonAtualizar.Size = new System.Drawing.Size(115, 114);
            this.buttonAtualizar.TabIndex = 6;
            this.buttonAtualizar.Text = "EXECUTAR";
            this.buttonAtualizar.UseVisualStyleBackColor = true;
            this.buttonAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxExemploAtualizar
            // 
            this.textBoxExemploAtualizar.Location = new System.Drawing.Point(458, 8);
            this.textBoxExemploAtualizar.Multiline = true;
            this.textBoxExemploAtualizar.Name = "textBoxExemploAtualizar";
            this.textBoxExemploAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxExemploAtualizar.Size = new System.Drawing.Size(325, 252);
            this.textBoxExemploAtualizar.TabIndex = 5;
            // 
            // textBoxEntradaAtualizar
            // 
            this.textBoxEntradaAtualizar.Location = new System.Drawing.Point(5, 9);
            this.textBoxEntradaAtualizar.Multiline = true;
            this.textBoxEntradaAtualizar.Name = "textBoxEntradaAtualizar";
            this.textBoxEntradaAtualizar.Size = new System.Drawing.Size(325, 252);
            this.textBoxEntradaAtualizar.TabIndex = 4;
            // 
            // tabPageCliente
            // 
            this.tabPageCliente.Controls.Add(this.textBoxSaidaExcluir);
            this.tabPageCliente.Controls.Add(this.buttonExecutarExcluir);
            this.tabPageCliente.Controls.Add(this.textBoxExemploExcluir);
            this.tabPageCliente.Controls.Add(this.textBoxEntradaExcluir);
            this.tabPageCliente.Location = new System.Drawing.Point(4, 22);
            this.tabPageCliente.Name = "tabPageCliente";
            this.tabPageCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCliente.Size = new System.Drawing.Size(788, 509);
            this.tabPageCliente.TabIndex = 4;
            this.tabPageCliente.Text = "Excluir";
            this.tabPageCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxSaidaExcluir
            // 
            this.textBoxSaidaExcluir.Location = new System.Drawing.Point(5, 59);
            this.textBoxSaidaExcluir.Multiline = true;
            this.textBoxSaidaExcluir.Name = "textBoxSaidaExcluir";
            this.textBoxSaidaExcluir.Size = new System.Drawing.Size(778, 444);
            this.textBoxSaidaExcluir.TabIndex = 7;
            // 
            // buttonExecutarExcluir
            // 
            this.buttonExecutarExcluir.Location = new System.Drawing.Point(331, 7);
            this.buttonExecutarExcluir.Name = "buttonExecutarExcluir";
            this.buttonExecutarExcluir.Size = new System.Drawing.Size(127, 47);
            this.buttonExecutarExcluir.TabIndex = 6;
            this.buttonExecutarExcluir.Text = "EXECUTAR";
            this.buttonExecutarExcluir.UseVisualStyleBackColor = true;
            this.buttonExecutarExcluir.Click += new System.EventHandler(this.buttonExecutarExcluir_Click);
            // 
            // textBoxExemploExcluir
            // 
            this.textBoxExemploExcluir.Location = new System.Drawing.Point(464, 6);
            this.textBoxExemploExcluir.Multiline = true;
            this.textBoxExemploExcluir.Name = "textBoxExemploExcluir";
            this.textBoxExemploExcluir.Size = new System.Drawing.Size(319, 48);
            this.textBoxExemploExcluir.TabIndex = 5;
            // 
            // textBoxEntradaExcluir
            // 
            this.textBoxEntradaExcluir.Location = new System.Drawing.Point(5, 7);
            this.textBoxEntradaExcluir.Multiline = true;
            this.textBoxEntradaExcluir.Name = "textBoxEntradaExcluir";
            this.textBoxEntradaExcluir.Size = new System.Drawing.Size(319, 48);
            this.textBoxEntradaExcluir.TabIndex = 4;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 535);
            this.Controls.Add(this.tabControlCliente);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.tabControlCliente.ResumeLayout(false);
            this.tabPageBuscarTodos.ResumeLayout(false);
            this.tabPageBuscarTodos.PerformLayout();
            this.tabPageBuscarById.ResumeLayout(false);
            this.tabPageBuscarById.PerformLayout();
            this.tabPageInserir.ResumeLayout(false);
            this.tabPageInserir.PerformLayout();
            this.tabPageAtualizar.ResumeLayout(false);
            this.tabPageAtualizar.PerformLayout();
            this.tabPageCliente.ResumeLayout(false);
            this.tabPageCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TabPage tabPageBuscarById;
        private System.Windows.Forms.TabPage tabPageInserir;
        private System.Windows.Forms.TabPage tabPageAtualizar;
        private System.Windows.Forms.Button buttonExecurarInserir;
        private System.Windows.Forms.TextBox textBoxExemploInserir;
        private System.Windows.Forms.TextBox textBoxEntradaInserir;
        private System.Windows.Forms.TextBox textBoxSaidaInserir;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.Button buttonBuscarTodos;
        private System.Windows.Forms.TextBox textBoxSaidaBuscarPorId;
        private System.Windows.Forms.Button buttonExecutarId;
        private System.Windows.Forms.TextBox textBoxExemploId;
        private System.Windows.Forms.TextBox textBoxEntradaBuscarPorId;
        private System.Windows.Forms.TextBox textBoxSaidaAtualizar;
        private System.Windows.Forms.Button buttonAtualizar;
        private System.Windows.Forms.TextBox textBoxExemploAtualizar;
        private System.Windows.Forms.TextBox textBoxEntradaAtualizar;
        private System.Windows.Forms.TabPage tabPageCliente;
        private System.Windows.Forms.TextBox textBoxSaidaExcluir;
        private System.Windows.Forms.Button buttonExecutarExcluir;
        private System.Windows.Forms.TextBox textBoxExemploExcluir;
        private System.Windows.Forms.TextBox textBoxEntradaExcluir;
    }
}