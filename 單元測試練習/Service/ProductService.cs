using System;
using System.Data;
using System.Data.SqlClient;
using UnitTestLab1.Repository;
using System.Collections.Generic;
using System.Linq;
namespace UnitTestLab1
{
    public class ProductService : IProductService
    {

        protected IPrdouctRepository _prdouctRepository;

        public IPrdouctRepository prdouctRepositoryObj { get; set; }

        public ProductService()
        {
            _prdouctRepository = Factory.RepootoryFactory.GetProductRepsotryFactory();
        }

        public ProductService(IPrdouctRepository prdouctRepository)
        {
            _prdouctRepository = prdouctRepository;
        }

        /// <summary>
        /// 蘋果買2顆 , 香蕉一串 ,芭樂3顆 共多少錢
        /// </summary>
        /// <returns></returns>
        public decimal CulcFruitsPrice(Dictionary<string, int> buyFruits)
        {
            var fruits = _prdouctRepository.SelectFruits();

            var totalPrice = 0m;


            foreach (var KeyValue in buyFruits)
            {
                var fruit = fruits.FirstOrDefault(p => p.Name == KeyValue.Key);
                if (fruit != null)
                {
                    totalPrice += fruit.Price * KeyValue.Value;
                }
            }


            //foreach (var fruit in fruits)
            //{
            //    if (fruit.Name == "蘋果")
            //        totalPrice += fruit.Price * 2;
            //    else if (fruit.Name == "香蕉")
            //        totalPrice += fruit.Price * 1;
            //    else if (fruit.Name == "芭樂")
            //        totalPrice += fruit.Price * 3;

            //}


            return totalPrice;
        }
    }
}