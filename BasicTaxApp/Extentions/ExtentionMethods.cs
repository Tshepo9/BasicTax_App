using BasicTaxApp.Models;

namespace BasicTaxApp.Extentions
{
    public static class ExtentionMethods
    {
        public static decimal CalculateTax(this Product product) 
        { 
           decimal tax = 0;
            
           if(product.IsExempted && !product.IsImported)
            {
                return tax;
            }
           else if(product.IsExempted && product.IsImported) 
           {
                tax = (product.price * 5m) / 100;
           }
           else if (!product.IsExempted && product.IsImported)
            {
                tax = (product.price * 15m) / 100;
            }
            else
            {
                tax = (product.price * 10m) / 100;
            }


            return Math.Ceiling(tax / 0.05m) * 0.05m;
        }

        public static decimal Total(this Product products)
        {
            decimal total = products.price + products.CalculateTax();
            
            return total;
        }
    }
}
