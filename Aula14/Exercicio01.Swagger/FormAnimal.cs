using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercicio01.Dominio.Animais;
using Newtonsoft.Json;

namespace Exercicio01.Swagger
{
    public partial class FormAnimal : Form
    {
        private CachorroService _serviceCachorro = new CachorroService();

        public FormAnimal()
        {
            InitializeComponent();
        }

        private void FormAnimal_Load(object sender, EventArgs e)
        {
            CarregarExemploInserirCachorro();

        }


        private void CarregarExemploInserirCachorro()
        {
            CachorroInserirViewModel CachorroViewModel = new CachorroInserirViewModel();
            string texto = JsonConvert.SerializeObject(CachorroViewModel);
            textBoxExemploInserirCachorro.Text = texto;
            textBoxEntradaInserirCachorro.Text = texto;
        }

        private void FormAnimal_Load_1(object sender, EventArgs e)
        {
            CarregarExemploInserirCachorro();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void buttonExecutarInserirCachorro_Click(object sender, EventArgs e)
        {
            try
            {
                var cachorroViewModel = JsonConvert.DeserializeObject<CachorroInserirViewModel>(textBoxEntradaInserirCachorro.Text);

                if (cachorroViewModel == null)
                {
                    textBoxEntradaInserirCachorro.Text = $"Json inválido.";
                    return;
                }

                var cahorroDto = _serviceCachorro.Inserir(fornecedorViewModel);

                textBoxSaidaInserirCachorro.Text = JsonConvert.SerializeObject(fornecedorDto);
            }
            catch (Exception ex)
            {
                textBoxSaidaInserirCachorro.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }
    }
}
