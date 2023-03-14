using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ApiWebSqlServer.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }

        public DbSet<Produto> Produto { get; set; }

    }
}
