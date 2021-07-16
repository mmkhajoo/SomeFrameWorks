using UnityEngine;

namespace DefaultNamespace
{
    public class Test : ITest
    {
        public Test()
        {
            ServiceLocator.Register<ITest>(this);
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