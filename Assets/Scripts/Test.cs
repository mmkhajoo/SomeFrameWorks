using UnityEngine;

namespace DefaultNamespace
{
    public class Test : ITest , IScopeService
    {
        public Test()
        {
            ServiceLocator.Register<ITest>(this);
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