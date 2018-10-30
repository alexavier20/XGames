using System;

namespace XGames.Domain.Entities
{
    public class MeuJogo
    {
        public Guid id { get; set; }   
        
        public JogoPlataforma JogoPlataforma { get; set; }

        public bool Desejo { get; set; }

        public bool Troco { get; set; }

        public bool Vendo { get; set; }

        public DateTime DataDesejada { get; set; }
    }
}
