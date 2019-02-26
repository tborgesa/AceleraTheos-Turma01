using Dapper.FluentMap.Dommel.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Theos.SistemaEscolar.Dominio.Professor;

namespace Theos.SistemaEscolar.Repositorio.Map
{
    public class ProfessorContratatoMap : DommelEntityMap<ProfessorContratado>
    {
        public ProfessorContratatoMap()
        {
            ToTable("PROFESSORCONTRATADO");
            Map(col => col.Id).ToColumn("IDPROFESSORCONTRATADO").IsKey();
        }
    }
}
