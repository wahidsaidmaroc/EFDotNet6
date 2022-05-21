using DAL.Model;
using Microsoft.EntityFrameworkCore;


namespace DAL
{
    public class contextCommande : DbContext
    {

        private const string connectionString = @"Server=localhost\SQLExpress;Database=EFDotNet;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet<Etudiant>? etudiants { get; set; }
    }
}
