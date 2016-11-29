using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Moq;
using Ninject;
using SelliT.Domain.Abstract;
using SelliT.Domain.Entities;

namespace SelliT.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product> {
                new Product {Name = "Pralka White", Unit ="szt.", Quantity = 1, Price = 1200M },
                new Product {Name = "Pralka Blue", Unit ="szt.", Quantity = 1, Price = 1300M },
                new Product {Name = "Pralka Yellow", Unit ="szt.", Quantity = 1,Price = 1400M },
                new Product {Name = "Pralka Brown", Unit ="szt.",Quantity = 1, Price = 1500M },
                new Product {Name = "Pralka Green", Unit ="szt.",Quantity = 1, Price = 1600M },
                new Product {Name = "Pralka Red", Unit ="szt.",Quantity = 1, Price = 16M }
           });

            kernel.Bind<IProductRepository>().ToConstant(mock.Object);

        }
    }
}