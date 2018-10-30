using XGames.Domain.Interfaces.Arguments;

namespace XGames.Domain.Arguments.Jogador
{
    public class AutenticarJogadorRequest : IRequest
    {
        public string Email { get; set; }

        public string Senha { get; set; }
    }
}
