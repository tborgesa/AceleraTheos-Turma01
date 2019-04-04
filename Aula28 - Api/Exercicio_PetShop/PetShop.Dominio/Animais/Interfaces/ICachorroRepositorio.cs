using System;
using System.Collections.Generic;

namespace PetShop.Dominio.Animais.Interfaces
{
    public interface ICachorroRepositorio
    {
        void Inserir(Cachorro cachorro);
        Cachorro BuscarPorId(Guid id);
        List<Cachorro> BuscarTodos();
        void Atualizar(Cachorro cachorro);
        void Excluir(Guid id);
    }
}
