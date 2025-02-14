using System;

namespace Paillave.Etl.Core
{
    public interface IDependencyResolver
    {
        T Resolve<T>() where T : class;
        T Resolve<T>(string key) where T : class;
        object Resolve(Type type);
        bool TryResolve<T>(out T resolved) where T : class;
        bool TryResolve<T>(string key, out T resolved) where T : class;
        bool TryResolve(Type type, out object resolved);
    }
}