using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UaiQueijos.Dominio.Fornecedor;
using UaiQueijos.Service;

namespace UaiQueijos.Swagger
{
    public partial class FormFornecedor : Form
    {
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {
            CarregarExemploInserir();
        }

        #region Inserir
        private void CarregarExemploInserir()
        {
            FornecedorInserirViewModel fornecedorViewModel = new FornecedorInserirViewModel();
            string texto = JsonConvert.SerializeObject(fornecedorViewModel);
            textBoxExemploInserir.Text = texto;
            textBoxEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedorViewModel = JsonConvert.DeserializeObject<FornecedorInserirViewModel>(textBoxEntradaInserir.Text);

                if (fornecedorViewModel == null)
                {
                    textBoxSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var service = new FornecedorService();
                service.Inserir(fornecedorViewModel);

                textBoxSaidaInserir.Text = textBoxEntradaInserir.Text;
            }
            catch (Exception ex)
            {
                textBoxSaidaInserir.Text = $"Json inválido: {Environment.NewLine} {ex.ToString()}";
            }
        }

        #endregion

        #region BuscarTodos
        #endregion


    }
}
