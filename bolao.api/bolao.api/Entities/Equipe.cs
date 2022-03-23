using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Entities
{
    public class Equipe
    {
        [Key]
        public int EquipeId { get; set; }
        public string Nome { get; set; }
        public string Escudo { get; set; }

        public Equipe(string nome, string escudo)
        {
            Nome = nome;
            Escudo = escudo;
        }
    }
}
