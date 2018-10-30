using System;
using XGames.Domain.Commands;
using XGames.Domain.Entities;
using XGames.Domain.ValueObjects;

namespace DomainNotification.Application.Services
{
    public class PersonService : Service
    {
        private readonly Person _entity;

        public PersonService(Guid personId, string name, string email)
        {
            _entity = new Person(personId, name, new Email(email));
            NotificationEntity = _entity;
        }

        public void SavePerson(Guid personId, string name)
        {
            var cmd = new SavePerson(_entity);
            cmd.Run();
        }
    }
}