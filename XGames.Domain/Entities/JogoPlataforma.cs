using System;

namespace XGames.Domain.Entities
{
    public class JogoPlataforma
    {
        public Guid id { get; set; }

        public Jogo Jogo { get; set; }

        public Plataforma Plataforma { get; set; }

        public DateTime DataLancamento { get; set; }
    }
}
