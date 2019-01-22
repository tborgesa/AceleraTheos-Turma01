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
                    textBoxStatusCodeInserir.Text = "400 - Bad Request.";
                    textBoxSaidaInserir.Text = $"Json Inválido";
                    return;
                }

                var clienteDtoReturn = _service.Inserir(clienteViewModel);

                if(clienteDtoReturn.Erros.Count > 0)
                {
                    textBoxStatusCodeInserir.Text = "400 - Bad Request.";
                    textBoxSaidaInserir.Text = JsonConvert.SerializeObject(clienteDtoReturn.Erros);
                    return;
                }

                textBoxStatusCodeInserir.Text = "200 - Sucess.";
                textBoxSaidaInserir.Text = JsonConvert.SerializeObject(clienteDtoReturn.Cliente);
                
            }
            catch (Exception ex)
            {
                textBoxStatusCodeInserir.Text = "500 - Internal Server Error.";
                textBoxSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }

        #endregion


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
                    textBoxStatusCodeAtualizar.Text = "400 - Bad Request.";
                    textBoxSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var clienteDtoReturn = _service.Atualizar(clienteViewModel);

                if(clienteDtoReturn.Erros.Count > 0)
                {
                    textBoxStatusCodeAtualizar.Text = "400 - Bad Request.";
                    textBoxSaidaAtualizar.Text = JsonConvert.SerializeObject(clienteDtoReturn.Erros);
                    return;
                }

                textBoxStatusCodeAtualizar.Text = "200 - Sucess.";
                textBoxSaidaAtualizar.Text = JsonConvert.SerializeObject(clienteDtoReturn.Cliente);
            }
            catch(Exception ex)
            {
                textBoxStatusCodeAtualizar.Text = "500 - Internal Service Error.";
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