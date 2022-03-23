using bolao.api.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bolao.api.Persistence.Repository.Interface
{
    public interface IEquipeRepository : IDisposable
    {
        Task<List<Equipe>> GetEquipe();
        Task<Equipe> GetEquipeId(int id);
        void AddEquipe(Equipe equipe);
        void UpDateEquipe(Equipe equipe);
        void DeleteEquipe(Equipe equipe);
        void SaveChangesAsync();
    }
}
