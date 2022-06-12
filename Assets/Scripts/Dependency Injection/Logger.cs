using UnityEngine;

namespace DefaultNamespace.Dependency_Injection
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Debug.Log(message);
        }
    }
}