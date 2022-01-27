using bolao.api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Service.Interface
{
    public interface IParticipantService
    {
        Task<List<Participant>> GetParticipants();
        Task<List<Participant>> GetParticipants(string name);
        Task<Participant> GetParticipantId(int id);
        void AddParticipant(Participant participant);
        void UpDateParticipant(int id, Participant participant);
        Task DeleteParticipant(int id);
    }
}
