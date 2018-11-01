using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using XGames.Domain.Entities;

namespace Infrastructure.Persistence.Map
{
    public class MapJogador : EntityTypeConfiguration<Jogador>
    {
        public MapJogador()
        {
            ToTable("TBL_Jogador");

            Property(p => p.Email.Endereco).HasMaxLength(200).IsRequired().HasColumnAnnotation("Index", new IndexAnnotation(new IndexAttribute("UK_JOGADOR_EMAIL") { IsUnique = true }));
            Property(p => p.Nome.PrimeiroNome).HasMaxLength(50).IsRequired().HasColumnName("PrimeiroNome");
            Property(p => p.Nome.UltimoNome).HasMaxLength(100).IsRequired().HasColumnName("UltimoNome");
            Property(p => p.Senha).IsRequired();
            Property(p => p.Status).IsRequired();
        }
    }
}
