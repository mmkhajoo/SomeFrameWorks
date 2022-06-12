using UnityEngine;

namespace DefaultNamespace.Dependency_Injection
{
    public class BetterMySqlDataBase : IDataBase
    {
        public void Get()
        {
            Debug.Log("Better MySql Get Called.");
        }

        public void Insert()
        {
            Debug.Log("Better MySql Insert Called.");

        }

        public void Update()
        {
            Debug.Log("Better MySql Update Called.");
        }

        public void Delete()
        {
            Debug.Log("Better MySql Delete Called.");
        }
    }
}