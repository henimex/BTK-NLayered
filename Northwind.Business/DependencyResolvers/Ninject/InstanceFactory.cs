using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace Northwind.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        //public static T GetInstance<T>(NinjectModule module)
        //{
        //    var karnel = new StandardKernel(module);
        //    return karnel.Get<T>();
        //}

        public static T GetInstance<T>()
        {
            var karnel = new StandardKernel(new BusinessModule());
            return karnel.Get<T>();
        }
    }
}
