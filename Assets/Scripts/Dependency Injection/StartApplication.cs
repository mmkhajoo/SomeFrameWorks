using System;
using UnityEngine;

namespace DefaultNamespace.Dependency_Injection
{
    public class StartApplication : MonoBehaviour
    {
        private void Start()
        {
            var database = new MongoDataBase();
            var logger = new Logger();

            var dataBaseManager = new BetterDataBaseManager(database, logger);
            
            dataBaseManager.Delete();
        }
    }
}