using System.Data.Entity.ModelConfiguration;
using XGames.Domain.Entities;

namespace Infrastructure.Persistence.Map
{
    public class MapPlataforma : EntityTypeConfiguration<Plataforma>
    {
        public MapPlataforma()
        {
            ToTable("TBL_Plataforma");
           
            Property(p => p.Nome).HasMaxLength(50).IsRequired();           
        }
    }
}
