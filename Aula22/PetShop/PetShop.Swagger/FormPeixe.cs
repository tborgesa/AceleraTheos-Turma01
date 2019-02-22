using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using PetShop.Dominio.Animal.Peixe;
using PetShop.Service;

namespace PetShop.Swagger
{
    public partial class FormPeixe : Form
    {
        private PeixeService _service = new PeixeService();

        public FormPeixe()
        {
            InitializeComponent();
        }


        #region Inserir
        private void CarregarExemploInserir()
        {
            PeixeInserirViewModel PeixeViewModel = new PeixeInserirViewModel();
            string texto = JsonConvert.SerializeObject(PeixeViewModel);
            textBoxPeixeExemploInserir.Text = texto;
            textBoxPeixeEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var PeixeViewModel = JsonConvert.DeserializeObject<PeixeInserirViewModel>(textBoxPeixeEntradaInserir.Text);

                if (PeixeViewModel == null)
                {
                    textBoxPeixeSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var PeixeDto = _service.Inserir(PeixeViewModel);

                textBoxPeixeSaidaInserir.Text = JsonConvert.SerializeObject(PeixeDto);
            }
            catch (Exception ex)
            {
                textBoxPeixeSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
        #endregion

        #region BuscarTodos
        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var Peixes = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(Peixes);
            }
            catch (Exception ex)
            {
                textBoxPeixeSaidaInserir.Text = $"{ex.ToString()}";
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


                var PeixeDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(PeixeDto);
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
            PeixeAtualizarViewModel PeixeViewModel = new PeixeAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(PeixeViewModel);
            textBoxPeixeExemploAtualizar.Text = texto;
            textBoxPeixeEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var PeixeViewModel = JsonConvert.DeserializeObject<PeixeAtualizarViewModel>(textBoxPeixeEntradaAtualizar.Text);

                if (PeixeViewModel == null)
                {
                    textBoxPeixeSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var PeixeDto = _service.Atualizar(PeixeViewModel);

                textBoxPeixeSaidaAtualizar.Text = JsonConvert.SerializeObject(PeixeDto);
            }
            catch (Exception ex)
            {
                textBoxPeixeSaidaAtualizar.Text = $"{ex.ToString()}";
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

        private void textBoxPeixeEntradaInserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPeixeEntradaAtualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntradaBuscarId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormPeixe_Load(object sender, EventArgs e)
        {
            CarregarExemploAtualizar();
            CarregarExemploBuscarId();
            CarregarExemploExcluir();
            CarregarExemploInserir();
        }
    }
}
