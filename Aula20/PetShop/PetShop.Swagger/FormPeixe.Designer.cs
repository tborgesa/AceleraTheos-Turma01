namespace PetShop.Swagger
{
    partial class FormPeixe
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
            this.tabControlPeixe = new System.Windows.Forms.TabControl();
            this.tabPageBuscarTodos = new System.Windows.Forms.TabPage();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.buttonBuscarTodos = new System.Windows.Forms.Button();
            this.tabPageBuscarById = new System.Windows.Forms.TabPage();
            this.buttonExecutarId = new System.Windows.Forms.Button();
            this.textBoxSaidaBuscarId = new System.Windows.Forms.TextBox();
            this.textBoxExemploId = new System.Windows.Forms.TextBox();
            this.textBoxEntradaBuscarId = new System.Windows.Forms.TextBox();
            this.tabPeixeInserir = new System.Windows.Forms.TabPage();
            this.buttonPeixeExecutarInserir = new System.Windows.Forms.Button();
            this.textBoxPeixeSaidaInserir = new System.Windows.Forms.TextBox();
            this.textBoxPeixeExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxPeixeEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabPeixeAtualizar = new System.Windows.Forms.TabPage();
            this.buttonPeixeAtualizar = new System.Windows.Forms.Button();
            this.textBoxPeixeSaidaAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxPeixeExemploAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxPeixeEntradaAtualizar = new System.Windows.Forms.TextBox();
            this.tabPageExcluir = new System.Windows.Forms.TabPage();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxExemploExcluir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaExcluir = new System.Windows.Forms.TextBox();
            this.textBoxSaidaExcluir = new System.Windows.Forms.TextBox();
            this.tabControlPeixe.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageBuscarById.SuspendLayout();
            this.tabPeixeInserir.SuspendLayout();
            this.tabPeixeAtualizar.SuspendLayout();
            this.tabPageExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPeixe
            // 
            this.tabControlPeixe.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlPeixe.Controls.Add(this.tabPageBuscarById);
            this.tabControlPeixe.Controls.Add(this.tabPeixeInserir);
            this.tabControlPeixe.Controls.Add(this.tabPeixeAtualizar);
            this.tabControlPeixe.Controls.Add(this.tabPageExcluir);
            this.tabControlPeixe.Location = new System.Drawing.Point(12, 12);
            this.tabControlPeixe.Name = "tabControlPeixe";
            this.tabControlPeixe.SelectedIndex = 0;
            this.tabControlPeixe.Size = new System.Drawing.Size(904, 623);
            this.tabControlPeixe.TabIndex = 0;
            // 
            // tabPageBuscarTodos
            // 
            this.tabPageBuscarTodos.Controls.Add(this.textBoxBuscarTodos);
            this.tabPageBuscarTodos.Controls.Add(this.buttonBuscarTodos);
            this.tabPageBuscarTodos.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarTodos.Name = "tabPageBuscarTodos";
            this.tabPageBuscarTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarTodos.Size = new System.Drawing.Size(896, 597);
            this.tabPageBuscarTodos.TabIndex = 0;
            this.tabPageBuscarTodos.Text = "Buscar Todos";
            this.tabPageBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarTodos
            // 
            this.textBoxBuscarTodos.Location = new System.Drawing.Point(7, 40);
            this.textBoxBuscarTodos.Multiline = true;
            this.textBoxBuscarTodos.Name = "textBoxBuscarTodos";
            this.textBoxBuscarTodos.ReadOnly = true;
            this.textBoxBuscarTodos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxBuscarTodos.Size = new System.Drawing.Size(883, 551);
            this.textBoxBuscarTodos.TabIndex = 11;
            // 
            // buttonBuscarTodos
            // 
            this.buttonBuscarTodos.Location = new System.Drawing.Point(7, 7);
            this.buttonBuscarTodos.Name = "buttonBuscarTodos";
            this.buttonBuscarTodos.Size = new System.Drawing.Size(104, 27);
            this.buttonBuscarTodos.TabIndex = 0;
            this.buttonBuscarTodos.Text = "Executar";
            this.buttonBuscarTodos.UseVisualStyleBackColor = true;
            this.buttonBuscarTodos.Click += new System.EventHandler(this.buttonBuscarTodos_Click);
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
            this.tabPageBuscarById.Size = new System.Drawing.Size(896, 597);
            this.tabPageBuscarById.TabIndex = 1;
            this.tabPageBuscarById.Text = "Buscar Por Id";
            this.tabPageBuscarById.UseVisualStyleBackColor = true;
            // 
            // buttonExecutarId
            // 
            this.buttonExecutarId.Location = new System.Drawing.Point(405, 6);
            this.buttonExecutarId.Name = "buttonExecutarId";
            this.buttonExecutarId.Size = new System.Drawing.Size(81, 31);
            this.buttonExecutarId.TabIndex = 11;
            this.buttonExecutarId.Text = "EXECUTAR";
            this.buttonExecutarId.UseVisualStyleBackColor = true;
            this.buttonExecutarId.Click += new System.EventHandler(this.buttonExecutarId_Click);
            // 
            // textBoxSaidaBuscarId
            // 
            this.textBoxSaidaBuscarId.Location = new System.Drawing.Point(6, 43);
            this.textBoxSaidaBuscarId.Multiline = true;
            this.textBoxSaidaBuscarId.Name = "textBoxSaidaBuscarId";
            this.textBoxSaidaBuscarId.ReadOnly = true;
            this.textBoxSaidaBuscarId.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaidaBuscarId.Size = new System.Drawing.Size(884, 548);
            this.textBoxSaidaBuscarId.TabIndex = 10;
            // 
            // textBoxExemploId
            // 
            this.textBoxExemploId.Location = new System.Drawing.Point(564, 6);
            this.textBoxExemploId.Multiline = true;
            this.textBoxExemploId.Name = "textBoxExemploId";
            this.textBoxExemploId.ReadOnly = true;
            this.textBoxExemploId.Size = new System.Drawing.Size(326, 31);
            this.textBoxExemploId.TabIndex = 9;
            // 
            // textBoxEntradaBuscarId
            // 
            this.textBoxEntradaBuscarId.Location = new System.Drawing.Point(6, 6);
            this.textBoxEntradaBuscarId.Multiline = true;
            this.textBoxEntradaBuscarId.Name = "textBoxEntradaBuscarId";
            this.textBoxEntradaBuscarId.Size = new System.Drawing.Size(326, 31);
            this.textBoxEntradaBuscarId.TabIndex = 8;
            this.textBoxEntradaBuscarId.TextChanged += new System.EventHandler(this.textBoxEntradaBuscarId_TextChanged);
            // 
            // tabPeixeInserir
            // 
            this.tabPeixeInserir.Controls.Add(this.buttonPeixeExecutarInserir);
            this.tabPeixeInserir.Controls.Add(this.textBoxPeixeSaidaInserir);
            this.tabPeixeInserir.Controls.Add(this.textBoxPeixeExemploInserir);
            this.tabPeixeInserir.Controls.Add(this.textBoxPeixeEntradaInserir);
            this.tabPeixeInserir.Location = new System.Drawing.Point(4, 22);
            this.tabPeixeInserir.Name = "tabPeixeInserir";
            this.tabPeixeInserir.Size = new System.Drawing.Size(896, 597);
            this.tabPeixeInserir.TabIndex = 2;
            this.tabPeixeInserir.Text = "Inserir";
            this.tabPeixeInserir.UseVisualStyleBackColor = true;
            // 
            // buttonPeixeExecutarInserir
            // 
            this.buttonPeixeExecutarInserir.Location = new System.Drawing.Point(404, 88);
            this.buttonPeixeExecutarInserir.Name = "buttonPeixeExecutarInserir";
            this.buttonPeixeExecutarInserir.Size = new System.Drawing.Size(92, 94);
            this.buttonPeixeExecutarInserir.TabIndex = 7;
            this.buttonPeixeExecutarInserir.Text = "EXECUTAR";
            this.buttonPeixeExecutarInserir.UseVisualStyleBackColor = true;
            this.buttonPeixeExecutarInserir.Click += new System.EventHandler(this.buttonExecutarInserir_Click);
            // 
            // textBoxPeixeSaidaInserir
            // 
            this.textBoxPeixeSaidaInserir.Location = new System.Drawing.Point(3, 334);
            this.textBoxPeixeSaidaInserir.Multiline = true;
            this.textBoxPeixeSaidaInserir.Name = "textBoxPeixeSaidaInserir";
            this.textBoxPeixeSaidaInserir.ReadOnly = true;
            this.textBoxPeixeSaidaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPeixeSaidaInserir.Size = new System.Drawing.Size(890, 247);
            this.textBoxPeixeSaidaInserir.TabIndex = 6;
            // 
            // textBoxPeixeExemploInserir
            // 
            this.textBoxPeixeExemploInserir.Location = new System.Drawing.Point(515, 3);
            this.textBoxPeixeExemploInserir.Multiline = true;
            this.textBoxPeixeExemploInserir.Name = "textBoxPeixeExemploInserir";
            this.textBoxPeixeExemploInserir.ReadOnly = true;
            this.textBoxPeixeExemploInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPeixeExemploInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxPeixeExemploInserir.TabIndex = 5;
            // 
            // textBoxPeixeEntradaInserir
            // 
            this.textBoxPeixeEntradaInserir.Location = new System.Drawing.Point(3, 3);
            this.textBoxPeixeEntradaInserir.Multiline = true;
            this.textBoxPeixeEntradaInserir.Name = "textBoxPeixeEntradaInserir";
            this.textBoxPeixeEntradaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPeixeEntradaInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxPeixeEntradaInserir.TabIndex = 4;
            this.textBoxPeixeEntradaInserir.TextChanged += new System.EventHandler(this.textBoxPeixeEntradaInserir_TextChanged);
            // 
            // tabPeixeAtualizar
            // 
            this.tabPeixeAtualizar.Controls.Add(this.buttonPeixeAtualizar);
            this.tabPeixeAtualizar.Controls.Add(this.textBoxPeixeSaidaAtualizar);
            this.tabPeixeAtualizar.Controls.Add(this.textBoxPeixeExemploAtualizar);
            this.tabPeixeAtualizar.Controls.Add(this.textBoxPeixeEntradaAtualizar);
            this.tabPeixeAtualizar.Location = new System.Drawing.Point(4, 22);
            this.tabPeixeAtualizar.Name = "tabPeixeAtualizar";
            this.tabPeixeAtualizar.Size = new System.Drawing.Size(896, 597);
            this.tabPeixeAtualizar.TabIndex = 3;
            this.tabPeixeAtualizar.Text = "Atualizar";
            this.tabPeixeAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonPeixeAtualizar
            // 
            this.buttonPeixeAtualizar.Location = new System.Drawing.Point(404, 94);
            this.buttonPeixeAtualizar.Name = "buttonPeixeAtualizar";
            this.buttonPeixeAtualizar.Size = new System.Drawing.Size(92, 94);
            this.buttonPeixeAtualizar.TabIndex = 11;
            this.buttonPeixeAtualizar.Text = "EXECUTAR";
            this.buttonPeixeAtualizar.UseVisualStyleBackColor = true;
            this.buttonPeixeAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxPeixeSaidaAtualizar
            // 
            this.textBoxPeixeSaidaAtualizar.Location = new System.Drawing.Point(3, 340);
            this.textBoxPeixeSaidaAtualizar.Multiline = true;
            this.textBoxPeixeSaidaAtualizar.Name = "textBoxPeixeSaidaAtualizar";
            this.textBoxPeixeSaidaAtualizar.ReadOnly = true;
            this.textBoxPeixeSaidaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPeixeSaidaAtualizar.Size = new System.Drawing.Size(890, 247);
            this.textBoxPeixeSaidaAtualizar.TabIndex = 10;
            // 
            // textBoxPeixeExemploAtualizar
            // 
            this.textBoxPeixeExemploAtualizar.Location = new System.Drawing.Point(515, 9);
            this.textBoxPeixeExemploAtualizar.Multiline = true;
            this.textBoxPeixeExemploAtualizar.Name = "textBoxPeixeExemploAtualizar";
            this.textBoxPeixeExemploAtualizar.ReadOnly = true;
            this.textBoxPeixeExemploAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPeixeExemploAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxPeixeExemploAtualizar.TabIndex = 9;
            // 
            // textBoxPeixeEntradaAtualizar
            // 
            this.textBoxPeixeEntradaAtualizar.Location = new System.Drawing.Point(3, 9);
            this.textBoxPeixeEntradaAtualizar.Multiline = true;
            this.textBoxPeixeEntradaAtualizar.Name = "textBoxPeixeEntradaAtualizar";
            this.textBoxPeixeEntradaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPeixeEntradaAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxPeixeEntradaAtualizar.TabIndex = 8;
            this.textBoxPeixeEntradaAtualizar.TextChanged += new System.EventHandler(this.textBoxPeixeEntradaAtualizar_TextChanged);
            // 
            // tabPageExcluir
            // 
            this.tabPageExcluir.Controls.Add(this.buttonExcluir);
            this.tabPageExcluir.Controls.Add(this.textBoxExemploExcluir);
            this.tabPageExcluir.Controls.Add(this.textBoxEntradaExcluir);
            this.tabPageExcluir.Controls.Add(this.textBoxSaidaExcluir);
            this.tabPageExcluir.Location = new System.Drawing.Point(4, 22);
            this.tabPageExcluir.Name = "tabPageExcluir";
            this.tabPageExcluir.Size = new System.Drawing.Size(896, 597);
            this.tabPageExcluir.TabIndex = 4;
            this.tabPageExcluir.Text = "Excluir";
            this.tabPageExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonExcluir
            // 
            this.buttonExcluir.Location = new System.Drawing.Point(405, 6);
            this.buttonExcluir.Name = "buttonExcluir";
            this.buttonExcluir.Size = new System.Drawing.Size(81, 31);
            this.buttonExcluir.TabIndex = 15;
            this.buttonExcluir.Text = "EXECUTAR";
            this.buttonExcluir.UseVisualStyleBackColor = true;
            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
            // 
            // textBoxExemploExcluir
            // 
            this.textBoxExemploExcluir.Location = new System.Drawing.Point(564, 6);
            this.textBoxExemploExcluir.Multiline = true;
            this.textBoxExemploExcluir.Name = "textBoxExemploExcluir";
            this.textBoxExemploExcluir.ReadOnly = true;
            this.textBoxExemploExcluir.Size = new System.Drawing.Size(326, 31);
            this.textBoxExemploExcluir.TabIndex = 13;
            // 
            // textBoxEntradaExcluir
            // 
            this.textBoxEntradaExcluir.Location = new System.Drawing.Point(6, 6);
            this.textBoxEntradaExcluir.Multiline = true;
            this.textBoxEntradaExcluir.Name = "textBoxEntradaExcluir";
            this.textBoxEntradaExcluir.Size = new System.Drawing.Size(326, 31);
            this.textBoxEntradaExcluir.TabIndex = 12;
            // 
            // textBoxSaidaExcluir
            // 
            this.textBoxSaidaExcluir.Location = new System.Drawing.Point(9, 43);
            this.textBoxSaidaExcluir.Multiline = true;
            this.textBoxSaidaExcluir.Name = "textBoxSaidaExcluir";
            this.textBoxSaidaExcluir.ReadOnly = true;
            this.textBoxSaidaExcluir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSaidaExcluir.Size = new System.Drawing.Size(884, 548);
            this.textBoxSaidaExcluir.TabIndex = 14;
            // 
            // FormPeixe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 647);
            this.Controls.Add(this.tabControlPeixe);
            this.Name = "FormPeixe";
            this.Text = "Peixe";
            this.Load += new System.EventHandler(this.FormPeixe_Load);
            this.tabControlPeixe.ResumeLayout(false);
            this.tabPageBuscarTodos.ResumeLayout(false);
            this.tabPageBuscarTodos.PerformLayout();
            this.tabPageBuscarById.ResumeLayout(false);
            this.tabPageBuscarById.PerformLayout();
            this.tabPeixeInserir.ResumeLayout(false);
            this.tabPeixeInserir.PerformLayout();
            this.tabPeixeAtualizar.ResumeLayout(false);
            this.tabPeixeAtualizar.PerformLayout();
            this.tabPageExcluir.ResumeLayout(false);
            this.tabPageExcluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPeixe;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.Button buttonBuscarTodos;
        private System.Windows.Forms.TabPage tabPageBuscarById;
        private System.Windows.Forms.TabPage tabPeixeInserir;
        private System.Windows.Forms.TabPage tabPeixeAtualizar;
        private System.Windows.Forms.TabPage tabPageExcluir;
        private System.Windows.Forms.Button buttonExecutarId;
        private System.Windows.Forms.TextBox textBoxSaidaBuscarId;
        private System.Windows.Forms.TextBox textBoxExemploId;
        private System.Windows.Forms.TextBox textBoxEntradaBuscarId;
        private System.Windows.Forms.Button buttonPeixeExecutarInserir;
        private System.Windows.Forms.TextBox textBoxPeixeSaidaInserir;
        private System.Windows.Forms.TextBox textBoxPeixeExemploInserir;
        private System.Windows.Forms.TextBox textBoxPeixeEntradaInserir;
        private System.Windows.Forms.Button buttonPeixeAtualizar;
        private System.Windows.Forms.TextBox textBoxPeixeSaidaAtualizar;
        private System.Windows.Forms.TextBox textBoxPeixeExemploAtualizar;
        private System.Windows.Forms.TextBox textBoxPeixeEntradaAtualizar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxSaidaExcluir;
        private System.Windows.Forms.TextBox textBoxExemploExcluir;
        private System.Windows.Forms.TextBox textBoxEntradaExcluir;
    }
}