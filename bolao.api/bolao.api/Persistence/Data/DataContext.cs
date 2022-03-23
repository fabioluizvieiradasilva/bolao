using bolao.api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bolao.api.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Participant> Participants { get; set; }
        public DbSet<Equipe> Equipes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Participant>(p =>
            {
                p.HasKey(p => p.IdParticipant);//Definindo chave primária
            });

            modelBuilder.Entity<Equipe>(p =>
            {
                p.HasKey(e => e.EquipeId);
            });
        }
    }
}
