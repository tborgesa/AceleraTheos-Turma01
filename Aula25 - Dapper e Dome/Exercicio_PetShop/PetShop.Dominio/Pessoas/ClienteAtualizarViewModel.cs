using System;


namespace PetShop.Dominio.Pessoas
{
    public class ClienteAtualizarViewModel
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Endereco { get; set; } = "";
        public string Telefone { get; set; } = "";
    }
}
