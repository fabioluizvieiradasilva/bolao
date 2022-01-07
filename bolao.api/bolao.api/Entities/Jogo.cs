using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Entities
{
    public class Jogo
    {
        public Guid Id { get; set; }
        public Guid EquipeCasa { get; set; }        
        public Guid EquipeVisitante { get; set; }
        public Equipe Equipe { get; set; }
        public int PlacarEquipeCasa { get; set; }
        public int PlacarEquipeVisitante { get; set; }
        public int Rodada { get; set; }
    }
}
