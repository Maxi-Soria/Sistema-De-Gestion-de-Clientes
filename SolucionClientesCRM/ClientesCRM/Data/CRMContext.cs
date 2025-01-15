using ClientesCRM.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientesCRM.Data
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        // Si más adelante agregas Oportunidad, Transaccion, etc., las incluyes aquí.
        // public DbSet<Oportunidad> Oportunidades { get; set; }
        // public DbSet<Transaccion> Transacciones { get; set; }
    }
}
