using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class ProductRepository
    {
        public Product Retrive(int productId)
        {
            Product product = new Product(productId);

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
