using UnityEngine;

namespace DefaultNamespace.Dependency_Injection
{
    public class Logger
    {
        public void Log(string message)
        {
            Debug.Log(message);
        }
    }
}