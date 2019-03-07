using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Windows.Forms;

namespace UaiQueijos.Swagger
{
    public partial class FormPrincipal : Form
    {
        private FormFornecedor _formFornecedor;

        public FormPrincipal(FormFornecedor formFornecedor)
        {
            _formFornecedor = formFornecedor;
            InitializeComponent();
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            _formFornecedor.ShowDialog();
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
