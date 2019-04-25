using System;

namespace AceleraPizza.Dominio.Ingrediente.Interfaces
{
    public interface IIngredienteRepositorio
    {
        void Inserir(Ingrediente cliente);
        void Atualizar(Ingrediente cliente);
        void Excluir(Guid id);
        Ingrediente BuscarPorId(Guid id);
    }
}
