using Dapper.FluentMap.Dommel.Mapping;
using AceleraPizza.Dominio.Ingrediente;

namespace AceleraPizza.Repositorio.Map
{
    public class IngredienteMap : DommelEntityMap<Ingrediente>
    {
        //Mapeamento das propriedades da classe
        public IngredienteMap()
        {
            ToTable("INGREDIENTE");
            Map(col => col.Id).ToColumn("IdIngrediente").IsKey();
            //IsKey da informação que esta é a PK
            Map(col => col.DataInsercao).Ignore();
            Map(col => col.DataAlteracao).Ignore();

        }
    }
}