using prmToolkit.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XGames.Domain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        protected  EntityBase()
        {
            id = Guid.NewGuid();
        }

        public Guid id { get; set; }
    }
}
