using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace APIDrugovich.Models
{
    public class ClienteContext : DbContext
    {
        public ClienteContext(DbContextOptions<ClienteContext> options) : base(options)
        {
        }

        public DbSet<Clientes> Clientes {get; set;} = null!;
    }
}
