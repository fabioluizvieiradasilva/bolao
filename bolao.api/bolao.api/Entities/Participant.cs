using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Entities
{
    public class Participant
    {
        [Key]
        public int IdParticipant { get; set; }
        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Name { get; set; }
        public string Photo { get; set; }
        public string Surname { get; set; }
    }
}
