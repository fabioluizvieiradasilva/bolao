using bolao.api.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace bolao.api.Service.Interface
{
    public interface IEquipeService
    {
        Task<List<Equipe>> GetEquipe();
        Task<Equipe> GetEquipeId(int id);
        void AddEquipe(Equipe equipe);
        void UpDateEquipe(int id, Equipe equipe);
        void DeleteEquipe(int id);
        void SaveChangesAsync();
    }
}
