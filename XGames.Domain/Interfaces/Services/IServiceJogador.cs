using System;
using System.Collections.Generic;
using XGames.Domain.Arguments.Base;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Interfaces.Services.Base;

namespace XGames.Domain.Interfaces.Services
{
    public interface IServiceJogador : IServiceBase
    {
        AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);

        IEnumerable<JogadorResponse> ListarJogador();

        ResponseBase ExcluirJogador(Guid id);
    }
}
