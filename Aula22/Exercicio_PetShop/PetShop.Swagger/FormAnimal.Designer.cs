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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageInserirAnimal = new System.Windows.Forms.TabPage();
            this.buttonExecutarInserir = new System.Windows.Forms.Button();
            this.textBoxSaidaInserir = new System.Windows.Forms.TextBox();
            this.textBoxStatusCodeInserir = new System.Windows.Forms.TextBox();
            this.textBoxExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.buttonExecutarBuscarTodos = new System.Windows.Forms.Button();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.tabControlAnimal.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageInserirAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAnimal
            // 
            this.tabControlAnimal.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlAnimal.Controls.Add(this.tabPage2);
            this.tabControlAnimal.Controls.Add(this.tabPageInserirAnimal);
            this.tabControlAnimal.Controls.Add(this.tabPage4);
            this.tabControlAnimal.Controls.Add(this.tabPage5);
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
            this.tabPageBuscarTodos.Text = "tabPage1";
            this.tabPageBuscarTodos.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 506);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 506);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(791, 506);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
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
            // textBoxBuscarTodos
            // 
            this.textBoxBuscarTodos.Location = new System.Drawing.Point(7, 47);
            this.textBoxBuscarTodos.Multiline = true;
            this.textBoxBuscarTodos.Name = "textBoxBuscarTodos";
            this.textBoxBuscarTodos.ReadOnly = true;
            this.textBoxBuscarTodos.Size = new System.Drawing.Size(778, 451);
            this.textBoxBuscarTodos.TabIndex = 1;
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
            this.tabPageInserirAnimal.ResumeLayout(false);
            this.tabPageInserirAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAnimal;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageInserirAnimal;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonExecutarInserir;
        private System.Windows.Forms.TextBox textBoxSaidaInserir;
        private System.Windows.Forms.TextBox textBoxStatusCodeInserir;
        private System.Windows.Forms.TextBox textBoxExemploInserir;
        private System.Windows.Forms.TextBox textBoxEntradaInserir;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.Button buttonExecutarBuscarTodos;
    }
}