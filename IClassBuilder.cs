using System;

namespace ClassLibrary1
{
    public interface IClassBuilder
    {
        T Build<T>();
        object Build(Type typeToBuild);
    }
}