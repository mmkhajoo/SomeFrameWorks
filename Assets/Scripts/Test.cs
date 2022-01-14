using UnityEngine;

namespace DefaultNamespace
{
    public class Test : ITest , IScopeService
    {
        public Test()
        {
            ServiceLocator.Register<Test>(this);
        }

        public void Initialize()
        {
        }

        public void HelloWorld()
        {
            Debug.Log("Hello World!");
        }
        
        public void Dispose()
        {
            Debug.Log("Disposed");
        }
        
    }
}