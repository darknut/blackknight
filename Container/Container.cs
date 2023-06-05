using System;
using System.Collections.Generic;

namespace DeveloperSample.Container
{
    public class Container
    {
        Dictionary<Type, Type> containers = new();

        public void Bind(Type interfaceType, Type implementationType)
        {
            containers.Add(interfaceType, implementationType);
        }
        public T Get<T>()
        {
            if (containers.ContainsKey(typeof(T)))
            {
                Type t = containers[typeof(T)];
                return (T)Activator.CreateInstance(t);
            }
            throw new InvalidOperationException();
        }
    }
}