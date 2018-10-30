using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XGames.Domain.Interfaces.Arguments;

namespace XGames.Domain.Arguments.Plataforma
{
    public class AdicionarPlataformaResponse : IResponse
    {
        public Guid id { get; set; }

        public string Nome { get; set; }

        public string Message { get; set; }
    }
}
