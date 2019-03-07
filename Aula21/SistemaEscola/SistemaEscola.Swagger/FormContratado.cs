using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SistemaEscola.Dominio.Contratado;
using SistemaEscola.Dominio.Contratado.Interfacecs;

namespace SistemaEscola.Swagger
{
    public partial class FormContratado : Form
    {
        private IContratadoService _service;

        public FormContratado(IContratadoService service)
        {
            InitializeComponent();
            _service = service;
        }


        #region Inserir
        private void CarregarExemploInserir()
        {
            ContratadoInserirViewModel contratadoViewModel = new ContratadoInserirViewModel();
            string texto = JsonConvert.SerializeObject(contratadoViewModel);
            textBoxContratadoExemploInserir.Text = texto;
            textBoxContratadoEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var contratadoViewModel = JsonConvert.DeserializeObject<ContratadoInserirViewModel>(textBoxContratadoEntradaInserir.Text);

                if (contratadoViewModel == null)
                {
                    textBoxStatusCodeInserir.Text = "400 Bad Request";
                    textBoxContratadoSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var contratadoDtoReturn = _service.Inserir(contratadoViewModel);

                if (contratadoDtoReturn.Erros.Count > 0)
                {
                    textBoxStatusCodeInserir.Text = "400 Bad Request";
                    textBoxContratadoSaidaInserir.Text = JsonConvert.SerializeObject(contratadoDtoReturn.Erros);
                    return;
                }

                textBoxStatusCodeInserir.Text = "200 OK";
                textBoxContratadoSaidaInserir.Text = JsonConvert.SerializeObject(contratadoDtoReturn.Contratado);
            }
            catch (Exception ex)
            {
                textBoxStatusCodeInserir.Text = "500 Internal Server Error.";
                textBoxContratadoSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
        #endregion

        #region BuscarTodos
        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var contratadoes = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(contratadoes);
            }
            catch (Exception ex)
            {
                textBoxContratadoSaidaInserir.Text = $"{ex.ToString()}";
            }
        }
        #endregion

        #region BuscarId
        private void CarregarExemploBuscarId()
        {
            textBoxExemploId.Text = Guid.NewGuid().ToString();
            textBoxEntradaBuscarId.Text = Guid.NewGuid().ToString();
        }

        private void buttonExecutarId_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaBuscarId.Text;

                if (entrada == null)
                {
                    textBoxSaidaBuscarId.Text = "Id inválido.";
                    return;
                }

                if (!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaBuscarId.Text = "Id inválido.";
                    return;
                }


                var contratadoDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(contratadoDto);
            }
            catch (Exception ex)
            {
                textBoxSaidaBuscarId.Text = $"{ex.ToString()}";
            }
        }
        #endregion

        #region Atualizar
        private void CarregarExemploAtualizar()
        {
            ContratadoAtualizarViewModel contratadoViewModel = new ContratadoAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(contratadoViewModel);
            textBoxContratadoExemploAtualizar.Text = texto;
            textBoxContratadoEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedorViewModel = JsonConvert.DeserializeObject<ContratadoAtualizarViewModel>(textBoxContratadoEntradaAtualizar.Text);

                if (fornecedorViewModel == null)
                {
                    textBoxStatusCodeAtualizar.Text = "400 Bad Request.";
                    textBoxContratadoSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var fornecedorDtoReturn = _service.Atualizar(fornecedorViewModel);

                if (fornecedorDtoReturn.Erros.Count > 0)
                {
                    textBoxStatusCodeAtualizar.Text = "400 Bad Request";
                    textBoxContratadoSaidaAtualizar.Text = JsonConvert.SerializeObject(fornecedorDtoReturn.Erros);
                    return;
                }

                textBoxStatusCodeAtualizar.Text = "200 OK.";
                textBoxContratadoSaidaAtualizar.Text = JsonConvert.SerializeObject(fornecedorDtoReturn.Contratado);
            }
            catch (Exception ex)
            {
                textBoxStatusCodeAtualizar.Text = "500 Internal Server Error.";
                textBoxContratadoSaidaAtualizar.Text = $"{ex.ToString()}";
            }
        }
        #endregion



        #region Excluir
        private void CarregarExemploExcluir()
        {
            textBoxExemploExcluir.Text = Guid.NewGuid().ToString();
            textBoxEntradaExcluir.Text = Guid.NewGuid().ToString();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaExcluir.Text;

                if (entrada == null)
                {
                    textBoxSaidaExcluir.Text = "Id inválido.";
                    return;
                }

                if (!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaExcluir.Text = "Id inválido.";
                    return;
                }

                _service.Excluir(guid);

                textBoxSaidaExcluir.Text = "Excluir com Sucesso.";

            }
            catch (Exception ex)
            {
                textBoxSaidaExcluir.Text = $"{ex.ToString()}";
            }
        }
        #endregion

        private void textBoxContratadoEntradaInserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxContratadoEntradaAtualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntradaBuscarId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormContratado_Load(object sender, EventArgs e)
        {
            CarregarExemploAtualizar();
            CarregarExemploBuscarId();
            CarregarExemploExcluir();
            CarregarExemploInserir();
        }

        private void textBoxStatusCodeAtualizar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
