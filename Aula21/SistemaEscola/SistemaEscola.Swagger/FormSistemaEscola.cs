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

namespace SistemaEscola.Swagger
{
    public partial class FormSistemaEscola : Form
    {
        public FormSistemaEscola()
        {
            InitializeComponent();
        }

        private void buttonContratado_Click(object sender, EventArgs e)
        {
            FormContratado formContratado = new FormContratado();
            formContratado.ShowDialog();
        }

        private void buttonHorista_Click(object sender, EventArgs e)
        {
            FormHorista formHorista = new FormHorista();
            formHorista.ShowDialog();
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

        private void FormSistemaEscola_Load(object sender, EventArgs e)
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
