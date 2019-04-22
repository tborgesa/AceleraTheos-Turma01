using AceleraPizza.Comum.Helpers;
using System;

namespace AceleraPizza.Dominio.Ingrediente
{
    public class Ingrediente : Entidade
    {
        public Ingrediente() { }

        public Ingrediente(string descricao, double valor)
        {
            Descricao = descricao;
            Valor = valor;
        }

        //TODO: O total seria um valor zerado para depois ser preenchido?
        public override Guid Id { get; set; }

        public override DateTime DataInsercao { get; set; }
        public override DateTime? DataAlteracao { get; set; }

        public string Descricao { get; set; }
        public double Valor{ get; set; }
    }
}
