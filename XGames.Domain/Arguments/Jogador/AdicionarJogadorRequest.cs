using XGames.Domain.Interfaces.Arguments;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Arguments.Jogador
{
    public class AdicionarJogadorRequest : IRequest 
    {
        public Nome Nome { get; set; }

        public Email Email { get; set; }

        public string Senha { get; set; }
    }
}
