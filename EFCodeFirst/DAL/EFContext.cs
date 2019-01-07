using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using EFCodeFirst.Models;

namespace EFCodeFirst.DAL
{
    /*Data Acess Layer - Camada de acesso a dados*/
    public class EFContext : DbContext
    {
        public EFContext() : base("EFConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Universidade> Universidades { get; set; }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Aluno> Alunos { get; set; }
    }
}
