using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestLab1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestLab1Tests3.Stub;
using NSubstitute;
using UnitTestLab1.Repository;
using UnitTestLab1.OTD;

namespace UnitTestLab1.Tests
{
    [TestClass()]
    public class ProductServiceTests
    {
        private IPrdouctRepository _mock = Substitute.For<IPrdouctRepository>();
        [TestMethod()]
        public void CulcFruitsPriceTest_Return135()
        {
            var service2 = new ProductService(_mock);
            _mock.SelectFruits().Returns(p => new List<Product> {
                new Product {Name="蘋果",Price=30 },
                new Product {Name="香蕉",Price=15 },
                new Product {Name="芭樂",Price=20 },
            });

            var service = new ProductService(new ProductRepositoryStub());
            var expect = 130;

            var result = service2.CulcFruitsPrice(GetFruit());
            Assert.AreEqual(expect, result);

        }

        [TestMethod()]
        public void CulcFruitsPriceTest_Return130()
        {
            _mock.SelectFruits().Returns(p => new List<Product> {
                new Product { Name = "蘋果", Price = 20 },
                 new Product { Name = "香蕉", Price = 20 },
                  new Product { Name = "芭樂", Price = 20 },
            });
            var service = new ProductService(_mock);
            var expect = 120;
            var result = service.CulcFruitsPrice(GetFruit());
            Assert.AreEqual(expect, result);

        }
        private Dictionary<string, int> GetFruit()
        {
            var buyFruitDic = new Dictionary<string, int>();
            buyFruitDic.Add("蘋果", 2);
            buyFruitDic.Add("香蕉", 2);
            buyFruitDic.Add("芭樂", 2);
            return buyFruitDic;
        }
    }


}