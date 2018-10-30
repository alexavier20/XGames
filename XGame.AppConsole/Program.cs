using System;
using System.Linq;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Services;
using XGames.Domain.ValueObjects;

namespace XGame.App.AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inciando...");
            Console.WriteLine("");

            var service = new ServiceJogador();            

            var request = new AdicionarJogadorRequest();
            
            Console.WriteLine("Primeiro Nome:");
            string primeiroNome = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Ultimo Nome:");
            string ultimoNome = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("E-mail:");
            string enderecoEmail = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Senha:");
            request.Senha = Console.ReadLine();
            Console.WriteLine("");

            var email = new Email(enderecoEmail);
            var nome = new Nome(primeiroNome, ultimoNome);

            request.Email = email;
            request.Nome = nome;

            var response = service.AdicionarJogador(request);

            if (service.Notifications.Count > 0)
            {
                Console.WriteLine("");

                service.Notifications.ToList().ForEach(x =>
                {
                    Console.WriteLine(x.Message);
                });
            }   
             
            Console.ReadKey();
        }
    }
}
