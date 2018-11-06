using System;
using XGames.Domain.Interfaces.Arguments;

namespace XGames.Domain.Arguments.Jogador
{
    public class AdicionarJogadorResponse : IResponse
    {
        public Guid id { get; set; }

        public string Message { get; set; }

        public static explicit operator AdicionarJogadorResponse(Entities.Jogador entidade)
        {
            return new AdicionarJogadorResponse()
            {
                id = entidade.id,
                Message = Resource.Message.OPERACAO_REALIZADA_COM_SUCESSO

            };
        }
    }
}
