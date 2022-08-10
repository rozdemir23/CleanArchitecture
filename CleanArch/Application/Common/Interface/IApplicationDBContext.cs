using Domain.Master;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IApplicationDBContext
    {
        DbSet<Depo> Depo { get; set; }        
        DbSet<Siparis> Siparis { get; set; }
        DbSet<Tedarik> Tedarik { get; set; }
        DbSet<Urun> Urun { get; set; }
        Task<int> SaveChangesAsync();
    }
}