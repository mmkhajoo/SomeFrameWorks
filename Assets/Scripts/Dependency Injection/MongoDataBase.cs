using UnityEngine;

namespace DefaultNamespace.Dependency_Injection
{
    public class MongoDataBase : IDataBase
    {
        public void Get()
        {
            Debug.Log("Mongo Get Called.");
        }

        public void Insert()
        {
            Debug.Log("Mongo Insert Called.");
        }

        public void Update()
        {
            Debug.Log("Mongo Update Called.");
        }

        public void Delete()
        {
            Debug.Log("Mongo Delete Called.");
        }
    }
}