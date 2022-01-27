using bolao.api.Entities;
using bolao.api.Repository.Interface;
using bolao.api.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Service
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository participantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            this.participantRepository = participantRepository;
        }

        public void AddParticipant(Participant participant)
        {
            try
            {
                this.participantRepository.AddParticipant(participant);
                this.participantRepository.SaveChangesAsync();                    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteParticipant(int id)
        {
            try
            {
                var participant = await this.participantRepository.GetParticipantId(id);
                if (participant == null)
                    throw new Exception("Participante não encontrado!");

                this.participantRepository.DeleteParticipant(participant);
                this.participantRepository.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar excluir o participante. Erro: " + ex.Message);
            }
        }

        public async Task<Participant> GetParticipantId(int id)
        {
            try
            {
                var participant = this.participantRepository.GetParticipantId(id);

                if (participant == null)
                    return null;

                return await participant;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao retornar o Id: {id}. Erro: {ex.Message}");
            }

        }

        public async Task<List<Participant>> GetParticipants()
        {
            try
            {
                var participants = this.participantRepository.GetParticipants();

                if (participants == null)
                    return null;

                return await participants;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao retornar os participantes. Erro: {ex.Message}");
            }
        }

        public Task<List<Participant>> GetParticipants(string name)
        {
            throw new NotImplementedException();
        }

        public void UpDateParticipant(int id, Participant participant)
        {
            try
            {
                var _participant = this.participantRepository.GetParticipantId(id);
                if (participant != null)
                {
                    this.participantRepository.UpDateParticipant(participant);
                    this.participantRepository.SaveChangesAsync();
                }                 

            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao tentar atualizar os dados do participante! Erro: " + ex.Message);
            }
            
        }
    }
}
