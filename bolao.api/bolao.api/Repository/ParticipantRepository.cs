using bolao.api.Data;
using bolao.api.Entities;
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
        private readonly DataContext context;

        public ParticipantRepository(DataContext context)
        {
            this.context = context;
        }

        public void AddParticipant(Participant participant)
        {
            this.context.Add(participant);
        }

        public void DeleteParticipant(Participant participant)
        {
            this.context.Remove(participant);
        }

        public void Dispose()
        {
            this.context?.Dispose();
        }

        public async Task<Participant> GetParticipantId(int id)
        {
            var participant = this.context.Participants.AsNoTracking()
                .Where(p => p.IdParticipant == id);
            
            if (participant == null)
                return null;

            return await participant.FirstOrDefaultAsync();
        }

        public async Task<List<Participant>> GetParticipants()
        {
            var participants = this.context.Participants.AsNoTracking();

            if (participants.Count() == 0)
                return null;

            return await participants.ToListAsync();
        }

        public Task<List<Participant>> GetParticipants(string name)
        {
            throw new NotImplementedException();
        }

        public void SaveChangesAsync()
        {
            this.context.SaveChangesAsync();
        }

        public void UpDateParticipant(Participant participant)
        {
            this.context.Update(participant);
        }
    }
}
