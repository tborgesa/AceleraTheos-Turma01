using Dapper.FluentMap.Dommel.Mapping;
using UaiQueijos.Dominio.Fornecedor;

namespace UaiQueijos.Repositorio.Map
{
    public class FornecedorMap : DommelEntityMap<Fornecedor>
    {
        public FornecedorMap()
        {
            ToTable("Fornecedor");
            Map(col => col.Id).ToColumn("FornecedorId").IsKey();
            //Map(col => col.DataInsercao).ToColumn("DataInsercao");
        }
    }
}