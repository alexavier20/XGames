using System;

namespace XGames.Domain.Entities
{
    public class Jogo
    {
        public Guid id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Produtora { get; set; }

        public string Distribuidora { get; set; }

        public string Genero { get; set; }

        public string site { get; set; }
    }
}
