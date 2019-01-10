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

        }

        #region Inserir
        private void CarregarExemploInserir()
        {
            ProfessorContratadoInserirViewModel professorContratadoViewModel = new ProfessorContratadoInserirViewModel();
            string texto = JsonConvert.SerializeObject(professorContratadoViewModel);


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

            catch(Exception ex)
            {
                txtBuscarTodos.Text = $"{ex.ToString()}";
            }
        }

        #endregion
    }
}
