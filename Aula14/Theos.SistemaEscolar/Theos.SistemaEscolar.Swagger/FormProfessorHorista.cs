using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theos.SistemaEscolar.Dominio.Professor;
using Theos.SistemaEscolar.Service;

namespace Theos.SistemaEscolar.Swagger
{
    public partial class FormProfessorHorista : Form
    {
        public FormProfessorHorista()
        {
            InitializeComponent();

            ProfessorHoristaViewModel professor = new ProfessorHoristaViewModel();
            professor.Nome = "gfbhdt";
            professor.Cpf = "07346153618";

            _service.Inserir(professor);


            professor = new ProfessorHoristaViewModel();
            professor.Nome = "hjjkfy";
            professor.Cpf = "07346153618";

            _service.Inserir(professor);


            professor = new ProfessorHoristaViewModel();
            professor.Nome = "bjcf";
            professor.Cpf = "07346153618";

            _service.Inserir(professor);


            professor = new ProfessorHoristaViewModel();
            professor.Nome = "gfbjkghhdt";
            professor.Cpf = "07346153618";

            _service.Inserir(professor);

            CarregarExemploId();
            CarregarExemploInserir();
            CarregarExemploAtualizar();
        }

        private ProfessorHoristaService _service = new ProfessorHoristaService();

        #region BuscarTodos
        private void btnBuscarTodosProfHorista_Click(object sender, EventArgs e)
        {
            try
            {
                List<ProfessorHoristaSearch> professorHorista = _service.BuscarTodos();

                txtBuscarTodosProfHorista.Text = JsonConvert.SerializeObject(professorHorista);
            }
            catch (Exception ex)
            {
                txtBuscarTodosProfHorista.Text = ex.ToString();
            }
        }
        #endregion

        #region BuscarPorId
        private void buttonExecutarIdProfHorista_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaBuscarIdProfHorista.Text;
                if (entrada == null)
                {
                    textBoxSaidaBuscarIdProfHorista.Text = "Id inválido";
                    return;
                }
                if (!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaBuscarIdProfHorista.Text = "Id inválido";
                    return;
                }

                var professorHorista = _service.BuscarPorId(guid);
                textBoxSaidaBuscarIdProfHorista.Text = JsonConvert.SerializeObject(professorHorista);

            }
            catch (Exception ex)
            {
                textBoxSaidaBuscarIdProfHorista.Text = ex.ToString();
            }

        }

        public void CarregarExemploId()
        {
            textBoxExemploIdProfHorista.Text = Guid.NewGuid().ToString();
            textBoxEntradaBuscarIdProfHorista.Text = Guid.NewGuid().ToString();
        }

        #endregion

        #region Inserir
        private void buttonExecutarInserirProfHorista_Click(object sender, EventArgs e)
        {
            try
            {
                var professorHorista = JsonConvert.DeserializeObject<ProfessorHoristaViewModel>(textBoxEntradaInserirProfHorista.Text);
                if (professorHorista == null)
                {
                    textBoxSaidaInserirProfHorista.Text = "Json inválido";
                    return;
                }

                var professorHoristaDto = _service.Inserir(professorHorista);
                textBoxSaidaInserirProfHorista.Text = JsonConvert.SerializeObject(professorHorista);


            }
            catch (Exception ex)
            {
                textBoxSaidaInserirProfHorista.Text = ex.ToString();
            }
        }


        public void CarregarExemploInserir()
        {
            ProfessorHoristaViewModel professorHoristaViewModel = new ProfessorHoristaViewModel();
            string texto = JsonConvert.SerializeObject(professorHoristaViewModel);
            textBoxExemploInserirProfHorista.Text = texto;
            textBoxEntradaInserirProfHorista.Text = texto;
        }

        #endregion

        #region Atualizar


        public void CarregarExemploAtualizar()
        {
            ProfessorHoristaViewModel professorHorista = new ProfessorHoristaViewModel();
            var texto = JsonConvert.SerializeObject(professorHorista);
            textBoxEntradaAtualizarProfHorista.Text = texto;
            textBoxExemploAtualizarProfHorista.Text = texto;
        }
        #endregion
    }
}
