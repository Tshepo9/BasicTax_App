using BasicTaxApp.Models;

namespace BasicTaxApp.Data
{
    public class Input2SampleData
    {
        public static List<Product> getInput2()
        {
            var input2 = new List<Product>()
            {
                new Product {
                    Name= "box of chocolates",
                    Quantity=1,
                    price = 10.00m,
                    IsImported=true,
                    IsExempted=true
                },
                new Product{
                    Name="bottle of perfume",
                    Quantity=1,
                    price = 47.50m,
                    IsImported=true,
                    IsExempted=false

                }
               
            };

            return input2;

        }
    }
}

