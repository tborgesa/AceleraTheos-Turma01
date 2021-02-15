﻿using System;
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

                var animalDtoReturn = _service.Inserir(animalViewModel);

                if(animalDtoReturn.Erros.Count > 0)
                {
                    textBoxStatusCodeInserir.Text = "400 - Bad Request.";
                    textBoxSaidaInserir.Text = JsonConvert.SerializeObject(animalDtoReturn.Erros);
                    return;
                }

                textBoxStatusCodeInserir.Text = "200 - Sucess.";
                textBoxSaidaInserir.Text = JsonConvert.SerializeObject(animalDtoReturn.Animal);

            }

            catch (Exception ex)
            {
                textBoxStatusCodeInserir.Text = "500 - Internal Server Error.";
                textBoxSaidaInserir.Text = $"{Environment.NewLine} {ex.ToString()}";
            }
        }

        #endregion

        #region BuscarTodos

        private void buttonExecutarBuscarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                //fazer o buscar todos
            }
            catch (Exception ex)
            {
                textBoxBuscarTodos.Text = $"{ex.ToString()}";
            }
        }

        #endregion

        #region BuscarPorId


        #endregion
    }
}
