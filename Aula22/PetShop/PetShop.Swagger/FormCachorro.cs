using System;
using System.Windows.Forms;
using Newtonsoft.Json;
using PetShop.Dominio.Animal.Cachorro;
using PetShop.Service;

namespace PetShop.Swagger
{
    public partial class FormCachorro : Form
    {
        private CachorroService _service = new CachorroService();

        public FormCachorro()
        {
            InitializeComponent();
        }


        #region Inserir
        private void CarregarExemploInserir()
        {
            CachorroInserirViewModel cachorroViewModel = new CachorroInserirViewModel();
            string texto = JsonConvert.SerializeObject(cachorroViewModel);
            textBoxCachorroExemploInserir.Text = texto;
            textBoxCachorroEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var cachorroViewModel = JsonConvert.DeserializeObject<CachorroInserirViewModel>(textBoxCachorroEntradaInserir.Text);

                if (cachorroViewModel == null)
                {
                    textBoxCachorroSaidaInserir.Text = $"Json inválido.";
                    return;
                }

                var cachorroDto = _service.Inserir(cachorroViewModel);

                textBoxCachorroSaidaInserir.Text = JsonConvert.SerializeObject(cachorroDto);
            }
            catch (Exception ex)
            {
                textBoxCachorroSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
        #endregion

        #region BuscarTodos
        private void buttonBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var cachorroes = _service.BuscarTodos();
                textBoxBuscarTodos.Text = JsonConvert.SerializeObject(cachorroes);
            }
            catch (Exception ex)
            {
                textBoxCachorroSaidaInserir.Text = $"{ex.ToString()}";
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


                var cachorroDto = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(cachorroDto);
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
            CachorroAtualizarViewModel cachorroViewModel = new CachorroAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(cachorroViewModel);
            textBoxCachorroExemploAtualizar.Text = texto;
            textBoxCachorroEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                var cachorroViewModel = JsonConvert.DeserializeObject<CachorroAtualizarViewModel>(textBoxCachorroEntradaAtualizar.Text);

                if (cachorroViewModel == null)
                {
                    textBoxCachorroSaidaAtualizar.Text = $"Json inválido.";
                    return;
                }

                var cachorroDto = _service.Atualizar(cachorroViewModel);

                textBoxCachorroSaidaAtualizar.Text = JsonConvert.SerializeObject(cachorroDto);
            }
            catch (Exception ex)
            {
                textBoxCachorroSaidaAtualizar.Text = $"{ex.ToString()}";
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

        private void textBoxCachorroEntradaInserir_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxCachorroEntradaAtualizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEntradaBuscarId_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormCachorro_Load(object sender, EventArgs e)
        {
            CarregarExemploAtualizar();
            CarregarExemploBuscarId();
            CarregarExemploExcluir();
            CarregarExemploInserir();
        }
    }
}