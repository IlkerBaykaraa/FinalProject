using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Product ile ilgili operasyonlar.
    public interface IProductDal:IEntityRepository<Product>
    {
       
    }
}
