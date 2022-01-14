namespace DefaultNamespace
{

    public interface IServiceable { }

    public interface IService
    {
        void Initialize();
    }

    public interface IScopeService : IService
    {
        void Dispose();
    }
}