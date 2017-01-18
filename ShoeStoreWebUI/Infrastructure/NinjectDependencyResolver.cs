using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Moq;
using Ninject;
using ShoeStoreDomain.Abstract;
using ShoeStoreDomain.Entities;

namespace ShoeStoreWebUI.Infrastructure
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
            //we'll put bindings here
            Mock<IProductRepository> mock = new Mock<IProductRepository>();
            mock.Setup(m => m.Products).Returns(new List<Product>
            {
                new Product { Name = "Jordan Retro 12", Price = 249.99m},
                new Product { Name = "Jordan Retro 13", Price = 189.99m},
                new Product { Name = "Lebron 8", Price = 275.00m}
            });

            kernel.Bind<IProductRepository>().ToConstant(mock.Object);
        }
    }
}