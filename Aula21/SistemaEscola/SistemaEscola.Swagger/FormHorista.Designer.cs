//namespace SistemaEscola.Swagger
//{
//    partial class FormHorista
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// 
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            this.tabControlHorista = new System.Windows.Forms.TabControl();
//            this.tabPageBuscarTodos = new System.Windows.Forms.TabPage();
//            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
//            this.buttonBuscarTodos = new System.Windows.Forms.Button();
//            this.tabPageBuscarById = new System.Windows.Forms.TabPage();
//            this.buttonExecutarId = new System.Windows.Forms.Button();
//            this.textBoxSaidaBuscarId = new System.Windows.Forms.TextBox();
//            this.textBoxExemploId = new System.Windows.Forms.TextBox();
//            this.textBoxEntradaBuscarId = new System.Windows.Forms.TextBox();
//            this.tabHoristaInserir = new System.Windows.Forms.TabPage();
//            this.buttonHoristaExecutarInserir = new System.Windows.Forms.Button();
//            this.textBoxHoristaSaidaInserir = new System.Windows.Forms.TextBox();
//            this.textBoxHoristaExemploInserir = new System.Windows.Forms.TextBox();
//            this.textBoxHoristaEntradaInserir = new System.Windows.Forms.TextBox();
//            this.tabHoristaAtualizar = new System.Windows.Forms.TabPage();
//            this.buttonHoristaAtualizar = new System.Windows.Forms.Button();
//            this.textBoxHoristaSaidaAtualizar = new System.Windows.Forms.TextBox();
//            this.textBoxHoristaExemploAtualizar = new System.Windows.Forms.TextBox();
//            this.textBoxHoristaEntradaAtualizar = new System.Windows.Forms.TextBox();
//            this.tabPageExcluir = new System.Windows.Forms.TabPage();
//            this.buttonExcluir = new System.Windows.Forms.Button();
//            this.textBoxExemploExcluir = new System.Windows.Forms.TextBox();
//            this.textBoxEntradaExcluir = new System.Windows.Forms.TextBox();
//            this.textBoxSaidaExcluir = new System.Windows.Forms.TextBox();
//            this.textBoxStatusCodeInserir = new System.Windows.Forms.TextBox();
//            this.textBoxStatusCodeAtualizar = new System.Windows.Forms.TextBox();
//            this.tabControlHorista.SuspendLayout();
//            this.tabPageBuscarTodos.SuspendLayout();
//            this.tabPageBuscarById.SuspendLayout();
//            this.tabHoristaInserir.SuspendLayout();
//            this.tabHoristaAtualizar.SuspendLayout();
//            this.tabPageExcluir.SuspendLayout();
//            this.SuspendLayout();
//            // 
//            // tabControlHorista
//            // 
//            this.tabControlHorista.Controls.Add(this.tabPageBuscarTodos);
//            this.tabControlHorista.Controls.Add(this.tabPageBuscarById);
//            this.tabControlHorista.Controls.Add(this.tabHoristaInserir);
//            this.tabControlHorista.Controls.Add(this.tabHoristaAtualizar);
//            this.tabControlHorista.Controls.Add(this.tabPageExcluir);
//            this.tabControlHorista.Location = new System.Drawing.Point(12, 12);
//            this.tabControlHorista.Name = "tabControlHorista";
//            this.tabControlHorista.SelectedIndex = 0;
//            this.tabControlHorista.Size = new System.Drawing.Size(904, 623);
//            this.tabControlHorista.TabIndex = 0;
//            // 
//            // tabPageBuscarTodos
//            // 
//            this.tabPageBuscarTodos.Controls.Add(this.textBoxBuscarTodos);
//            this.tabPageBuscarTodos.Controls.Add(this.buttonBuscarTodos);
//            this.tabPageBuscarTodos.Location = new System.Drawing.Point(4, 22);
//            this.tabPageBuscarTodos.Name = "tabPageBuscarTodos";
//            this.tabPageBuscarTodos.Padding = new System.Windows.Forms.Padding(3);
//            this.tabPageBuscarTodos.Size = new System.Drawing.Size(896, 597);
//            this.tabPageBuscarTodos.TabIndex = 0;
//            this.tabPageBuscarTodos.Text = "Buscar Todos";
//            this.tabPageBuscarTodos.UseVisualStyleBackColor = true;
//            // 
//            // textBoxBuscarTodos
//            // 
//            this.textBoxBuscarTodos.Location = new System.Drawing.Point(7, 40);
//            this.textBoxBuscarTodos.Multiline = true;
//            this.textBoxBuscarTodos.Name = "textBoxBuscarTodos";
//            this.textBoxBuscarTodos.ReadOnly = true;
//            this.textBoxBuscarTodos.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxBuscarTodos.Size = new System.Drawing.Size(883, 551);
//            this.textBoxBuscarTodos.TabIndex = 11;
//            // 
//            // buttonBuscarTodos
//            // 
//            this.buttonBuscarTodos.Location = new System.Drawing.Point(7, 7);
//            this.buttonBuscarTodos.Name = "buttonBuscarTodos";
//            this.buttonBuscarTodos.Size = new System.Drawing.Size(104, 27);
//            this.buttonBuscarTodos.TabIndex = 0;
//            this.buttonBuscarTodos.Text = "Executar";
//            this.buttonBuscarTodos.UseVisualStyleBackColor = true;
//            this.buttonBuscarTodos.Click += new System.EventHandler(this.buttonBuscarTodos_Click);
//            // 
//            // tabPageBuscarById
//            // 
//            this.tabPageBuscarById.Controls.Add(this.buttonExecutarId);
//            this.tabPageBuscarById.Controls.Add(this.textBoxSaidaBuscarId);
//            this.tabPageBuscarById.Controls.Add(this.textBoxExemploId);
//            this.tabPageBuscarById.Controls.Add(this.textBoxEntradaBuscarId);
//            this.tabPageBuscarById.Location = new System.Drawing.Point(4, 22);
//            this.tabPageBuscarById.Name = "tabPageBuscarById";
//            this.tabPageBuscarById.Padding = new System.Windows.Forms.Padding(3);
//            this.tabPageBuscarById.Size = new System.Drawing.Size(896, 597);
//            this.tabPageBuscarById.TabIndex = 1;
//            this.tabPageBuscarById.Text = "Buscar Por Id";
//            this.tabPageBuscarById.UseVisualStyleBackColor = true;
//            // 
//            // buttonExecutarId
//            // 
//            this.buttonExecutarId.Location = new System.Drawing.Point(405, 6);
//            this.buttonExecutarId.Name = "buttonExecutarId";
//            this.buttonExecutarId.Size = new System.Drawing.Size(81, 31);
//            this.buttonExecutarId.TabIndex = 11;
//            this.buttonExecutarId.Text = "EXECUTAR";
//            this.buttonExecutarId.UseVisualStyleBackColor = true;
//            this.buttonExecutarId.Click += new System.EventHandler(this.buttonExecutarId_Click);
//            // 
//            // textBoxSaidaBuscarId
//            // 
//            this.textBoxSaidaBuscarId.Location = new System.Drawing.Point(6, 43);
//            this.textBoxSaidaBuscarId.Multiline = true;
//            this.textBoxSaidaBuscarId.Name = "textBoxSaidaBuscarId";
//            this.textBoxSaidaBuscarId.ReadOnly = true;
//            this.textBoxSaidaBuscarId.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxSaidaBuscarId.Size = new System.Drawing.Size(884, 548);
//            this.textBoxSaidaBuscarId.TabIndex = 10;
//            // 
//            // textBoxExemploId
//            // 
//            this.textBoxExemploId.Location = new System.Drawing.Point(564, 6);
//            this.textBoxExemploId.Multiline = true;
//            this.textBoxExemploId.Name = "textBoxExemploId";
//            this.textBoxExemploId.ReadOnly = true;
//            this.textBoxExemploId.Size = new System.Drawing.Size(326, 31);
//            this.textBoxExemploId.TabIndex = 9;
//            // 
//            // textBoxEntradaBuscarId
//            // 
//            this.textBoxEntradaBuscarId.Location = new System.Drawing.Point(6, 6);
//            this.textBoxEntradaBuscarId.Multiline = true;
//            this.textBoxEntradaBuscarId.Name = "textBoxEntradaBuscarId";
//            this.textBoxEntradaBuscarId.Size = new System.Drawing.Size(326, 31);
//            this.textBoxEntradaBuscarId.TabIndex = 8;
//            this.textBoxEntradaBuscarId.TextChanged += new System.EventHandler(this.textBoxEntradaBuscarId_TextChanged);
//            // 
//            // tabHoristaInserir
//            // 
//            this.tabHoristaInserir.Controls.Add(this.textBoxStatusCodeInserir);
//            this.tabHoristaInserir.Controls.Add(this.buttonHoristaExecutarInserir);
//            this.tabHoristaInserir.Controls.Add(this.textBoxHoristaSaidaInserir);
//            this.tabHoristaInserir.Controls.Add(this.textBoxHoristaExemploInserir);
//            this.tabHoristaInserir.Controls.Add(this.textBoxHoristaEntradaInserir);
//            this.tabHoristaInserir.Location = new System.Drawing.Point(4, 22);
//            this.tabHoristaInserir.Name = "tabHoristaInserir";
//            this.tabHoristaInserir.Size = new System.Drawing.Size(896, 597);
//            this.tabHoristaInserir.TabIndex = 2;
//            this.tabHoristaInserir.Text = "Inserir";
//            this.tabHoristaInserir.UseVisualStyleBackColor = true;
//            // 
//            // buttonHoristaExecutarInserir
//            // 
//            this.buttonHoristaExecutarInserir.Location = new System.Drawing.Point(404, 88);
//            this.buttonHoristaExecutarInserir.Name = "buttonHoristaExecutarInserir";
//            this.buttonHoristaExecutarInserir.Size = new System.Drawing.Size(92, 94);
//            this.buttonHoristaExecutarInserir.TabIndex = 7;
//            this.buttonHoristaExecutarInserir.Text = "EXECUTAR";
//            this.buttonHoristaExecutarInserir.UseVisualStyleBackColor = true;
//            this.buttonHoristaExecutarInserir.Click += new System.EventHandler(this.buttonExecutarInserir_Click);
//            // 
//            // textBoxHoristaSaidaInserir
//            // 
//            this.textBoxHoristaSaidaInserir.Location = new System.Drawing.Point(3, 334);
//            this.textBoxHoristaSaidaInserir.Multiline = true;
//            this.textBoxHoristaSaidaInserir.Name = "textBoxHoristaSaidaInserir";
//            this.textBoxHoristaSaidaInserir.ReadOnly = true;
//            this.textBoxHoristaSaidaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxHoristaSaidaInserir.Size = new System.Drawing.Size(890, 247);
//            this.textBoxHoristaSaidaInserir.TabIndex = 6;
//            // 
//            // textBoxHoristaExemploInserir
//            // 
//            this.textBoxHoristaExemploInserir.Location = new System.Drawing.Point(515, 3);
//            this.textBoxHoristaExemploInserir.Multiline = true;
//            this.textBoxHoristaExemploInserir.Name = "textBoxHoristaExemploInserir";
//            this.textBoxHoristaExemploInserir.ReadOnly = true;
//            this.textBoxHoristaExemploInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxHoristaExemploInserir.Size = new System.Drawing.Size(378, 260);
//            this.textBoxHoristaExemploInserir.TabIndex = 5;
//            // 
//            // textBoxHoristaEntradaInserir
//            // 
//            this.textBoxHoristaEntradaInserir.Location = new System.Drawing.Point(3, 3);
//            this.textBoxHoristaEntradaInserir.Multiline = true;
//            this.textBoxHoristaEntradaInserir.Name = "textBoxHoristaEntradaInserir";
//            this.textBoxHoristaEntradaInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxHoristaEntradaInserir.Size = new System.Drawing.Size(378, 260);
//            this.textBoxHoristaEntradaInserir.TabIndex = 4;
//            this.textBoxHoristaEntradaInserir.TextChanged += new System.EventHandler(this.textBoxHoristaEntradaInserir_TextChanged);
//            // 
//            // tabHoristaAtualizar
//            // 
//            this.tabHoristaAtualizar.Controls.Add(this.textBoxStatusCodeAtualizar);
//            this.tabHoristaAtualizar.Controls.Add(this.buttonHoristaAtualizar);
//            this.tabHoristaAtualizar.Controls.Add(this.textBoxHoristaSaidaAtualizar);
//            this.tabHoristaAtualizar.Controls.Add(this.textBoxHoristaExemploAtualizar);
//            this.tabHoristaAtualizar.Controls.Add(this.textBoxHoristaEntradaAtualizar);
//            this.tabHoristaAtualizar.Location = new System.Drawing.Point(4, 22);
//            this.tabHoristaAtualizar.Name = "tabHoristaAtualizar";
//            this.tabHoristaAtualizar.Size = new System.Drawing.Size(896, 597);
//            this.tabHoristaAtualizar.TabIndex = 3;
//            this.tabHoristaAtualizar.Text = "Atualizar";
//            this.tabHoristaAtualizar.UseVisualStyleBackColor = true;
//            // 
//            // buttonHoristaAtualizar
//            // 
//            this.buttonHoristaAtualizar.Location = new System.Drawing.Point(404, 94);
//            this.buttonHoristaAtualizar.Name = "buttonHoristaAtualizar";
//            this.buttonHoristaAtualizar.Size = new System.Drawing.Size(92, 94);
//            this.buttonHoristaAtualizar.TabIndex = 11;
//            this.buttonHoristaAtualizar.Text = "EXECUTAR";
//            this.buttonHoristaAtualizar.UseVisualStyleBackColor = true;
//            this.buttonHoristaAtualizar.Click += new System.EventHandler(this.buttonAtualizar_Click);
//            // 
//            // textBoxHoristaSaidaAtualizar
//            // 
//            this.textBoxHoristaSaidaAtualizar.Location = new System.Drawing.Point(3, 340);
//            this.textBoxHoristaSaidaAtualizar.Multiline = true;
//            this.textBoxHoristaSaidaAtualizar.Name = "textBoxHoristaSaidaAtualizar";
//            this.textBoxHoristaSaidaAtualizar.ReadOnly = true;
//            this.textBoxHoristaSaidaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxHoristaSaidaAtualizar.Size = new System.Drawing.Size(890, 247);
//            this.textBoxHoristaSaidaAtualizar.TabIndex = 10;
//            // 
//            // textBoxHoristaExemploAtualizar
//            // 
//            this.textBoxHoristaExemploAtualizar.Location = new System.Drawing.Point(515, 9);
//            this.textBoxHoristaExemploAtualizar.Multiline = true;
//            this.textBoxHoristaExemploAtualizar.Name = "textBoxHoristaExemploAtualizar";
//            this.textBoxHoristaExemploAtualizar.ReadOnly = true;
//            this.textBoxHoristaExemploAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxHoristaExemploAtualizar.Size = new System.Drawing.Size(378, 266);
//            this.textBoxHoristaExemploAtualizar.TabIndex = 9;
//            // 
//            // textBoxHoristaEntradaAtualizar
//            // 
//            this.textBoxHoristaEntradaAtualizar.Location = new System.Drawing.Point(3, 9);
//            this.textBoxHoristaEntradaAtualizar.Multiline = true;
//            this.textBoxHoristaEntradaAtualizar.Name = "textBoxHoristaEntradaAtualizar";
//            this.textBoxHoristaEntradaAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxHoristaEntradaAtualizar.Size = new System.Drawing.Size(378, 266);
//            this.textBoxHoristaEntradaAtualizar.TabIndex = 8;
//            this.textBoxHoristaEntradaAtualizar.TextChanged += new System.EventHandler(this.textBoxHoristaEntradaAtualizar_TextChanged);
//            // 
//            // tabPageExcluir
//            // 
//            this.tabPageExcluir.Controls.Add(this.buttonExcluir);
//            this.tabPageExcluir.Controls.Add(this.textBoxExemploExcluir);
//            this.tabPageExcluir.Controls.Add(this.textBoxEntradaExcluir);
//            this.tabPageExcluir.Controls.Add(this.textBoxSaidaExcluir);
//            this.tabPageExcluir.Location = new System.Drawing.Point(4, 22);
//            this.tabPageExcluir.Name = "tabPageExcluir";
//            this.tabPageExcluir.Size = new System.Drawing.Size(896, 597);
//            this.tabPageExcluir.TabIndex = 4;
//            this.tabPageExcluir.Text = "Excluir";
//            this.tabPageExcluir.UseVisualStyleBackColor = true;
//            // 
//            // buttonExcluir
//            // 
//            this.buttonExcluir.Location = new System.Drawing.Point(405, 6);
//            this.buttonExcluir.Name = "buttonExcluir";
//            this.buttonExcluir.Size = new System.Drawing.Size(81, 31);
//            this.buttonExcluir.TabIndex = 15;
//            this.buttonExcluir.Text = "EXECUTAR";
//            this.buttonExcluir.UseVisualStyleBackColor = true;
//            this.buttonExcluir.Click += new System.EventHandler(this.buttonExcluir_Click);
//            // 
//            // textBoxExemploExcluir
//            // 
//            this.textBoxExemploExcluir.Location = new System.Drawing.Point(564, 6);
//            this.textBoxExemploExcluir.Multiline = true;
//            this.textBoxExemploExcluir.Name = "textBoxExemploExcluir";
//            this.textBoxExemploExcluir.ReadOnly = true;
//            this.textBoxExemploExcluir.Size = new System.Drawing.Size(326, 31);
//            this.textBoxExemploExcluir.TabIndex = 13;
//            // 
//            // textBoxEntradaExcluir
//            // 
//            this.textBoxEntradaExcluir.Location = new System.Drawing.Point(6, 6);
//            this.textBoxEntradaExcluir.Multiline = true;
//            this.textBoxEntradaExcluir.Name = "textBoxEntradaExcluir";
//            this.textBoxEntradaExcluir.Size = new System.Drawing.Size(326, 31);
//            this.textBoxEntradaExcluir.TabIndex = 12;
//            // 
//            // textBoxSaidaExcluir
//            // 
//            this.textBoxSaidaExcluir.Location = new System.Drawing.Point(9, 43);
//            this.textBoxSaidaExcluir.Multiline = true;
//            this.textBoxSaidaExcluir.Name = "textBoxSaidaExcluir";
//            this.textBoxSaidaExcluir.ReadOnly = true;
//            this.textBoxSaidaExcluir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxSaidaExcluir.Size = new System.Drawing.Size(884, 548);
//            this.textBoxSaidaExcluir.TabIndex = 14;
//            // 
//            // textBoxStatusCodeInserir
//            // 
//            this.textBoxStatusCodeInserir.Location = new System.Drawing.Point(3, 269);
//            this.textBoxStatusCodeInserir.Multiline = true;
//            this.textBoxStatusCodeInserir.Name = "textBoxStatusCodeInserir";
//            this.textBoxStatusCodeInserir.ReadOnly = true;
//            this.textBoxStatusCodeInserir.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxStatusCodeInserir.Size = new System.Drawing.Size(890, 59);
//            this.textBoxStatusCodeInserir.TabIndex = 5;
//            // 
//            // textBoxStatusCodeAtualizar
//            // 
//            this.textBoxStatusCodeAtualizar.Location = new System.Drawing.Point(3, 281);
//            this.textBoxStatusCodeAtualizar.Multiline = true;
//            this.textBoxStatusCodeAtualizar.Name = "textBoxStatusCodeAtualizar";
//            this.textBoxStatusCodeAtualizar.ReadOnly = true;
//            this.textBoxStatusCodeAtualizar.ScrollBars = System.Windows.Forms.ScrollBars.Both;
//            this.textBoxStatusCodeAtualizar.Size = new System.Drawing.Size(890, 53);
//            this.textBoxStatusCodeAtualizar.TabIndex = 12;
//            this.textBoxStatusCodeAtualizar.TextChanged += new System.EventHandler(this.textBoxStatusCodeAtualizar_TextChanged);
//            // 
//            // FormHorista
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.ClientSize = new System.Drawing.Size(928, 647);
//            this.Controls.Add(this.tabControlHorista);
//            this.Name = "FormHorista";
//            this.Text = "Horista";
//            this.Load += new System.EventHandler(this.FormHorista_Load);
//            this.tabControlHorista.ResumeLayout(false);
//            this.tabPageBuscarTodos.ResumeLayout(false);
//            this.tabPageBuscarTodos.PerformLayout();
//            this.tabPageBuscarById.ResumeLayout(false);
//            this.tabPageBuscarById.PerformLayout();
//            this.tabHoristaInserir.ResumeLayout(false);
//            this.tabHoristaInserir.PerformLayout();
//            this.tabHoristaAtualizar.ResumeLayout(false);
//            this.tabHoristaAtualizar.PerformLayout();
//            this.tabPageExcluir.ResumeLayout(false);
//            this.tabPageExcluir.PerformLayout();
//            this.ResumeLayout(false);

