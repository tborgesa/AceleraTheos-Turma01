namespace PetShop.Swagger
{
    partial class FormGato
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
            this.tabControlGato = new System.Windows.Forms.TabControl();
            this.tabPageBuscarTodos = new System.Windows.Forms.TabPage();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.buttonBuscarTodos = new System.Windows.Forms.Button();
            this.tabPageBuscarById = new System.Windows.Forms.TabPage();
            this.buttonExecutarId = new System.Windows.Forms.Button();
            this.textBoxSaidaBuscarId = new System.Windows.Forms.TextBox();
            this.textBoxExemploId = new System.Windows.Forms.TextBox();
            this.textBoxEntradaBuscarId = new System.Windows.Forms.TextBox();
            this.tabGatoInserir = new System.Windows.Forms.TabPage();
            this.buttonGatoExecutarInserir = new System.Windows.Forms.Button();
            this.textBoxGatoSaidaInserir = new System.Windows.Forms.TextBox();
            this.textBoxGatoExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxGatoEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabGatoAtualizar = new System.Windows.Forms.TabPage();
            this.buttonGatoAtualizar = new System.Windows.Forms.Button();
            this.textBoxGatoSaidaAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxGatoExemploAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxGatoEntradaAtualizar = new System.Windows.Forms.TextBox();
            this.tabPageExcluir = new System.Windows.Forms.TabPage();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxExemploExcluir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaExcluir = new System.Windows.Forms.TextBox();
            this.textBoxSaidaExcluir = new System.Windows.Forms.TextBox();
            this.tabControlGato.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageBuscarById.SuspendLayout();
            this.tabGatoInserir.SuspendLayout();
            this.tabGatoAtualizar.SuspendLayout();
            this.tabPageExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlGato
            // 
            this.tabControlGato.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlGato.Controls.Add(this.tabPageBuscarById);
            this.tabControlGato.Controls.Add(this.tabGatoInserir);
            this.tabControlGato.Controls.Add(this.tabGatoAtualizar);
            this.tabControlGato.Controls.Add(this.tabPageExcluir);
            this.tabControlGato.Location = new System.Drawing.Point(12, 12);
            this.tabControlGato.Name = "tabControlGato";
            this.tabControlGato.SelectedIndex = 0;
            this.tabControlGato.Size = new System.Drawing.Size(904, 623);
            this.tabControlGato.TabIndex = 0;
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
            // tabGatoInserir
            // 
            this.tabGatoInserir.Controls.Add(this.buttonGatoExecutarInserir);
            this.tabGatoInserir.Controls.Add(this.textBoxGatoSaidaInserir);
            this.tabGatoInserir.Controls.Add(this.textBoxGatoExemploInserir);
            this.tabGatoInserir.Controls.Add(this.textBoxGatoEntradaInserir);
            this.tabGatoInserir.Location = new System.Drawing.Point(4, 22);
            this.tabGatoInserir.Name = "tabGatoInserir";
            this.tabGatoInserir.Size = new System.Drawing.Size(896, 597);
            this.tabGatoInserir.TabIndex = 2;
            this.tabGatoInserir.Text = "Inserir";
            this.tabGatoInserir.UseVisualStyleBackColor = true;
            // 
            // buttonGatoExecutarInserir
            // 
            this.buttonGatoExecutarInserir.Location = new System.Drawing.Point(404, 88);
            this.buttonGatoExecutarInserir.Name = "buttonGatoExecutarInserir";
            this.buttonGatoExecutarInserir.Size = new System.Drawing.Size(92, 94);
            this.buttonGatoExecutarInserir.TabIndex = 7;
            this.buttonGatoExecutarInserir.Text = "EXECUTAR";
            this.buttonGatoExecutarInserir.UseVisualStyleBackColor = true;
            this.buttonGatoExecutarInserir.Click += new System.EventHandler(this.buttonExecutarInserir_Click);
            // 
            // textBoxGatoSaidaInserir
            // 
            this.textBoxGatoSaidaInserir.Location = new System.Drawing.Point(3, 334);
            this.textBoxGatoSaidaInserir.Multiline = true;
            this.textBoxGatoSaidaInserir.Name = "textBoxGatoSaidaInserir";
            this.textBoxGatoSaidaInserir.ReadOnly = true;
            this.textBoxGatoSaidaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGatoSaidaInserir.Size = new System.Drawing.Size(890, 247);
            this.textBoxGatoSaidaInserir.TabIndex = 6;
            // 
            // textBoxGatoExemploInserir
            // 
            this.textBoxGatoExemploInserir.Location = new System.Drawing.Point(515, 3);
            this.textBoxGatoExemploInserir.Multiline = true;
            this.textBoxGatoExemploInserir.Name = "textBoxGatoExemploInserir";
            this.textBoxGatoExemploInserir.ReadOnly = true;
            this.textBoxGatoExemploInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGatoExemploInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxGatoExemploInserir.TabIndex = 5;
            // 
            // textBoxGatoEntradaInserir
            // 
            this.textBoxGatoEntradaInserir.Location = new System.Drawing.Point(3, 3);
            this.textBoxGatoEntradaInserir.Multiline = true;
            this.textBoxGatoEntradaInserir.Name = "textBoxGatoEntradaInserir";
            this.textBoxGatoEntradaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGatoEntradaInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxGatoEntradaInserir.TabIndex = 4;
            this.textBoxGatoEntradaInserir.TextChanged += new System.EventHandler(this.textBoxGatoEntradaInserir_TextChanged);
            // 
            // tabGatoAtualizar
            // 
            this.tabGatoAtualizar.Controls.Add(this.buttonGatoAtualizar);
            this.tabGatoAtualizar.Controls.Add(this.textBoxGatoSaidaAtualizar);
            this.tabGatoAtualizar.Controls.Add(this.textBoxGatoExemploAtualizar);
            this.tabGatoAtualizar.Controls.Add(this.textBoxGatoEntradaAtualizar);
            this.tabGatoAtualizar.Location = new System.Drawing.Point(4, 22);
            this.tabGatoAtualizar.Name = "tabGatoAtualizar";
            this.tabGatoAtualizar.Size = new System.Drawing.Size(896, 597);
            this.tabGatoAtualizar.TabIndex = 3;
            this.tabGatoAtualizar.Text = "Atualizar";
            this.tabGatoAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonGatoAtualizar
            // 
            this.buttonGatoAtualizar.Location = new System.Drawing.Point(404, 94);
            this.buttonGatoAtualizar.Name = "buttonGatoAtualizar";
            this.buttonGatoAtualizar.Size = new System.Drawing.Size(92, 94);
            this.buttonGatoAtualizar.TabIndex = 11;
            this.buttonGatoAtualizar.Text = "EXECUTAR";
            this.buttonGatoAtualizar.UseVisualStyleBackColor = true;
            this.buttonGatoAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxGatoSaidaAtualizar
            // 
            this.textBoxGatoSaidaAtualizar.Location = new System.Drawing.Point(3, 340);
            this.textBoxGatoSaidaAtualizar.Multiline = true;
            this.textBoxGatoSaidaAtualizar.Name = "textBoxGatoSaidaAtualizar";
            this.textBoxGatoSaidaAtualizar.ReadOnly = true;
            this.textBoxGatoSaidaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGatoSaidaAtualizar.Size = new System.Drawing.Size(890, 247);
            this.textBoxGatoSaidaAtualizar.TabIndex = 10;
            // 
            // textBoxGatoExemploAtualizar
            // 
            this.textBoxGatoExemploAtualizar.Location = new System.Drawing.Point(515, 9);
            this.textBoxGatoExemploAtualizar.Multiline = true;
            this.textBoxGatoExemploAtualizar.Name = "textBoxGatoExemploAtualizar";
            this.textBoxGatoExemploAtualizar.ReadOnly = true;
            this.textBoxGatoExemploAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGatoExemploAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxGatoExemploAtualizar.TabIndex = 9;
            // 
            // textBoxGatoEntradaAtualizar
            // 
            this.textBoxGatoEntradaAtualizar.Location = new System.Drawing.Point(3, 9);
            this.textBoxGatoEntradaAtualizar.Multiline = true;
            this.textBoxGatoEntradaAtualizar.Name = "textBoxGatoEntradaAtualizar";
            this.textBoxGatoEntradaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxGatoEntradaAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxGatoEntradaAtualizar.TabIndex = 8;
            this.textBoxGatoEntradaAtualizar.TextChanged += new System.EventHandler(this.textBoxGatoEntradaAtualizar_TextChanged);
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
            // FormGato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 647);
            this.Controls.Add(this.tabControlGato);
            this.Name = "FormGato";
            this.Text = "Gato";
            this.Load += new System.EventHandler(this.FormGato_Load);
            this.tabControlGato.ResumeLayout(false);
            this.tabPageBuscarTodos.ResumeLayout(false);
            this.tabPageBuscarTodos.PerformLayout();
            this.tabPageBuscarById.ResumeLayout(false);
            this.tabPageBuscarById.PerformLayout();
            this.tabGatoInserir.ResumeLayout(false);
            this.tabGatoInserir.PerformLayout();
            this.tabGatoAtualizar.ResumeLayout(false);
            this.tabGatoAtualizar.PerformLayout();
            this.tabPageExcluir.ResumeLayout(false);
            this.tabPageExcluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGato;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.Button buttonBuscarTodos;
        private System.Windows.Forms.TabPage tabPageBuscarById;
        private System.Windows.Forms.TabPage tabGatoInserir;
        private System.Windows.Forms.TabPage tabGatoAtualizar;
        private System.Windows.Forms.TabPage tabPageExcluir;
        private System.Windows.Forms.Button buttonExecutarId;
        private System.Windows.Forms.TextBox textBoxSaidaBuscarId;
        private System.Windows.Forms.TextBox textBoxExemploId;
        private System.Windows.Forms.TextBox textBoxEntradaBuscarId;
        private System.Windows.Forms.Button buttonGatoExecutarInserir;
        private System.Windows.Forms.TextBox textBoxGatoSaidaInserir;
        private System.Windows.Forms.TextBox textBoxGatoExemploInserir;
        private System.Windows.Forms.TextBox textBoxGatoEntradaInserir;
        private System.Windows.Forms.Button buttonGatoAtualizar;
        private System.Windows.Forms.TextBox textBoxGatoSaidaAtualizar;
        private System.Windows.Forms.TextBox textBoxGatoExemploAtualizar;
        private System.Windows.Forms.TextBox textBoxGatoEntradaAtualizar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxSaidaExcluir;
        private System.Windows.Forms.TextBox textBoxExemploExcluir;
        private System.Windows.Forms.TextBox textBoxEntradaExcluir;
    }
}