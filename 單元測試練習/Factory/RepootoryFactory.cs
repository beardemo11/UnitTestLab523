using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestLab1.Repository;
namespace UnitTestLab1.Factory
{
  public  class RepootoryFactory
    {
        public static PrdouctRepository GetProductRepsotryFactory()
        {
            return new PrdouctRepository();
        }
    }
}
