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

namespace Exercicio01.Swagger
{
    public partial class SwaggerPetShop : Form
    {
        public SwaggerPetShop()
        {
            InitializeComponent();
        }

        private void buttonInserirAnimal_Click(object sender, EventArgs e)
        {
            FormAnimal formAnimal = new FormAnimal();
            formAnimal.ShowDialog();
        }

        private void SwaggerPetShop_Load(object sender, EventArgs e)
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
