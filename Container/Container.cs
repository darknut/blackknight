using System;

namespace DeveloperSample.Container
{
    public class Container
    {
        private IContainerTestInterface Dependency;

        internal Container(IContainerTestInterface dependency)
        {
            Dependency = dependency;
        }

        public void Bind(Type interfaceType, Type implementationType)
        {

        }
        public T Get<T>()
        {
            Type type1 = typeof(T);
            Type type2 = typeof(IContainerTestInterface);
            if (type1.IsAssignableFrom(type2)) {
                return (T) Dependency;
            }
            throw new ArgumentException();
        }
    }
}