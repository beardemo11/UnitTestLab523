using System.Collections.Generic;
using System.Data;
using UnitTestLab1.OTD;

namespace UnitTestLab1.Repository
{
    public interface IPrdouctRepository
    {
        List<Product> SelectFruits();
    }
}