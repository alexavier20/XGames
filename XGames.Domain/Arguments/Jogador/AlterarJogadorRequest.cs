using System;

namespace XGames.Domain.Arguments.Jogador
{
    public class AlterarJogadorRequest
    {
        public Guid id { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }      

        public string Email { get; set; }
       
    }
}
