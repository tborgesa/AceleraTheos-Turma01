using Dapper.FluentMap.Dommel.Mapping;
using SistemaEscola.Dominio.Funcionario;

namespace SistemaEscola.Repositorio.Map
{
    public class ContratadoMap : DommelEntityMap<Contratado>
    {
        //Mapeamento das propriedades da classe
        public ContratadoMap()
        {
            //ToTable("Contratado"); Poderia ser caso fosse diferente.
            /*
             
             */
            Map(col => col.Id).ToColumn("ContratadoId").IsKey();
            //IsKey da informação que esta é a PK
            //Map(col => col.DataInsercao).ToColumn("DataInsercao");
        }
    }
}