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
            CarregarExemploBuscarId();
            CarregarExemploAtualizar();
            CarregarExemploExcluir();
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

        #region BuscarTodos
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
        #endregion

        #region BuscarId

        private void CarregarExemploBuscarId()
        {
            textBoxExemploId.Text = Guid.NewGuid().ToString();
            textBoxEntradaBuscarPorId.Text = Guid.NewGuid().ToString();
        }

        private void buttonExecutarId_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaBuscarPorId.Text;

                if (entrada == null)
                {
                    textBoxEntradaBuscarPorId.Text = "Id inválida.";
                    return;
                }

                if (!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaBuscarPorId.Text = "Id inválida.";
                    return;
                }

                var clienteDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarPorId.Text = JsonConvert.SerializeObject(clienteDto);

            }
            catch(Exception ex)
            {
                textBoxSaidaBuscarPorId.Text = $"{ex.ToString()}";
            }
        }


        #endregion

        #region Atualizar
        private void CarregarExemploAtualizar()
        {
            ClienteAtualizarViewModel clienteViewModel = new ClienteAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(clienteViewModel);
            textBoxExemploAtualizar.Text = texto;
            textBoxEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var clienteViewModel = JsonConvert.DeserializeObject<ClienteAtualizarViewModel>(textBoxEntradaAtualizar.Text);

                if(clienteViewModel == null)
                {
                    textBoxSaidaAtualizar.Text = $"Json inválido";
                    return;
                }

                var clienteDto = _service.Atualizar(clienteViewModel);
                textBoxSaidaAtualizar.Text = JsonConvert.SerializeObject(clienteDto);
            }
            catch(Exception ex)
            {
                textBoxSaidaAtualizar.Text = $"{ex.ToString()}";
            }
        }
        #endregion

        #region Excluir
        private void CarregarExemploExcluir()
        {
            textBoxExemploExcluir.Text = Guid.NewGuid().ToString();
            textBoxEntradaExcluir.Text = Guid.NewGuid().ToString();
        }

        private void buttonExecutarExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaExcluir.Text;

                if(entrada == null)
                {
                    textBoxSaidaExcluir.Text = "Id Inválida.";
                    return;
                }

                if(!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaExcluir.Text = "Id inválda.";
                    return;
                }

                _service.Excluir(guid);
                textBoxSaidaExcluir.Text = "Registro excluído com sucesso.";
            }
            catch(Exception ex)
            {
                textBoxSaidaExcluir.Text = $"{ex.ToString()}";
            }
        }
        #endregion


    }
}