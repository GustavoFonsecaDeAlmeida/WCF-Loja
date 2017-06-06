using Loja.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DAO
{
  public class Context : DbContext
    {
        public Context () : base("DefaultConnection")
        {
            Database.SetInitializer<Context>(
                new CreateDatabaseIfNotExists<Context>());

            Database.Initialize(false);

        }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

       
    }
}
