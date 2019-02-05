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
            HoristaInserirViewModel HoristaViewModel = new HoristaInserirViewModel();
            string texto = JsonConvert.SerializeObject(HoristaViewModel);
            textBoxHoristaExemploInserir.Text = texto;
            textBoxHoristaEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var HoristaViewModel = JsonConvert.DeserializeObject<HoristaInserirViewModel>(textBoxHoristaEntradaInserir.Text);

                if (HoristaViewModel == null)
                {
                    textBoxHoristaSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var HoristaDto = _service.Inserir(HoristaViewModel);

                textBoxHoristaSaidaInserir.Text = JsonConvert.SerializeObject(HoristaDto);
            }
            catch (Exception ex)
            {
                textBoxHoristaSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
        #endregion

        #region BuscarTodos
        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var Horistaes = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(Horistaes);
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


                var HoristaDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(HoristaDto);
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
            HoristaAtualizarViewModel HoristaViewModel = new HoristaAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(HoristaViewModel);
            textBoxHoristaExemploAtualizar.Text = texto;
            textBoxHoristaEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var HoristaViewModel = JsonConvert.DeserializeObject<HoristaAtualizarViewModel>(textBoxHoristaEntradaAtualizar.Text);

                if (HoristaViewModel == null)
                {
                    textBoxHoristaSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var HoristaDto = _service.Atualizar(HoristaViewModel);

                textBoxHoristaSaidaAtualizar.Text = JsonConvert.SerializeObject(HoristaDto);
            }
            catch (Exception ex)
            {
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
