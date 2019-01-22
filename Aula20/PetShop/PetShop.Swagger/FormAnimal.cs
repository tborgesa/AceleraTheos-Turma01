using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace PetShop.Swagger
{
    public partial class FormAnimal : Form
    {
        public FormAnimal()
        {
            InitializeComponent();
        }

        private void buttonCachorro_Click(object sender, EventArgs e)
        {
            FormCachorro formCachorro = new FormCachorro();
            formCachorro.ShowDialog();
        }

        private void buttonGato_Click(object sender, EventArgs e)
        {
            FormGato formGato = new FormGato();
            formGato.ShowDialog();
        }

        private void buttonPeixe_Click(object sender, EventArgs e)
        {
            FormPeixe formPeixe = new FormPeixe();
            formPeixe.ShowDialog();
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

        private void FormAnimal_Load(object sender, EventArgs e)
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
