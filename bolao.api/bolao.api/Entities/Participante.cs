using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Entities
{
    public class Participante
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; }
        public string Apelido { get; set; }
    }
}
