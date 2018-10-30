using System;

namespace XGames.Domain.Arguments.Jogador
{
    public class AlterarJogadorResponse
    {
        public Guid id { get; set; }

        public string PrimeiroNome { get; set; }

        public string UltimoNome { get; set; }

        public string Message { get; set; }

        public string Email { get; set; }

        public static explicit operator AlterarJogadorResponse(Entities.Jogador entidade)
        {
            return new AlterarJogadorResponse()
            {
                Email = entidade.Email.Endereco,
                id = entidade.id,
                PrimeiroNome = entidade.Nome.PrimeiroNome,
                UltimoNome = entidade.Nome.UltimoNome,
                Message = XGames.Domain.Resource.Message.OPERACAO_REALIZADA_COM_SUCESSO,
            };
        }
    }
}
