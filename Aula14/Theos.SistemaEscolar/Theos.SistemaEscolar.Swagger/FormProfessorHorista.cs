using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Theos.SistemaEscolar.Service;

namespace Theos.SistemaEscolar.Swagger
{
    public partial class FormProfessorHorista : Form
    {
        public FormProfessorHorista()
        {
            InitializeComponent();
        }

        private ProfessorHoristaService _service = new ProfessorHoristaService();

        private void btnBuscarTodosProfHorista_Click(object sender, EventArgs e)
        {

        }
    }
}
