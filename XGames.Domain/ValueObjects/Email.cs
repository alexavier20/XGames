using prmToolkit.NotificationPattern;

namespace XGames.Domain.ValueObjects
{
    public class Email: Notifiable
    {
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this).IfNotEmail(x => x.Endereco, "Informe um email válido.");
        }

        public string Endereco { get; private set; }
    }
}
