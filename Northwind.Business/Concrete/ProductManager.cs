using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Concrete;
using Northwind.Entities.Concrete;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        public List<Product> GetAll()
        {
            ProductDal _productDal = new ProductDal();
            return _productDal.GetAll();
        }
    }
}
