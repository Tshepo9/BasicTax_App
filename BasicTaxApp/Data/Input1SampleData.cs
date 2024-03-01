using BasicTaxApp.Models;

namespace BasicTaxApp.Data
{
    public static class Input1SampleData
    {

        public static List<Product> getInput1()
        {
            var input1 = new List<Product>()
            {
                new Product {
                    Name= "Book",
                    Quantity=1,
                    price = 12.49m,
                    IsImported=false,
                    IsExempted=true
                },
                new Product{
                    Name="Music CD",
                    Quantity=1,
                    price = 14.99m,
                    IsImported=false,
                    IsExempted=false

                },
                new Product{
                     Name="Chocolate bar",
                    Quantity=1,
                    price = 0.85m,
                    IsImported=false,
                    IsExempted=true
                }
            };

            return input1;

        }
    }
}
