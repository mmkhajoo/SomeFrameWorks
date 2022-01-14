using System;
using System.Collections;
using UnityEngine;

namespace DefaultNamespace
{
    public class LauncherTest : MonoBehaviour
    {
        private Test _test;

        private void Awake()
        {
            _test = new Test();
        }

        private void Start()
        {
            // StartCoroutine(Wait());
        }


        private IEnumerator Wait()
        {
            yield return new WaitForSeconds(2f);
            
            var test = ServiceLocator.Resolve<ITest>();

            test.HelloWorld();
        }
    }
}