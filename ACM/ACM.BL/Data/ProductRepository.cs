using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL.Data
{
    public class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            var product = new Product(productId);
            
            if (productId == 1) {
                product.ProductName = "iPhone XS Max";
            }
            
            return product;
        }

        public bool Save(Product product)
        {
            var success = true;

            if (product.HasChanges && product.IsValid) {
                if (product.IsNew)
                {

                }
                else {

                }
            }
            return success;
        }

    }
}
