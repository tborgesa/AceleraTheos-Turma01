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
using PetShop.Dominio.Animais;
using PetShop.Service;

namespace PetShop.Swagger
{
    public partial class FormAnimal : Form
    {
        private AnimalService _service = new AnimalService();

        public FormAnimal()
        {
            InitializeComponent();
        }

        private void FormAnimal_Load(object sender, EventArgs e)
        {
            CarregarExemploInserir();
        }

        #region Inserir
        private void CarregarExemploInserir()
        {
            AnimalInserirViewModel animalViewModel = new AnimalInserirViewModel();
            string texto = JsonConvert.SerializeObject(animalViewModel);
            textBoxExemploInserir.Text = texto;
            textBoxEntradaInserir.Text = texto;
        }

        private void buttonExecutarInserir_Click(object sender, EventArgs e)
        {
            try
            {
                var animalViewModel = JsonConvert.DeserializeObject<AnimalInserirViewModel>(textBoxEntradaInserir.Text);

                if (animalViewModel == null)
                {
                    textBoxStatusCodeInserir.Text = "400 - Bad Request.";
                    textBoxSaidaInserir.Text = "Jso inválido.";
                    return;
                }

                //continuar aqui
                var animalDtoReturn = _service.IdentificarEspecie(animalViewModel);

            }

            catch (Exception ex)
            {

            }
        }

        #endregion
    }
}
