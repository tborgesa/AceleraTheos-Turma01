using System;

namespace PetShop.Dominio.Pessoas
{
    public class ClienteDto
    {
        public Guid Id { get; set; }
        public string Nome { get; }
        public string Telefone { get;  set; }
        public string Endereco { get;  set; }
    }
}
