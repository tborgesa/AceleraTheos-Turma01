namespace SistemaEscola.Swagger
{
    partial class FormContratado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// 
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
            this.tabControlContratado = new System.Windows.Forms.TabControl();
            this.tabPageBuscarTodos = new System.Windows.Forms.TabPage();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.buttonBuscarTodos = new System.Windows.Forms.Button();
            this.tabPageBuscarById = new System.Windows.Forms.TabPage();
            this.buttonExecutarId = new System.Windows.Forms.Button();
            this.textBoxSaidaBuscarId = new System.Windows.Forms.TextBox();
            this.textBoxExemploId = new System.Windows.Forms.TextBox();
            this.textBoxEntradaBuscarId = new System.Windows.Forms.TextBox();
            this.tabContratadoInserir = new System.Windows.Forms.TabPage();
            this.buttonContratadoExecutarInserir = new System.Windows.Forms.Button();
            this.textBoxContratadoSaidaInserir = new System.Windows.Forms.TextBox();
            this.textBoxContratadoExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxContratadoEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabContratadoAtualizar = new System.Windows.Forms.TabPage();
            this.buttonContratadoAtualizar = new System.Windows.Forms.Button();
            this.textBoxContratadoSaidaAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxContratadoExemploAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxContratadoEntradaAtualizar = new System.Windows.Forms.TextBox();
            this.tabPageExcluir = new System.Windows.Forms.TabPage();
            this.buttonExcluir = new System.Windows.Forms.Button();
            this.textBoxExemploExcluir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaExcluir = new System.Windows.Forms.TextBox();
            this.textBoxSaidaExcluir = new System.Windows.Forms.TextBox();
            this.tabControlContratado.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageBuscarById.SuspendLayout();
            this.tabContratadoInserir.SuspendLayout();
            this.tabContratadoAtualizar.SuspendLayout();
            this.tabPageExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlContratado
            // 
            this.tabControlContratado.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlContratado.Controls.Add(this.tabPageBuscarById);
            this.tabControlContratado.Controls.Add(this.tabContratadoInserir);
            this.tabControlContratado.Controls.Add(this.tabContratadoAtualizar);
            this.tabControlContratado.Controls.Add(this.tabPageExcluir);
            this.tabControlContratado.Location = new System.Drawing.Point(12, 12);
            this.tabControlContratado.Name = "tabControlContratado";
            this.tabControlContratado.SelectedIndex = 0;
            this.tabControlContratado.Size = new System.Drawing.Size(904, 623);
            this.tabControlContratado.TabIndex = 0;
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
            // 
            // tabContratadoInserir
            // 
            this.tabContratadoInserir.Controls.Add(this.buttonContratadoExecutarInserir);
            this.tabContratadoInserir.Controls.Add(this.textBoxContratadoSaidaInserir);
            this.tabContratadoInserir.Controls.Add(this.textBoxContratadoExemploInserir);
            this.tabContratadoInserir.Controls.Add(this.textBoxContratadoEntradaInserir);
            this.tabContratadoInserir.Location = new System.Drawing.Point(4, 22);
            this.tabContratadoInserir.Name = "tabContratadoInserir";
            this.tabContratadoInserir.Size = new System.Drawing.Size(896, 597);
            this.tabContratadoInserir.TabIndex = 2;
            this.tabContratadoInserir.Text = "Inserir";
            this.tabContratadoInserir.UseVisualStyleBackColor = true;
            // 
            // buttonContratadoExecutarInserir
            // 
            this.buttonContratadoExecutarInserir.Location = new System.Drawing.Point(404, 88);
            this.buttonContratadoExecutarInserir.Name = "buttonContratadoExecutarInserir";
            this.buttonContratadoExecutarInserir.Size = new System.Drawing.Size(92, 94);
            this.buttonContratadoExecutarInserir.TabIndex = 7;
            this.buttonContratadoExecutarInserir.Text = "EXECUTAR";
            this.buttonContratadoExecutarInserir.UseVisualStyleBackColor = true;
            this.buttonContratadoExecutarInserir.Click += new System.EventHandler(this.buttonExecutarInserir_Click);
            // 
            // textBoxContratadoSaidaInserir
            // 
            this.textBoxContratadoSaidaInserir.Location = new System.Drawing.Point(3, 334);
            this.textBoxContratadoSaidaInserir.Multiline = true;
            this.textBoxContratadoSaidaInserir.Name = "textBoxContratadoSaidaInserir";
            this.textBoxContratadoSaidaInserir.ReadOnly = true;
            this.textBoxContratadoSaidaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContratadoSaidaInserir.Size = new System.Drawing.Size(890, 247);
            this.textBoxContratadoSaidaInserir.TabIndex = 6;
            // 
            // textBoxContratadoExemploInserir
            // 
            this.textBoxContratadoExemploInserir.Location = new System.Drawing.Point(515, 3);
            this.textBoxContratadoExemploInserir.Multiline = true;
            this.textBoxContratadoExemploInserir.Name = "textBoxContratadoExemploInserir";
            this.textBoxContratadoExemploInserir.ReadOnly = true;
            this.textBoxContratadoExemploInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContratadoExemploInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxContratadoExemploInserir.TabIndex = 5;
            // 
            // textBoxContratadoEntradaInserir
            // 
            this.textBoxContratadoEntradaInserir.Location = new System.Drawing.Point(3, 3);
            this.textBoxContratadoEntradaInserir.Multiline = true;
            this.textBoxContratadoEntradaInserir.Name = "textBoxContratadoEntradaInserir";
            this.textBoxContratadoEntradaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContratadoEntradaInserir.Size = new System.Drawing.Size(378, 325);
            this.textBoxContratadoEntradaInserir.TabIndex = 4;
            this.textBoxContratadoEntradaInserir.TextChanged += new System.EventHandler(this.textBoxContratadoEntradaInserir_TextChanged);
            // 
            // tabContratadoAtualizar
            // 
            this.tabContratadoAtualizar.Controls.Add(this.buttonContratadoAtualizar);
            this.tabContratadoAtualizar.Controls.Add(this.textBoxContratadoSaidaAtualizar);
            this.tabContratadoAtualizar.Controls.Add(this.textBoxContratadoExemploAtualizar);
            this.tabContratadoAtualizar.Controls.Add(this.textBoxContratadoEntradaAtualizar);
            this.tabContratadoAtualizar.Location = new System.Drawing.Point(4, 22);
            this.tabContratadoAtualizar.Name = "tabContratadoAtualizar";
            this.tabContratadoAtualizar.Size = new System.Drawing.Size(896, 597);
            this.tabContratadoAtualizar.TabIndex = 3;
            this.tabContratadoAtualizar.Text = "Atualizar";
            this.tabContratadoAtualizar.UseVisualStyleBackColor = true;
            // 
            // buttonContratadoAtualizar
            // 
            this.buttonContratadoAtualizar.Location = new System.Drawing.Point(404, 94);
            this.buttonContratadoAtualizar.Name = "buttonContratadoAtualizar";
            this.buttonContratadoAtualizar.Size = new System.Drawing.Size(92, 94);
            this.buttonContratadoAtualizar.TabIndex = 11;
            this.buttonContratadoAtualizar.Text = "EXECUTAR";
            this.buttonContratadoAtualizar.UseVisualStyleBackColor = true;
            this.buttonContratadoAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
            // 
            // textBoxContratadoSaidaAtualizar
            // 
            this.textBoxContratadoSaidaAtualizar.Location = new System.Drawing.Point(3, 340);
            this.textBoxContratadoSaidaAtualizar.Multiline = true;
            this.textBoxContratadoSaidaAtualizar.Name = "textBoxContratadoSaidaAtualizar";
            this.textBoxContratadoSaidaAtualizar.ReadOnly = true;
            this.textBoxContratadoSaidaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContratadoSaidaAtualizar.Size = new System.Drawing.Size(890, 247);
            this.textBoxContratadoSaidaAtualizar.TabIndex = 10;
            // 
            // textBoxContratadoExemploAtualizar
            // 
            this.textBoxContratadoExemploAtualizar.Location = new System.Drawing.Point(515, 9);
            this.textBoxContratadoExemploAtualizar.Multiline = true;
            this.textBoxContratadoExemploAtualizar.Name = "textBoxContratadoExemploAtualizar";
            this.textBoxContratadoExemploAtualizar.ReadOnly = true;
            this.textBoxContratadoExemploAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContratadoExemploAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxContratadoExemploAtualizar.TabIndex = 9;
            // 
            // textBoxContratadoEntradaAtualizar
            // 
            this.textBoxContratadoEntradaAtualizar.Location = new System.Drawing.Point(3, 9);
            this.textBoxContratadoEntradaAtualizar.Multiline = true;
            this.textBoxContratadoEntradaAtualizar.Name = "textBoxContratadoEntradaAtualizar";
            this.textBoxContratadoEntradaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxContratadoEntradaAtualizar.Size = new System.Drawing.Size(378, 325);
            this.textBoxContratadoEntradaAtualizar.TabIndex = 8;
            this.textBoxContratadoEntradaAtualizar.TextChanged += new System.EventHandler(this.textBoxContratadoEntradaAtualizar_TextChanged);
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
            // FormContratado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 647);
            this.Controls.Add(this.tabControlContratado);
            this.Name = "FormContratado";
            this.Text = "Contratado";
            this.tabControlContratado.ResumeLayout(false);
            this.tabPageBuscarTodos.ResumeLayout(false);
            this.tabPageBuscarTodos.PerformLayout();
            this.tabPageBuscarById.ResumeLayout(false);
            this.tabPageBuscarById.PerformLayout();
            this.tabContratadoInserir.ResumeLayout(false);
            this.tabContratadoInserir.PerformLayout();
            this.tabContratadoAtualizar.ResumeLayout(false);
            this.tabContratadoAtualizar.PerformLayout();
            this.tabPageExcluir.ResumeLayout(false);
            this.tabPageExcluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlContratado;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.Button buttonBuscarTodos;
        private System.Windows.Forms.TabPage tabPageBuscarById;
        private System.Windows.Forms.TabPage tabContratadoInserir;
        private System.Windows.Forms.TabPage tabContratadoAtualizar;
        private System.Windows.Forms.TabPage tabPageExcluir;
        private System.Windows.Forms.Button buttonExecutarId;
        private System.Windows.Forms.TextBox textBoxSaidaBuscarId;
        private System.Windows.Forms.TextBox textBoxExemploId;
        private System.Windows.Forms.TextBox textBoxEntradaBuscarId;
        private System.Windows.Forms.Button buttonContratadoExecutarInserir;
        private System.Windows.Forms.TextBox textBoxContratadoSaidaInserir;
        private System.Windows.Forms.TextBox textBoxContratadoExemploInserir;
        private System.Windows.Forms.TextBox textBoxContratadoEntradaInserir;
        private System.Windows.Forms.Button buttonContratadoAtualizar;
        private System.Windows.Forms.TextBox textBoxContratadoSaidaAtualizar;
        private System.Windows.Forms.TextBox textBoxContratadoExemploAtualizar;
        private System.Windows.Forms.TextBox textBoxContratadoEntradaAtualizar;
        private System.Windows.Forms.Button buttonExcluir;
        private System.Windows.Forms.TextBox textBoxSaidaExcluir;
        private System.Windows.Forms.TextBox textBoxExemploExcluir;
        private System.Windows.Forms.TextBox textBoxEntradaExcluir;
    }
}