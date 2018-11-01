using System;
using XGames.Domain.Enum;
using XGames.Domain.ValueObjects;
using prmToolkit.NotificationPattern;
using XGames.Domain.Resource;
using XGames.Domain.Externsions;
using XGames.Domain.Entities.Base;

namespace XGames.Domain.Entities
{
    public class Jogador : EntityBase
    {
        public Jogador(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            new AddNotifications<Jogador>(this).IfNullOrEmptyOrInvalidLength(x => x.Senha, 6, 32, "A senha deve ter entre 6 e 32 caracteres.");
        }

        public Jogador(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;            
            Status = EnumStatusJogador.EmAndamento;

            new AddNotifications<Jogador>(this).IfNullOrInvalidLength(x => x.Senha, 6, 32,
                string.Format(Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES, "Senha", "6", "32"));

            if (IsValid())
                senha = senha.ConvertToMD5();

            AddNotifications(nome, email);
        }

       // public Guid id { get; private set; }

        public Nome Nome { get; private set; }

        public Email Email { get; private set; }

        public string Senha { get; private set; }

        public EnumStatusJogador Status { get; private set; }

        public void AlterarJogador(Nome nome, Email email)
        {
            Nome = nome;
            Email = email;
           
            AddNotifications(nome, email);
        }
    }
}
