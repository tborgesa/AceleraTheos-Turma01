using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.Dominio.Animais.Interfaces
{
    public interface IAnimalRepositorio
    {
        void Inserir(Animal animal);
        List<Animal> BuscarTodos();
        void Atualizar(Animal animal);
        void Excluir(Guid id);
    }
}
