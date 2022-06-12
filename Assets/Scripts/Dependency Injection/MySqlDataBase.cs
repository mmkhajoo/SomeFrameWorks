using UnityEngine;

namespace DefaultNamespace.Dependency_Injection
{
    public class MySqlDataBase
    {
        public void Get()
        {
            Debug.Log("MySql Get Called.");
        }

        public void Insert()
        {
            Debug.Log("MySql Insert Called.");

        }

        public void Update()
        {
            Debug.Log("MySql Update Called.");
        }

        public void Delete()
        {
            Debug.Log("MySql Delete Called.");
        }
    }
}