using bolao.api.Entities;
using bolao.api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Repository.Interface
{
    public interface IParticipantRepository : IDisposable
    {
        Task<List<Participant>> GetParticipants();        
        Task <Participant> GetParticipantId(int id);
        void AddParticipant(Participant participant);
        void UpDateParticipant(Participant participant);
        void DeleteParticipant(Participant participant);
        void SaveChangesAsync();

    }
}
