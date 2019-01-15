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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageInserir = new System.Windows.Forms.TabPage();
            this.textBoxSaidaInserir = new System.Windows.Forms.TextBox();
            this.buttonExecurarInserir = new System.Windows.Forms.Button();
            this.textBoxExemploInserir = new System.Windows.Forms.TextBox();
            this.textBoxEntradaInserir = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonBuscarTodos = new System.Windows.Forms.Button();
            this.textBoxBuscarTodos = new System.Windows.Forms.TextBox();
            this.tabControlCliente.SuspendLayout();
            this.tabPageBuscarTodos.SuspendLayout();
            this.tabPageInserir.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlCliente
            // 
            this.tabControlCliente.Controls.Add(this.tabPageBuscarTodos);
            this.tabControlCliente.Controls.Add(this.tabPage2);
            this.tabControlCliente.Controls.Add(this.tabPageInserir);
            this.tabControlCliente.Controls.Add(this.tabPage4);
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(788, 509);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            // textBoxBuscarTodos
            // 
            this.textBoxBuscarTodos.Location = new System.Drawing.Point(7, 50);
            this.textBoxBuscarTodos.Multiline = true;
            this.textBoxBuscarTodos.Name = "textBoxBuscarTodos";
            this.textBoxBuscarTodos.Size = new System.Drawing.Size(775, 449);
            this.textBoxBuscarTodos.TabIndex = 1;
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
            this.tabPageInserir.ResumeLayout(false);
            this.tabPageInserir.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlCliente;
        private System.Windows.Forms.TabPage tabPageBuscarTodos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageInserir;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonExecurarInserir;
        private System.Windows.Forms.TextBox textBoxExemploInserir;
        private System.Windows.Forms.TextBox textBoxEntradaInserir;
        private System.Windows.Forms.TextBox textBoxSaidaInserir;
        private System.Windows.Forms.TextBox textBoxBuscarTodos;
        private System.Windows.Forms.Button buttonBuscarTodos;
    }
}