using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Entities
{
    public class Participant
    {
        public Participant(string name, string photo, string surname)
        {
            Name = name;
            Photo = photo;
            Surname = surname;
        }

        [Key]
        public int IdParticipant { get; private set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        [MaxLength(50, ErrorMessage ="Quantidade máxima de caracter é 50")]
        [MinLength(5, ErrorMessage = "Quantidade minima de caracter é 5")]
        public string Name { get;  set; }

        [Required(ErrorMessage = "Esse campo é obrigatório")]
        public string Photo { get;  set; }

        [MaxLength(50, ErrorMessage = "Quantidade máxima de caracter é 50")]
        [MinLength(5, ErrorMessage = "Quantidade minima de caracter é 5")]
        public string Surname { get;  set; }
    }
}
