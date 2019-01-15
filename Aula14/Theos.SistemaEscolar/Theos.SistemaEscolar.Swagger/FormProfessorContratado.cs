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
    public partial class FormProfessorContratado : Form
    {
        public FormProfessorContratado()
        {
            InitializeComponent();
        }

        private ProfessorContratadoService _service = new ProfessorContratadoService();

        private void FormProfessorContratado_Load(object sender, EventArgs e)
        {
            CarregarExemploInserir();
            CarregarExemploBuscarId();
            CarregarExemploAtualizar();
            CarregarExemploExcluir();
        }

        #region Inserir
        private void CarregarExemploInserir()
        {
            ProfessorContratadoInserirViewModel professorContratadoViewModel = new ProfessorContratadoInserirViewModel();
            string texto = JsonConvert.SerializeObject(professorContratadoViewModel);
            textBoxExemploInserir.Text = texto;
            textBoxEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var professorContratadoViewModel = JsonConvert.DeserializeObject<ProfessorContratadoInserirViewModel>(textBoxEntradaInserir.Text);

                if (professorContratadoViewModel == null)
                {
                    textBoxEntradaInserir.Text = $"Json inválido";
                    return;
                }

                var professorContratadoDto = _service.Inserir(professorContratadoViewModel);

                textBoxSaidaInserir.Text = JsonConvert.SerializeObject(professorContratadoDto);
            }
            catch (Exception ex)
            {
                textBoxSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }

        }

        #endregion

        #region BuscarTodos
        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                var professoresContratados = _service.BuscarTodos();
                txtBuscarTodos.Text = JsonConvert.SerializeObject(professoresContratados);
            }

            catch (Exception ex)
            {
                txtBuscarTodos.Text = $"{ex.ToString()}";
            }
        }

        #endregion

        #region BuscarPorId

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
                    textBoxSaidaBuscarId.Text = "Id inválido";
                    return;
                }

                if (!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaBuscarId.Text = "Id inválido";
                    return;
                }
                var professorContratado = _service.BuscarPorId(guid);
                textBoxSaidaBuscarId.Text = JsonConvert.SerializeObject(professorContratado);
            }
            catch (Exception ex)
            {
                textBoxSaidaBuscarId.Text = $"{ex.ToString()}";
            }
        }

        #endregion

        #region Atualizar
        public void CarregarExemploAtualizar()
        {
            ProfessorContratadoAtualizarViewModel professorContratadoViewModel = new ProfessorContratadoAtualizarViewModel();
            string texto = JsonConvert.SerializeObject(professorContratadoViewModel);
            textBoxExemploAtualizar.Text = texto;
            textBoxEntradaAtualizar.Text = texto;
        }

        private void buttonAtualizar_Click(object sender, EventArgs e)
        {
         
            try
            {
                var professorContratadoViewModel = JsonConvert.DeserializeObject<ProfessorContratadoAtualizarViewModel>(textBoxEntradaAtualizar.Text);
                if (professorContratadoViewModel == null)
                {
                    textBoxSaidaAtualizar.Text = $"Id inválido";
                    return;    
                }
             
                var professorContratatoDto = _service.Atualizar(professorContratadoViewModel);
                textBoxSaidaAtualizar.Text = JsonConvert.SerializeObject(professorContratatoDto);
            }
            catch(Exception ex)
            {
                textBoxSaidaAtualizar.Text = $"{ex.Message}";
            }
        }

        #endregion

        #region Excluir
        public void CarregarExemploExcluir()
        {
            textBoxExemploExcluir.Text = Guid.NewGuid().ToString();
            textBoxEntradaExcluir.Text = Guid.NewGuid().ToString();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                var entrada = textBoxEntradaExcluir.Text;
                if(entrada == null)
                {
                    textBoxSaidaExcluir.Text = "Id inválido";
                    return;
                }
                if(!Guid.TryParse(entrada, out Guid guid))
                {
                    textBoxSaidaExcluir.Text = "Id inválido";
                    return;
                }

                _service.Excluir(guid);
                textBoxSaidaExcluir.Text = "Excluído com sucesso";
            }
            catch(Exception ex)
            {
                textBoxSaidaExcluir.Text = $"{ex.Message}";
            }
        }


        #endregion


    }
}
