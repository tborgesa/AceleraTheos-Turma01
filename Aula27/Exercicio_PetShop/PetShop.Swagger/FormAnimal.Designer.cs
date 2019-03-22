namespace PetShop.Swagger
{
    partial class FormAnimal
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
            this.tabControlAnimal = new System.Windows.Forms.TabControl();
            this.tabPageBuscarTodos = new System.Windows.Forms.TabPage();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.buttonExecutarBuscarTodos = new System.Windows.Forms.Button();
            this.tabPageBuscarPorId = new System.Windows.Forms.TabPage();
            this.tabPageInserirAnimal = new System.Windows.Forms.TabPage();
            this.buttonExecutarInserir = new System.Windows.Forms.Button();
            this.textBoxSaidaInserir = new System.Windows.Forms.TextBox();
            this.textBoxStatusCodeInserir = new System.Windows.Forms.TextBox();
            this.textBoxExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabPageAtualizar = new System.Windows.Forms.TabPage();
            this.tabPageExcluir = new System.Windows.Forms.TabPage();
            this.buttonExecutarExcluir = new System.Windows.Forms.Button();
            this.textBoxSaidaExcluir = new System.Windows.Forms.TextBox();
            this.buttonExecutarAtualizar = new System.Windows.Forms.Button();
            this.textBoxSaidaAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxStatusCodeAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxExemploAtualizar = new System.Windows.Forms.TextBox();
            this.textBoxEntradaAtualizar = new System.Windows.Forms.TextBox();
            this.buttonExecutarBuscarPorId = new System.Windows.Forms.Button();
            this.textBoxSaidaBuscarPorId = new System.Windows.Forms.TextBox();
            this.textBoxExemploBuscarPorId = new System.Windows.Forms.TextBox();
            this.textBoxEntradaBuscarPorId = new System.Windows.Forms.TextBox();
            this.tabControlAnimal.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageBuscarPorId.SuspendLayout();
            this.tabPageInserirAnimal.SuspendLayout();
            this.tabPageAtualizar.SuspendLayout();
            this.tabPageExcluir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAnimal
            // 
            this.tabControlAnimal.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlAnimal.Controls.Add(this.tabPageBuscarPorId);
            this.tabControlAnimal.Controls.Add(this.tabPageInserirAnimal);
            this.tabControlAnimal.Controls.Add(this.tabPageAtualizar);
            this.tabControlAnimal.Controls.Add(this.tabPageExcluir);
            this.tabControlAnimal.Location = new System.Drawing.Point(1, -1);
            this.tabControlAnimal.Name = "tabControlAnimal";
            this.tabControlAnimal.SelectedIndex = 0;
            this.tabControlAnimal.Size = new System.Drawing.Size(799, 532);
            this.tabControlAnimal.TabIndex = 0;
            // 
            // tabPageBuscarTodos
            // 
            this.tabPageBuscarTodos.Controls.Add(this.textBoxBuscarTodos);
            this.tabPageBuscarTodos.Controls.Add(this.buttonExecutarBuscarTodos);
            this.tabPageBuscarTodos.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarTodos.Name = "tabPageBuscarTodos";
            this.tabPageBuscarTodos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarTodos.Size = new System.Drawing.Size(791, 506);
            this.tabPageBuscarTodos.TabIndex = 0;
            this.tabPageBuscarTodos.Text = "Buscar Todos";
            this.tabPageBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // textBoxBuscarTodos
            // 
            this.textBoxBuscarTodos.Location = new System.Drawing.Point(7, 47);
            this.textBoxBuscarTodos.Multiline = true;
            this.textBoxBuscarTodos.Name = "textBoxBuscarTodos";
            this.textBoxBuscarTodos.ReadOnly = true;
            this.textBoxBuscarTodos.Size = new System.Drawing.Size(778, 451);
            this.textBoxBuscarTodos.TabIndex = 1;
            // 
            // buttonExecutarBuscarTodos
            // 
            this.buttonExecutarBuscarTodos.Location = new System.Drawing.Point(6, 7);
            this.buttonExecutarBuscarTodos.Name = "buttonExecutarBuscarTodos";
            this.buttonExecutarBuscarTodos.Size = new System.Drawing.Size(140, 33);
            this.buttonExecutarBuscarTodos.TabIndex = 0;
            this.buttonExecutarBuscarTodos.Text = "EXECUTAR";
            this.buttonExecutarBuscarTodos.UseVisualStyleBackColor = true;
            this.buttonExecutarBuscarTodos.Click += new System.EventHandler(this.buttonExecutarBuscarTodos_Click);
            // 
            // tabPageBuscarPorId
            // 
            this.tabPageBuscarPorId.Controls.Add(this.buttonExecutarBuscarPorId);
            this.tabPageBuscarPorId.Controls.Add(this.textBoxSaidaBuscarPorId);
            this.tabPageBuscarPorId.Controls.Add(this.textBoxExemploBuscarPorId);
            this.tabPageBuscarPorId.Controls.Add(this.textBoxEntradaBuscarPorId);
            this.tabPageBuscarPorId.Location = new System.Drawing.Point(4, 22);
            this.tabPageBuscarPorId.Name = "tabPageBuscarPorId";
            this.tabPageBuscarPorId.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBuscarPorId.Size = new System.Drawing.Size(791, 506);
            this.tabPageBuscarPorId.TabIndex = 1;
            this.tabPageBuscarPorId.Text = "Buscar por Id";
            this.tabPageBuscarPorId.UseVisualStyleBackColor = true;
            // 
            // tabPageInserirAnimal
            // 
            this.tabPageInserirAnimal.Controls.Add(this.buttonExecutarInserir);
            this.tabPageInserirAnimal.Controls.Add(this.textBoxSaidaInserir);
            this.tabPageInserirAnimal.Controls.Add(this.textBoxStatusCodeInserir);
            this.tabPageInserirAnimal.Controls.Add(this.textBoxExemploInserir);
            this.tabPageInserirAnimal.Controls.Add(this.textBoxEntradaInserir);
            this.tabPageInserirAnimal.Location = new System.Drawing.Point(4, 22);
            this.tabPageInserirAnimal.Name = "tabPageInserirAnimal";
            this.tabPageInserirAnimal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInserirAnimal.Size = new System.Drawing.Size(791, 506);
            this.tabPageInserirAnimal.TabIndex = 2;
            this.tabPageInserirAnimal.Text = "Inserir Animal";
            this.tabPageInserirAnimal.UseVisualStyleBackColor = true;
            // 
            // buttonExecutarInserir
            // 
            this.buttonExecutarInserir.Location = new System.Drawing.Point(335, 51);
            this.buttonExecutarInserir.Name = "buttonExecutarInserir";
            this.buttonExecutarInserir.Size = new System.Drawing.Size(127, 78);
            this.buttonExecutarInserir.TabIndex = 4;
            this.buttonExecutarInserir.Text = "EXECUTAR";
            this.buttonExecutarInserir.UseVisualStyleBackColor = true;
            this.buttonExecutarInserir.Click += new System.EventHandler(this.buttonExecutarInserir_Click);
            // 
            // textBoxSaidaInserir
            // 
            this.textBoxSaidaInserir.Location = new System.Drawing.Point(7, 240);
            this.textBoxSaidaInserir.Multiline = true;
            this.textBoxSaidaInserir.Name = "textBoxSaidaInserir";
            this.textBoxSaidaInserir.ReadOnly = true;
            this.textBoxSaidaInserir.Size = new System.Drawing.Size(777, 260);
            this.textBoxSaidaInserir.TabIndex = 3;
            // 
            // textBoxStatusCodeInserir
            // 
            this.textBoxStatusCodeInserir.Location = new System.Drawing.Point(8, 180);
            this.textBoxStatusCodeInserir.Multiline = true;
            this.textBoxStatusCodeInserir.Name = "textBoxStatusCodeInserir";
            this.textBoxStatusCodeInserir.ReadOnly = true;
            this.textBoxStatusCodeInserir.Size = new System.Drawing.Size(777, 54);
            this.textBoxStatusCodeInserir.TabIndex = 2;
            // 
            // textBoxExemploInserir
            // 
            this.textBoxExemploInserir.Location = new System.Drawing.Point(468, 3);
            this.textBoxExemploInserir.Multiline = true;
            this.textBoxExemploInserir.Name = "textBoxExemploInserir";
            this.textBoxExemploInserir.ReadOnly = true;
            this.textBoxExemploInserir.Size = new System.Drawing.Size(315, 170);
            this.textBoxExemploInserir.TabIndex = 1;
            // 
            // textBoxEntradaInserir
            // 
            this.textBoxEntradaInserir.Location = new System.Drawing.Point(8, 4);
            this.textBoxEntradaInserir.Multiline = true;
            this.textBoxEntradaInserir.Name = "textBoxEntradaInserir";
            this.textBoxEntradaInserir.Size = new System.Drawing.Size(320, 170);
            this.textBoxEntradaInserir.TabIndex = 0;
            // 
            // tabPageAtualizar
            // 
            this.tabPageAtualizar.Controls.Add(this.buttonExecutarAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxSaidaAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxStatusCodeAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxExemploAtualizar);
            this.tabPageAtualizar.Controls.Add(this.textBoxEntradaAtualizar);
            this.tabPageAtualizar.Location = new System.Drawing.Point(4, 22);
            this.tabPageAtualizar.Name = "tabPageAtualizar";
            this.tabPageAtualizar.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAtualizar.Size = new System.Drawing.Size(791, 506);
            this.tabPageAtualizar.TabIndex = 3;
            this.tabPageAtualizar.Text = "Atualizar";
            this.tabPageAtualizar.UseVisualStyleBackColor = true;
            // 
            // tabPageExcluir
            // 
            this.tabPageExcluir.Controls.Add(this.textBoxSaidaExcluir);
            this.tabPageExcluir.Controls.Add(this.buttonExecutarExcluir);
            this.tabPageExcluir.Location = new System.Drawing.Point(4, 22);
            this.tabPageExcluir.Name = "tabPageExcluir";
            this.tabPageExcluir.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExcluir.Size = new System.Drawing.Size(791, 506);
            this.tabPageExcluir.TabIndex = 4;
            this.tabPageExcluir.Text = "Excluir";
            this.tabPageExcluir.UseVisualStyleBackColor = true;
            // 
            // buttonExecutarExcluir
            // 
            this.buttonExecutarExcluir.Location = new System.Drawing.Point(4, 4);
            this.buttonExecutarExcluir.Name = "buttonExecutarExcluir";
            this.buttonExecutarExcluir.Size = new System.Drawing.Size(181, 42);
            this.buttonExecutarExcluir.TabIndex = 0;
            this.buttonExecutarExcluir.Text = "EXECUTAR";
            this.buttonExecutarExcluir.UseVisualStyleBackColor = true;
            // 
            // textBoxSaidaExcluir
            // 
            this.textBoxSaidaExcluir.Location = new System.Drawing.Point(4, 53);
            this.textBoxSaidaExcluir.Multiline = true;
            this.textBoxSaidaExcluir.Name = "textBoxSaidaExcluir";
            this.textBoxSaidaExcluir.ReadOnly = true;
            this.textBoxSaidaExcluir.Size = new System.Drawing.Size(781, 445);
            this.textBoxSaidaExcluir.TabIndex = 1;
            // 
            // buttonExecutarAtualizar
            // 
            this.buttonExecutarAtualizar.Location = new System.Drawing.Point(334, 53);
            this.buttonExecutarAtualizar.Name = "buttonExecutarAtualizar";
            this.buttonExecutarAtualizar.Size = new System.Drawing.Size(127, 78);
            this.buttonExecutarAtualizar.TabIndex = 9;
            this.buttonExecutarAtualizar.Text = "EXECUTAR";
            this.buttonExecutarAtualizar.UseVisualStyleBackColor = true;
            // 
            // textBoxSaidaAtualizar
            // 
            this.textBoxSaidaAtualizar.Location = new System.Drawing.Point(6, 242);
            this.textBoxSaidaAtualizar.Multiline = true;
            this.textBoxSaidaAtualizar.Name = "textBoxSaidaAtualizar";
            this.textBoxSaidaAtualizar.ReadOnly = true;
            this.textBoxSaidaAtualizar.Size = new System.Drawing.Size(777, 260);
            this.textBoxSaidaAtualizar.TabIndex = 8;
            // 
            // textBoxStatusCodeAtualizar
            // 
            this.textBoxStatusCodeAtualizar.Location = new System.Drawing.Point(7, 182);
            this.textBoxStatusCodeAtualizar.Multiline = true;
            this.textBoxStatusCodeAtualizar.Name = "textBoxStatusCodeAtualizar";
            this.textBoxStatusCodeAtualizar.ReadOnly = true;
            this.textBoxStatusCodeAtualizar.Size = new System.Drawing.Size(777, 54);
            this.textBoxStatusCodeAtualizar.TabIndex = 7;
            // 
            // textBoxExemploAtualizar
            // 
            this.textBoxExemploAtualizar.Location = new System.Drawing.Point(467, 5);
            this.textBoxExemploAtualizar.Multiline = true;
            this.textBoxExemploAtualizar.Name = "textBoxExemploAtualizar";
            this.textBoxExemploAtualizar.ReadOnly = true;
            this.textBoxExemploAtualizar.Size = new System.Drawing.Size(315, 170);
            this.textBoxExemploAtualizar.TabIndex = 6;
            // 
            // textBoxEntradaAtualizar
            // 
            this.textBoxEntradaAtualizar.Location = new System.Drawing.Point(7, 6);
            this.textBoxEntradaAtualizar.Multiline = true;
            this.textBoxEntradaAtualizar.Name = "textBoxEntradaAtualizar";
            this.textBoxEntradaAtualizar.Size = new System.Drawing.Size(320, 170);
            this.textBoxEntradaAtualizar.TabIndex = 5;
            // 
            // buttonExecutarBuscarPorId
            // 
            this.buttonExecutarBuscarPorId.Location = new System.Drawing.Point(335, 6);
            this.buttonExecutarBuscarPorId.Name = "buttonExecutarBuscarPorId";
            this.buttonExecutarBuscarPorId.Size = new System.Drawing.Size(127, 48);
            this.buttonExecutarBuscarPorId.TabIndex = 13;
            this.buttonExecutarBuscarPorId.Text = "EXECUTAR";
            this.buttonExecutarBuscarPorId.UseVisualStyleBackColor = true;
            // 
            // textBoxSaidaBuscarPorId
            // 
            this.textBoxSaidaBuscarPorId.Location = new System.Drawing.Point(7, 60);
            this.textBoxSaidaBuscarPorId.Multiline = true;
            this.textBoxSaidaBuscarPorId.Name = "textBoxSaidaBuscarPorId";
            this.textBoxSaidaBuscarPorId.ReadOnly = true;
            this.textBoxSaidaBuscarPorId.Size = new System.Drawing.Size(777, 442);
            this.textBoxSaidaBuscarPorId.TabIndex = 12;
            // 
            // textBoxExemploBuscarPorId
            // 
            this.textBoxExemploBuscarPorId.Location = new System.Drawing.Point(468, 5);
            this.textBoxExemploBuscarPorId.Multiline = true;
            this.textBoxExemploBuscarPorId.Name = "textBoxExemploBuscarPorId";
            this.textBoxExemploBuscarPorId.ReadOnly = true;
            this.textBoxExemploBuscarPorId.Size = new System.Drawing.Size(315, 49);
            this.textBoxExemploBuscarPorId.TabIndex = 11;
            // 
            // textBoxEntradaBuscarPorId
            // 
            this.textBoxEntradaBuscarPorId.Location = new System.Drawing.Point(8, 6);
            this.textBoxEntradaBuscarPorId.Multiline = true;
            this.textBoxEntradaBuscarPorId.Name = "textBoxEntradaBuscarPorId";
            this.textBoxEntradaBuscarPorId.Size = new System.Drawing.Size(320, 49);
            this.textBoxEntradaBuscarPorId.TabIndex = 10;
            // 
            // FormAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 531);
            this.Controls.Add(this.tabControlAnimal);
            this.Name = "FormAnimal";
            this.Text = "FormAnimal";
            this.Load += new System.EventHandler(this.FormAnimal_Load);
            this.tabControlAnimal.ResumeLayout(false);
            this.tabPageBuscarTodos.ResumeLayout(false);
            this.tabPageBuscarTodos.PerformLayout();
            this.tabPageBuscarPorId.ResumeLayout(false);
            this.tabPageBuscarPorId.PerformLayout();
            this.tabPageInserirAnimal.ResumeLayout(false);
            this.tabPageInserirAnimal.PerformLayout();
            this.tabPageAtualizar.ResumeLayout(false);
            this.tabPageAtualizar.PerformLayout();
            this.tabPageExcluir.ResumeLayout(false);
            this.tabPageExcluir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAnimal;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TabPage tabPageBuscarPorId;
        private System.Windows.Forms.TabPage tabPageInserirAnimal;
        private System.Windows.Forms.TabPage tabPageAtualizar;
        private System.Windows.Forms.TabPage tabPageExcluir;
        private System.Windows.Forms.Button buttonExecutarInserir;
        private System.Windows.Forms.TextBox textBoxSaidaInserir;
        private System.Windows.Forms.TextBox textBoxStatusCodeInserir;
        private System.Windows.Forms.TextBox textBoxExemploInserir;
        private System.Windows.Forms.TextBox textBoxEntradaInserir;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.Button buttonExecutarBuscarTodos;
        private System.Windows.Forms.Button buttonExecutarBuscarPorId;
        private System.Windows.Forms.TextBox textBoxSaidaBuscarPorId;
        private System.Windows.Forms.TextBox textBoxExemploBuscarPorId;
        private System.Windows.Forms.TextBox textBoxEntradaBuscarPorId;
        private System.Windows.Forms.Button buttonExecutarAtualizar;
        private System.Windows.Forms.TextBox textBoxSaidaAtualizar;
        private System.Windows.Forms.TextBox textBoxStatusCodeAtualizar;
        private System.Windows.Forms.TextBox textBoxExemploAtualizar;
        private System.Windows.Forms.TextBox textBoxEntradaAtualizar;
        private System.Windows.Forms.TextBox textBoxSaidaExcluir;
        private System.Windows.Forms.Button buttonExecutarExcluir;
    }
}