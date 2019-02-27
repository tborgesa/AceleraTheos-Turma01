using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using SistemaEscola.Dominio.Horista;
using SistemaEscola.Service;

namespace SistemaEscola.Swagger
{
    public partial class FormHorista : Form
    {
        private HoristaService _service = new HoristaService();

        public FormHorista()
        {
            InitializeComponent();
        }


        #region Inserir
        private void CarregarExemploInserir()
        {
            HoristaInserirViewModel horistaViewModel = new HoristaInserirViewModel();
            string texto = JsonConvert.SerializeObject(horistaViewModel);
            textBoxHoristaExemploInserir.Text = texto;
            textBoxHoristaEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var horistaViewModel = JsonConvert.DeserializeObject<HoristaInserirViewModel>(textBoxHoristaEntradaInserir.Text);

                if (horistaViewModel == null)
                {
                    textBoxStatusCodeInserir.Text = "400 Bad Request";
                    textBoxHoristaSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var horistaDtoReturn = _service.Inserir(horistaViewModel);

                if (horistaDtoReturn.Erros.Count > 0)
                {
                    textBoxStatusCodeInserir.Text = "400 Bad Request";
                    textBoxHoristaSaidaInserir.Text = JsonConvert.SerializeObject(horistaDtoReturn.Erros);
                    return;
                }

                textBoxStatusCodeInserir.Text = "200 OK";
                textBoxHoristaSaidaInserir.Text = JsonConvert.SerializeObject(horistaDtoReturn.Horista);
            }
            catch (Exception ex)
            {
                textBoxStatusCodeInserir.Text = "500 Internal Server Error.";
                textBoxHoristaSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
        #endregion

        #region BuscarTodos
        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var horistaes = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(horistaes);
            }
            catch (Exception ex)
            {
                textBoxHoristaSaidaInserir.Text = $"{ex.ToString()}";
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


                var horistaDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(horistaDto);
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
            HoristaAtualizarViewModel horistaViewModel = new HoristaAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(horistaViewModel);
            textBoxHoristaExemploAtualizar.Text = texto;
            textBoxHoristaEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var fornecedorViewModel = JsonConvert.DeserializeObject<HoristaAtualizarViewModel>(textBoxHoristaEntradaAtualizar.Text);

                if (fornecedorViewModel == null)
                {
                    textBoxStatusCodeAtualizar.Text = "400 Bad Request.";
                    textBoxHoristaSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var fornecedorDtoReturn = _service.Atualizar(fornecedorViewModel);

                if (fornecedorDtoReturn.Erros.Count > 0)
                {
                    textBoxStatusCodeAtualizar.Text = "400 Bad Request";
                    textBoxHoristaSaidaAtualizar.Text = JsonConvert.SerializeObject(fornecedorDtoReturn.Erros);
                    return;
                }

                textBoxStatusCodeAtualizar.Text = "200 OK.";
                textBoxHoristaSaidaAtualizar.Text = JsonConvert.SerializeObject(fornecedorDtoReturn.Horista);
            }
            catch (Exception ex)
            {
                textBoxStatusCodeAtualizar.Text = "500 Internal Server Error.";
                textBoxHoristaSaidaAtualizar.Text = $"{ex.ToString()}";
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

        private void textBoxHoristaEntradaInserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxHoristaEntradaAtualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntradaBuscarId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormHorista_Load(object sender, EventArgs e)
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
