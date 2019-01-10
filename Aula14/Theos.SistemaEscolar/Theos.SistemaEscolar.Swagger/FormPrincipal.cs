using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Theos.SistemaEscolar.Swagger
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void btnProfessorContratado_Click(object sender, EventArgs e)
        {
            FormProfessorContratado formProfessorContratado = new FormProfessorContratado();
            formProfessorContratado.ShowDialog();
        }

        private void btnProfessorHorista_Click(object sender, EventArgs e)
        {
            FormProfessorHorista formProfessorHorista = new FormProfessorHorista();
            formProfessorHorista.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                DateFormatString = "dd/MM/yyyy"

            };
        }
    }
}
