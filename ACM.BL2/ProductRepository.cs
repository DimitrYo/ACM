using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int productId)
        {
            Product product = new Product(productId);

            Object myObject = new Object();

            Console.WriteLine("");

            if (productId == 1)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "Assorted Size";
                product.CurrentPrice = 15.936M;
            }
            return product;
        }

        public bool Save()
        {
            return true;
        }

    }
}
