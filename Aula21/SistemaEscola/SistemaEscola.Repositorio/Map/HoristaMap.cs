using Dapper.FluentMap.Dommel.Mapping;
using SistemaEscola.Dominio.Funcionario;

namespace SistemaEscola.Repositorio.Map
{
    public class HoristaMap : DommelEntityMap<Horista>
    {
        //Mapeamento das propriedades da classe
        public HoristaMap()
        {
            //ToTable("Horista"); Poderia ser caso fosse diferente.
            /*
             
             */
            ToTable("Horista");
            Map(col => col.Id).ToColumn("HoristaId").IsKey();
            //IsKey da informação que esta é a PK
            //Map(col => col.DataInsercao).ToColumn("DataInsercao");
        }
    }
}