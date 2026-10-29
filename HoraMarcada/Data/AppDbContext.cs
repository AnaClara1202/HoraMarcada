using Microsoft.EntityFrameworkCore;
using HoraMarcada.Models;

namespace HoraMarcada.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Essa é a tabela que nascerá no MySQL
        public DbSet<Agendamento> Agendamentos { get; set; }
    }
}

