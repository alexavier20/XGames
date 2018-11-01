using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using XGames.Domain.Entities;

namespace Infrastructure.Persistence
{
    public class XGameContext : DbContext
    {
        public XGameContext() : base("XgameConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public IDbSet<Jogador> Jogadores { get; set; }

        public IDbSet<Plataforma> Plataformas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Remove a pluralização dos nomes da tabela
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            //Remove exclusão em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            //Setar para usar varchar ao invés de nvarchar
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));

            //Caso não informe o tamanho do campo, irá inserir varchar de 100
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));

            //Adiciona entidades mapeadas - Automaticamente via Assembly
            modelBuilder.Configurations.AddFromAssembly(typeof(XGameContext).Assembly);

            base.OnModelCreating(modelBuilder);

        }
    }
}
