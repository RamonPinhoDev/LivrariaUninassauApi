using LivrariaUninassau.Data.Map;
using LivrariaUninassau.Models;
using Microsoft.EntityFrameworkCore;

namespace LivrariaUninassau.Data
{
    public class LivrariaDBContext : DbContext

    {
        public LivrariaDBContext(DbContextOptions<LivrariaDBContext> options)
        : base(options) 
        {
        
        
       }
        public DbSet<EmprestimoModel> Emprestimo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmprestimoMap());
            base.OnModelCreating(modelBuilder);
        }

    }

}
