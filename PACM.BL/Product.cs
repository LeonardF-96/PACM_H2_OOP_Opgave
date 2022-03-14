using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PACME.Common;

namespace PACM.BL
{
    public class Product: EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int ProductID)
        {
            productId = ProductID;
        }

        //The question mark behind decimal determines that the value may not be null
        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int productId { get; set; }
        private string _productName;
        public string ProductName
        {
            get
            {
                return _productName.InsertSpaces();
            }
            set { _productName = value; }
        }

        public override string ToString() => ProductName;
        public string Log() => $"{productId}: {ProductName} Detail: {ProductDescription} Status: {EntityState.ToString()}";
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
