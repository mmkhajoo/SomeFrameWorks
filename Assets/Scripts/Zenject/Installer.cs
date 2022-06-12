using DefaultNamespace.Dependency_Injection;
using Zenject;

namespace DefaultNamespace
{
    public class Installer : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IDataBase>().To<BetterMySqlDataBase>().AsSingle();
            Container.Bind<ILogger>().To<Logger>().AsSingle();
            Container.Bind<BetterDataBaseManager>().AsSingle();
        }
    }
}