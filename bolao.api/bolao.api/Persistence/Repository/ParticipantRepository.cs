using bolao.api.Data;
using bolao.api.Entities;
using bolao.api.Model;
using bolao.api.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Repository
{
    public class ParticipantRepository : IParticipantRepository
    {
        private readonly DataContext _context;

        public ParticipantRepository(DataContext context)
        {
            _context = context;
        }

        public void AddParticipant(Participant participant)
        {
            _context.Participants.Add(participant);
            _context.SaveChangesAsync();
        }

        public void DeleteParticipant(Participant participant)
        {
            _context.Participants.Remove(participant);
            _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public Task<Participant> GetParticipantId(int id)
        {
            var participant = _context.Participants.AsNoTracking()
                .Where(p => p.IdParticipant == id);
            
            if (participant == null)
                return null;

            return participant.FirstOrDefaultAsync();
        }

        public async Task<List<Participant>> GetParticipants()
        {
            var participants = _context.Participants.AsNoTracking();

            if (participants.Count() == 0)
                return null;

            return await participants.ToListAsync();
        }  

        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }

        public void UpDateParticipant(Participant participant)
        {
            _context.Participants.Update(participant);
            _context.SaveChangesAsync();
        }
    }
}
