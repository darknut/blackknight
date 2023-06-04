using System;
using System.Collections.Generic;

namespace DeveloperSample.ClassRefactoring
{
    public enum SwallowType
    {
        African, European
    }

    public enum SwallowLoad
    {
        None, Coconut
    }

    public class SwallowFactory
    {
        public Swallow GetSwallow(SwallowType swallowType) => new Swallow(swallowType);
    }

    public class Swallow
    {
        public SwallowType Type { get; }
        public SwallowLoad Load { get; private set; }

        private static readonly Dictionary<SwallowType, int> SwallowTypeCost = new()
        {
            {SwallowType.African, 18},
            {SwallowType.European, 16}
        };
        private static readonly Dictionary<SwallowLoad, int> SwallowLoadCost = new()
        {
            {SwallowLoad.Coconut, 0},
            {SwallowLoad.None, 4},
        };

        public Swallow(SwallowType swallowType)
        {
            Type = swallowType;
        }

        public void ApplyLoad(SwallowLoad load)
        {
            Load = load;
        }

        public double GetAirspeedVelocity()
        {
            if (SwallowTypeCost.ContainsKey(Type) && SwallowLoadCost.ContainsKey(Load))
                return SwallowTypeCost[Type] + SwallowLoadCost[Load];
            throw new InvalidOperationException();
        }
    }
}