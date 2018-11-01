using Infrastructure.Persistence.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using XGames.Domain.Arguments.Jogador;
using XGames.Domain.Entities;
using XGames.Domain.Interfaces.Repositories;

namespace Infrastructure.Persistence.Repositories
{
    public class RepositoryJogador : RepositoryBase<Jogador, Guid>, IRepositoryJogador
    { 
        protected readonly XGameContext _context;

        public RepositoryJogador(XGameContext context) : base(context)
        {
            _context = context;
        }       
    }
}
