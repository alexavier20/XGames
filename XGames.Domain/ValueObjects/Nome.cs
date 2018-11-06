using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using XGames.Domain.Resource;

namespace XGames.Domain.ValueObjects
{
    public class Nome : Notifiable
    {
        protected Nome()
        {

        }

        public Nome(string primeiroNome, string ultimoNome)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;

            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.PrimeiroNome, 3, 50,
                string.Format(Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES, "Primeiro nome", "3", "50"));

            new AddNotifications<Nome>(this).IfNullOrInvalidLength(x => x.UltimoNome, 3, 50,
                string.Format(Message.X0_E_OBRIGATORIO_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES, "Último nome", "3", "50"));
        }

        public string PrimeiroNome { get; private set; }

        public string UltimoNome { get; private set; }
    }
}
