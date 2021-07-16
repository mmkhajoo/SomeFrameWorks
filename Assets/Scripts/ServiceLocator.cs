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
      
      _scopeDictionary.Add(_globalScope,new Dictionary<Type, object>());
   }

   public static void ChangeScope(string scope)
   {
      _currentScope = scope;
      
      if(!_scopeDictionary.ContainsKey(scope))
         _scopeDictionary.Add(scope,new Dictionary<Type, object>());
   }

   public static void Register<T>(object service,string scope = _globalScope) where T : IService
   { 
      var type = service.GetType();

      var tType = typeof(T);

      if (type.IsInterface)
         throw new DataException($"Object : {type.FullName} Is A Interface");

      var hasInterface = type.GetInterfaces().Contains(tType);
      
      if(!hasInterface)
          throw new DataException($"Object : {type.FullName} Doesn't Have Interface Type of {tType}");

      if (_scopeDictionary[scope].ContainsKey(tType))
      {
         Debug.LogWarning($"Duplication For {type.FullName} Kept The First One added");
         return;
      }
      
      _scopeDictionary[scope].Add(tType,service);
   }

   public static T Resolve<T>() where T : IService
   {
      var type = typeof(T);

      var scope = _scopeDictionary[_currentScope];

      if (scope.ContainsKey(type))
      {
         return (T)scope[type];
      }
      
      throw new DataException($"Service Locator Doesn't Have Service Type Of {type.FullName} In {_currentScope} Scope");
   }
}
