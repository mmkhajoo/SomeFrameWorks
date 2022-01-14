using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using DefaultNamespace;
using UnityEngine;

public static class ServiceLocator
{
    private static Dictionary<string, Dictionary<Type, object>> _scopeDictionary;

    private const string _globalScope = "Global";

    private static string _currentScope = _globalScope;

    static ServiceLocator()
    {
        _scopeDictionary = new Dictionary<string, Dictionary<Type, object>>();

        _scopeDictionary.Add(_globalScope, new Dictionary<Type, object>());
    }

    public static void ChangeScope(string scope)
    {
        _currentScope = scope;

        if (!_scopeDictionary.ContainsKey(scope))
            _scopeDictionary.Add(scope, new Dictionary<Type, object>());
    }

    public static void RemoveScope(string scope)
    {
        if (_scopeDictionary.ContainsKey(scope))
        {
            foreach (var service in _scopeDictionary[scope])
            {
                var serviceValue = (IScopeService) service.Value;
                serviceValue.Dispose();
            }

            _scopeDictionary.Remove(scope);
        }
        else
        {
            Debug.LogError($"Scope:{scope} not exsits!");
        }
    }

    public static void Register<T>(object service, string scope = _globalScope) where T : IServiceable
    {
        var tType = typeof(T);

        if (IsValidRegistration(tType, service))
        {
            if (_scopeDictionary[scope].ContainsKey(tType))
            {
                Debug.LogWarning($"Duplication For {service.GetType().FullName} Kept The First One added");
                return;
            }

            _scopeDictionary[scope].Add(tType, service);
        }
    }

    public static T Resolve<T>() where T : IServiceable
    {
        var type = typeof(T);

        var scope = _scopeDictionary[_currentScope];

        if (scope.ContainsKey(type))
        {
            return (T) scope[type];
        }

        throw new DataException(
            $"Service Locator Doesn't Have Service Type Of {type.FullName} In {_currentScope} Scope");
    }


    private static bool IsValidRegistration(Type type, object service)
    {
        if (service == null)
        {
            Debug.LogError(
                $"Registering {type.Name} in service locater is failed because service instance is null.");
            return false;
        }

        if (!type.IsInterface)
        {
            Debug.LogError($"Object : {type.Name} Isn't A Interface");
            return false;
        }

        var hasInterface = service.GetType().GetInterfaces().Contains(type);

        if (!hasInterface)
        {
            Debug.LogError($"Object : {type.FullName} Doesn't Have Interface Type of {type}");

            return false;
        }

        return true;
    }
}