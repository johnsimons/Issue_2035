using System;
using NServiceBus;
using NServiceBus.ObjectBuilder;

namespace ClassLibrary1
{
    public class NServiceBusClassBuilder : IClassBuilder
    {
        private readonly IBuilder _builder;

        public NServiceBusClassBuilder(IBuilder builder)
        {
            _builder = Configure.Instance.Builder;
        }

        public T Build<T>()
        {
            return _builder.Build<T>();
        }

        public object Build(Type typeToBuild)
        {
            return _builder.Build(typeToBuild);
        }
    }
}