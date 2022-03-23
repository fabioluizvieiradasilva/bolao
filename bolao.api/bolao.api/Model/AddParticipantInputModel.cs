using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Model
{
    public record AddParticipantInputModel(
        string Name,
        string Photo,
        string Surname
        )
    {
    }
}
