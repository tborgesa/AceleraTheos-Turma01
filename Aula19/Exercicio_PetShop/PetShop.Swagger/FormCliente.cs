using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using PetShop.Dominio.Pessoas;
using PetShop.Service;

namespace PetShop.Swagger
{
    public partial class FormCliente : Form
    {
        private ClienteService _service = new ClienteService();

        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            CarregarExemploInserir();
        }

        private void textBoxExemploInserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntradaInserir_TextChanged(object sender, EventArgs e)
        {

        }

        #region Inserir
        private void CarregarExemploInserir()
        {
            ClinteInserirViewModel clienteViewModel = new ClinteInserirViewModel();
            string texto = JsonConvert.SerializeObject(clienteViewModel);
            textBoxExemploInserir.Text = texto;
            textBoxEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteViewModel = JsonConvert.DeserializeObject<ClinteInserirViewModel>(textBoxEntradaInserir.Text);

                if(clienteViewModel == null)
                {
                    textBoxSaidaInserir.Text = $"Json Inválido";
                    return;
                }

                var clienteDto = _service.Inserir(clienteViewModel);
                textBoxSaidaInserir.Text = JsonConvert.SerializeObject(clienteDto);
            }
            catch (Exception ex)
            {
                textBoxSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }

        #endregion

        private void tabPageInserir_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var clientes = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(clientes);
            }
            catch(Exception ex)
            {
                textBoxBuscarTodos.Text = $"{ex.ToString()}";
            }
        }
    }
}