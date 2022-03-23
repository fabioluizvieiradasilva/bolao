using bolao.api.Entities;
using bolao.api.Persistence.Repository.Interface;
using bolao.api.Service.Interface;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bolao.api.Service
{
    public class EquipeService : IEquipeService
    {
        private readonly IEquipeRepository _equipeRepository;

        public EquipeService(IEquipeRepository equipeRepository)
        {
            _equipeRepository = equipeRepository;
        }

        public void AddEquipe(Equipe equipe)
        {
            try
            {
                _equipeRepository.AddEquipe(equipe);
            }
            catch (Exception e)
            {

                throw new Exception($"Erro ao tentar salvar a equipe. Erro: {e.Message}");
            }
            
        }

        public void DeleteEquipe(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Equipe>> GetEquipe()
        {
            throw new System.NotImplementedException();
        }

        public Task<Equipe> GetEquipeId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void SaveChangesAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpDateEquipe(int id, Equipe equipe)
        {
            throw new System.NotImplementedException();
        }
    }
}
