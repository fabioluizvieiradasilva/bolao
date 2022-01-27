using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Entities
{
    public class Aposta
    {
        public Guid Id { get; set; }
        public int IdParticipant { get; set; }
        public Participant Participant { get; set; }
        public int JogoId { get; set; }
        public Jogo Jogo { get; set; }
        public int PlacarEquipeCasa { get; set; }
        public int PlacarEquipeVisitante{ get; set; }
        public bool AcertoPlacar { get; set; }
        public bool AcertoVitoria { get; set; }
        public bool AcertoOusadia { get; set; }
    }
}
