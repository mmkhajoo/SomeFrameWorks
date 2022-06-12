using DefaultNamespace.Dependency_Injection;
using UnityEngine;
using Zenject;

namespace DefaultNamespace
{
    public class ZenjectApplicationStart : MonoBehaviour
    {
        [Inject]
        private BetterDataBaseManager _dataBaseManager;

        private void Start()
        {
            _dataBaseManager.Get();
        }
    }
}