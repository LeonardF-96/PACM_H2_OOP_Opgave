using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PACM.BL
{
    public class ProductRepository
    {
        public Product Retrieve(int ProductID)
        {
            Product product = new Product(ProductID);
            if (ProductID == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "4 delightful mini sunflowers in bright yellow.";
                product.CurrentPrice = 15.96M;
            }
            return product;
        }
        public bool Save(Product product)
        {
            var success = true;
            if (product.HasChanges)
            {
                if (product.IsValid)
                {
                    if (product.IsNew)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    success = false;
                }
            }
            return success;
        }
    }
}
