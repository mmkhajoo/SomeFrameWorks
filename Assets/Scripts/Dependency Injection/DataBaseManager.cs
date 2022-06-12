namespace DefaultNamespace.Dependency_Injection
{
    public class DataBaseManager
    {
        private MySqlDataBase _dataBase;
        private Logger _logger;

        public DataBaseManager(MySqlDataBase dataBase,Logger logger)
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