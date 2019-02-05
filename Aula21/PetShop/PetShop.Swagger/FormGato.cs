using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using PetShop.Dominio.Animal.Gato;
using PetShop.Service;

namespace PetShop.Swagger
{
    public partial class FormGato : Form
    {
        private GatoService _service = new GatoService();

        public FormGato()
        {
            InitializeComponent();
        }

        #region Inserir
        private void CarregarExemploInserir()
        {
            GatoInserirViewModel GatoViewModel = new GatoInserirViewModel();
            string texto = JsonConvert.SerializeObject(GatoViewModel);
            textBoxGatoExemploInserir.Text = texto;
            textBoxGatoEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var GatoViewModel = JsonConvert.DeserializeObject<GatoInserirViewModel>(textBoxGatoEntradaInserir.Text);

                if (GatoViewModel == null)
                {
                    textBoxGatoSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var GatoDto = _service.Inserir(GatoViewModel);

                textBoxGatoSaidaInserir.Text = JsonConvert.SerializeObject(GatoDto);
            }
            catch (Exception ex)
            {
                textBoxGatoSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
        #endregion

        #region BuscarTodos
        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var Gatos = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(Gatos);
            }
            catch (Exception ex)
            {
                textBoxGatoSaidaInserir.Text = $"{ex.ToString()}";
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


                var GatoDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(GatoDto);
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
            GatoAtualizarViewModel GatoViewModel = new GatoAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(GatoViewModel);
            textBoxGatoExemploAtualizar.Text = texto;
            textBoxGatoEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var GatoViewModel = JsonConvert.DeserializeObject<GatoAtualizarViewModel>(textBoxGatoEntradaAtualizar.Text);

                if (GatoViewModel == null)
                {
                    textBoxGatoSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var GatoDto = _service.Atualizar(GatoViewModel);

                textBoxGatoSaidaAtualizar.Text = JsonConvert.SerializeObject(GatoDto);
            }
            catch (Exception ex)
            {
                textBoxGatoSaidaAtualizar.Text = $"{ex.ToString()}";
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

        private void textBoxGatoEntradaInserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxGatoEntradaAtualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntradaBuscarId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormGato_Load(object sender, EventArgs e)
        {
            CarregarExemploAtualizar();
            CarregarExemploBuscarId();
            CarregarExemploExcluir();
            CarregarExemploInserir();
        }
    }
}
