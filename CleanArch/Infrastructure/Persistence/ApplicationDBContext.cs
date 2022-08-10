using Application.Common.Interfaces;
using Domain.Master;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Persistence
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }



        #region DbSet
        public DbSet<Depo> Depo { get; set; }
        public DbSet<Siparis> Siparis { get; set; }
        public DbSet<Tedarik> Tedarik { get; set; }
        public DbSet<Urun> Urun { get; set; }
        #endregion
        #region Methods
        public Task<int> SaveChangesAsync()
        {
            return base.SaveChangesAsync();
        }
        #endregion

    }
}