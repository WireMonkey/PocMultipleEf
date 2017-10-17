using System;
using Ninject;
using Ninject.Parameters;
using PocMultipleEntities.Business;
using PocMultipleEntities.Business.Interface;
using PocMultipleEntities.Data;

namespace PocMultipleEntities.Bindings
{
    public static class Dependencies
    {
        private static  StandardKernel _kernal { get; } = new StandardKernel();

        static Dependencies()
        {
            _kernal.Bind<IEntities>().To<Entities>();
            _kernal.Bind<IOperationFacotory>().To<OperationFacotory>();
        }

        public static object Get(Type type, params IParameter[] parameters)
            => _kernal.Get(type, parameters);

        public static object Get<T>(params IParameter[] parameters)
            => _kernal.Get<T>(parameters);
    }
}