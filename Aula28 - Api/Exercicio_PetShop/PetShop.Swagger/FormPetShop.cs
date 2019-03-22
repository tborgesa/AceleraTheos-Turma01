using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Windows.Forms;

namespace PetShop.Swagger
{
    public partial class FormPrincipal : Form
    {

        private FormAnimal _formAnimal;
        private FormCliente _formCliente;

        public FormPrincipal(FormCliente formCliente, FormAnimal formAnimal)
        {
            _formCliente = formCliente;
            _formAnimal = formAnimal;
            InitializeComponent();
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            _formCliente.ShowDialog();
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

        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            _formAnimal.ShowDialog();
        }
    }
}
