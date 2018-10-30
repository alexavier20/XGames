using System;
using System.Collections.Generic;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Entities;

namespace XGames.Domain.Interfaces.Repositories
{
    public interface IRepositoryJogador
    {
        Jogador Autenticar(AutenticarJogadorRequest request);

        Jogador AdicionarJogador(Jogador jogador);

        IEnumerable<Jogador> ListarJogador();

        Jogador ObterJogadorPorId(Guid id);

        void AlterarJogador(Jogador jogador);
    }
}
