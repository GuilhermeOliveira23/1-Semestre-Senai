using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Infra
{
    //a classe Context conecta o projeto com banco de dados
    public class Context : DbContext
    {
        // interage com o banco de dados
        public Context()
        {
            
        }
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DESKTOP-0V6T39T; initial catalog = gamerTarde; User Id=sa; pwd=Senai@134; TrustServerCertificate = true ");
            }
        }
        public DbSet<Jogador> Jogador {get ; set;}
        public DbSet<Equipe> Equipe {get ; set;}

    }
}