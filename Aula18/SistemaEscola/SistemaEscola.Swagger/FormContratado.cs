using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SistemaEscola.Dominio.Contratado;
using SistemaEscola.Service;

namespace SistemaEscola.Swagger
{
    public partial class FormContratado : Form
    {
        private ContratadoService _service = new ContratadoService();

        public FormContratado()
        {
            InitializeComponent();
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
                    textBoxContratadoSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var contratadoDto = _service.Inserir(contratadoViewModel);

                textBoxContratadoSaidaInserir.Text = JsonConvert.SerializeObject(contratadoDto);
            }
            catch (Exception ex)
            {
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
                var contratadoViewModel = JsonConvert.DeserializeObject<ContratadoAtualizarViewModel>(textBoxContratadoEntradaAtualizar.Text);

                if (contratadoViewModel == null)
                {
                    textBoxContratadoSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var contratadoDto = _service.Atualizar(contratadoViewModel);

                textBoxContratadoSaidaAtualizar.Text = JsonConvert.SerializeObject(contratadoDto);
            }
            catch (Exception ex)
            {
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
    }
}
