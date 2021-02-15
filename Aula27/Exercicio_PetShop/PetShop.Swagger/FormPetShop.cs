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

namespace PetShop.Swagger
{
    public partial class FormPrincipal : Form
    {
        private FormCliente _formCliente;
        private FormAnimal _formAnimal;


        public FormPrincipal(FormCliente formCliente, FormAnimal formAnimal)
        {
            _formCliente = formCliente;
            _formAnimal = formAnimal;
            InitializeComponent();
        }

        private void ButtonCliente_Click(object sender, EventArgs e)
        {
            _formCliente.ShowDialog();
        }

        private void buttonAnimal_Click(object sender, EventArgs e)
        {
            _formAnimal.ShowDialog();
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
