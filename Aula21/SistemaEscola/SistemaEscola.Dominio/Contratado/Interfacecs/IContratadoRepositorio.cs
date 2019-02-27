using System;
using System.Collections.Generic;

namespace SistemaEscola.Dominio.Funcionario.Interfaces
{
    public interface IContratadoRepositorio
    {
        void Inserir(Contratado contratado);
        void Atualizar(Contratado contratado);
        void Excluir(Guid id);
        Contratado BuscarPorId(Guid id);
        List<Contratado> BuscarTodos();
    }
}