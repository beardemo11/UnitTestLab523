using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using UnitTestLab1.Repository;
using UnitTestLab1.OTD;

namespace UnitTestLab1Tests3.Stub
{
  internal  class ProductRepositoryStub:IPrdouctRepository
    {
        public List<Product> SelectFruits()
        {
            return new List<Product> {
                new Product {Name="蘋果",Price=30 },
                new Product {Name="香蕉",Price=15 },
                new Product {Name="芭樂",Price=20 }
            };
            throw new NotImplementedException();
        }
    }
}
