using System.Data.Entity;
using XGames.Domain.Entities;

namespace Infrastructure.Persistence
{
    public class XGameContext : DbContext
    {
        public XGameContext() : base("XgameConnectionsString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Jogador> Jogadores { get; set; }

        public IDbSet<Plataforma> Plataformas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
