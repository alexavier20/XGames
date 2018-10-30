using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Entities;
using XGames.Domain.Enum;
using XGames.Domain.Interfaces.Repositories;
using XGames.Domain.Interfaces.Services;
using XGames.Domain.Resource;
using XGames.Domain.ValueObjects;

namespace XGames.Domain.Services
{
    public class ServiceJogador : Notifiable, IServiceJogador
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public ServiceJogador(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        public ServiceJogador()
        {
        }

        public AdicionarJogadorResponse AdicionarJogador(AdicionarJogadorRequest request)
        {
            if (request == null)
                AddNotification("AlterarJogadorRequest", string.Format(Message.X0_OBRIGATORIO, "AlterarJogadorRequest"));

            Nome nome = new Nome(request.Nome.PrimeiroNome, request.Nome.UltimoNome);
            Email email = new Email(request.Email.Endereco);

            Jogador jogador = new Jogador(nome, email, request.Senha);

            AddNotifications(nome, jogador, email);

            if (this.IsInvalid())
                return null;

            jogador = _repositoryJogador.AdicionarJogador(jogador);
            return (AdicionarJogadorResponse)jogador;
        }

        public AutenticarJogadorResponse Autenticar(AutenticarJogadorRequest request)
        {
            if (request == null)
                AddNotification("AutenticarJogadorRequest", string.Format(Message.X0_OBRIGATORIO, "AutenticarJoadorRequest"));

            Email email = new Email(request.Email);
            Jogador jogador = new Jogador(email, request.Senha);

            AddNotifications(jogador, email);

            if (jogador.IsInvalid())
                return null;

            jogador = _repositoryJogador.Autenticar(request);

            return (AutenticarJogadorResponse)jogador;
        }

        public AlterarJogadorResponse AlterarJogador(AlterarJogadorRequest request)
        {
            if (request == null)
                AddNotification("AlterarJogadorRequest", string.Format(Message.X0_OBRIGATORIO, "AlterarJogadorRequest"));

            Jogador jogador = _repositoryJogador.ObterJogadorPorId(request.id);

            if (jogador == null)
            {
                AddNotification("id", Message.DADOS_NAO_FORAM_ENCONTRADOS);
                return null;
            }

            var nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            var email = new Email(request.Email);

            jogador.AlterarJogador(nome, email);

            AddNotifications(jogador);

            if (this.IsInvalid())
                return null;

            _repositoryJogador.AlterarJogador(jogador);
           
            return (AlterarJogadorResponse)jogador;
        }

        public IEnumerable<JogadorResponse> ListarJogador()
        {
            return _repositoryJogador.ListarJogador().ToList().Select(j => (JogadorResponse)j).ToList();
        }
        
    }
}