//        }

//        #endregion

//        private System.Windows.Forms.TabControl tabControlHorista;
//        private System.Windows.Forms.TabPage tabPageBuscarTodos;
//        private System.Windows.Forms.TextBox textBoxBuscarTodos;
//        private System.Windows.Forms.Button buttonBuscarTodos;
//        private System.Windows.Forms.TabPage tabPageBuscarById;
//        private System.Windows.Forms.TabPage tabHoristaInserir;
//        private System.Windows.Forms.TabPage tabHoristaAtualizar;
//        private System.Windows.Forms.TabPage tabPageExcluir;
//        private System.Windows.Forms.Button buttonExecutarId;
//        private System.Windows.Forms.TextBox textBoxSaidaBuscarId;
//        private System.Windows.Forms.TextBox textBoxExemploId;
//        private System.Windows.Forms.TextBox textBoxEntradaBuscarId;
//        private System.Windows.Forms.Button buttonHoristaExecutarInserir;
//        private System.Windows.Forms.TextBox textBoxHoristaSaidaInserir;
//        private System.Windows.Forms.TextBox textBoxHoristaExemploInserir;
//        private System.Windows.Forms.TextBox textBoxHoristaEntradaInserir;
//        private System.Windows.Forms.Button buttonHoristaAtualizar;
//        private System.Windows.Forms.TextBox textBoxHoristaSaidaAtualizar;
//        private System.Windows.Forms.TextBox textBoxHoristaExemploAtualizar;
//        private System.Windows.Forms.TextBox textBoxHoristaEntradaAtualizar;
//        private System.Windows.Forms.Button buttonExcluir;
//        private System.Windows.Forms.TextBox textBoxSaidaExcluir;
//        private System.Windows.Forms.TextBox textBoxExemploExcluir;
//        private System.Windows.Forms.TextBox textBoxEntradaExcluir;
//        private System.Windows.Forms.TextBox textBoxStatusCodeInserir;
//        private System.Windows.Forms.TextBox textBoxStatusCodeAtualizar;
//    }
//}