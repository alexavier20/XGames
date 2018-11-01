using System;
using System.Collections.Generic;
using XGames.Domain.Arguments.Base;
using XGames.Domain.Arguments.Jogador;

namespace XGames.Domain.Interfaces.Services
{
    public interface IServiceJogador
    {
        AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request);

        AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request);

        AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request);

        IEnumerable<JogadorResponse> ListarJogador();

        ResponseBase ExcluirJogador(Guid id);
    }
}
