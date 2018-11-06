using Infrastructure.Persistence;
using Infrastructure.Persistence.Repositories;
using Infrastructure.Persistence.Repositories.Base;
using Infrastructure.Transactions;
using Microsoft.Practices.Unity;
using prmToolkit.NotificationPattern;
using System.Data.Entity;
using XGames.Domain.Interfaces.Repositories;
using XGames.Domain.Interfaces.Repositories.Base;
using XGames.Domain.Interfaces.Services;
using XGames.Domain.Services;

namespace XGame.IoC.Unity
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<DbContext, XGameContext>(new HierarchicalLifetimeManager());
            //UnitOfWork
            container.RegisterType<IUnityOfWork, UnityOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<prmToolkit.NotificationPattern.INotifiable, Notifiable>(new HierarchicalLifetimeManager());

            //Serviço de Domain
            //container.RegisterType(typeof(IServiceBase<,>), typeof(ServiceBase<,>));

            container.RegisterType<IServiceJogador, ServiceJogador>(new HierarchicalLifetimeManager());
           // container.RegisterType<IServiceJogo, ServiceJogo>(new HierarchicalLifetimeManager());



            //Repository
            container.RegisterType(typeof(IRepositoryBase<,>), typeof(RepositoryBase<,>));

            container.RegisterType<IRepositoryJogador, RepositoryJogador>(new HierarchicalLifetimeManager());
            //container.RegisterType<IRepositoryJogo, RepositoryJogo>(new HierarchicalLifetimeManager());

        }
    }
}
