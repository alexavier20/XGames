using System;
using System.Text;
using XGames.Domain.Entities;

namespace XGames.Domain.Arguments.Jogador
{
    public class JogadorResponse
    {
        public Guid id { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string NomeCompleto { get; set; }

        public string Email { get; set; }

        public string Status { get; set; }

        public static explicit operator JogadorResponse(Entities.Jogador entidade)
        {
            StringBuilder sb = new StringBuilder();

            return new JogadorResponse()
            {
                Email = entidade.Email.Endereco,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                UltimoNome = entidade.Nome.UltimoNome,
                NomeCompleto = sb.Append(entidade.Nome.PrimeiroNome).Append(" ").Append(entidade.Nome.UltimoNome).ToString(),
                id = entidade.id,
                //Status = entidade.Status.ToString(),

            };
        }
    }
}
