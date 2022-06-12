namespace DefaultNamespace.Dependency_Injection
{
    public class BetterDataBaseManager
    {
        private IDataBase _dataBase;
        private ILogger _logger;

        public BetterDataBaseManager(IDataBase dataBase,ILogger logger)
        {
            _dataBase = dataBase;
            _logger = logger;
        }

        public void Get()
        {
            _logger.Log("Data Base Get Called.");
            _dataBase.Get();
        }

        public void Insert()
        {
            _logger.Log("Data Base Insert Called.");

            _dataBase.Insert();
        }

        public void Delete()
        {
            _logger.Log("Data Base Delete Called.");

            _dataBase.Delete();
        }

        public void Update()
        {
            _logger.Log("Data Base Update Called.");

            _dataBase.Update();
        }
    }
}