using System;
using System.Collections.Generic;

namespace SistemaEscola.Dominio.Funcionario.Interfaces
{
    public interface IHoristaRepositorio
    {
        void Inserir(Horista horista);
        void Atualizar(Horista horista);
        void Excluir(Guid id);
        Horista BuscarPorId(Guid id);
        List<Horista> BuscarTodos();
    }
}