using bolao.api.Data;
using bolao.api.Entities;
using bolao.api.Persistence.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Persistence.Repository
{
    public class EquipeRepository : IEquipeRepository
    {
        private readonly Data.DataContext _context;

        public EquipeRepository(DataContext context)
        {
            _context = context;
        }

        public void AddEquipe(Equipe equipe)
        {
            try
            {
                _context.Equipes.Add(equipe);
                _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao tentar salvar a equipe. {e.Message}");
            }
            
        }

        public void DeleteEquipe(Equipe equipe)
        {
            try
            {
                _context.Equipes.Remove(equipe);
                _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new Exception($"Erro ao tentar remover a equipe. {e.Message}");
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task<List<Equipe>> GetEquipe()
        {
            try
            {
                var equipes = _context.Equipes.AsNoTracking();
                if(equipes.Count() == 0)
                    return null;

                return await equipes.ToListAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao retornar as equipes. Erro: {e.Message}");
            }
        }

        public async Task<Equipe> GetEquipeId(int id)
        {
            try
            {
                var equipe = _context.Equipes.AsNoTracking()
                    .Where(e => e.EquipeId == id);
                if (equipe.Count() == 0)
                    return null;

                return await equipe.FirstOrDefaultAsync();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro ao retornar a equipe. Erro: {e.Message}");
            }
        }

        public void SaveChangesAsync()
        {
            _context.SaveChangesAsync();
        }

        public void UpDateEquipe(Equipe equipe)
        {
            try
            {
                _context.Equipes.Update(equipe);
                _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new Exception($"Erro ao atualizar e equipe. Erro: {e.Message}");
            }
        }
    }
}
