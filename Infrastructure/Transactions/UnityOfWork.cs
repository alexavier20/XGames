using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Transactions
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly XGameContext _context;

        public UnityOfWork(XGameContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();

        }
    }
}
