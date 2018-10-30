using System;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Arguments.Plataforma;

namespace XGames.Domain.Interfaces.Services
{
    public interface IServicePlataforma
    {        
        AdicionarPlataformaResponse Adicionar(AdicionarPlataformaRequest request);
    }
}
