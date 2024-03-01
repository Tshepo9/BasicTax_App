using BasicTaxApp.Models;

namespace BasicTaxApp.Data
{
    public class Input3SampleData
    {
        public static List<Product> getInput3()
        {
            var input3 = new List<Product>()
            {
                new Product {
                    Name= "bottle of perfume",
                    Quantity=1,
                    price = 27.99m,
                    IsImported=true,
                    IsExempted=false
                },
                new Product{
                    Name="Bottle of perfume",
                    Quantity=1,
                    price = 18.99m,
                    IsImported=false,
                    IsExempted=false

                },
                new Product{
                    Name="Packet of paracetamol",
                    Quantity=1,
                    price = 9.75m,
                    IsImported=false,
                    IsExempted=true
                },
                new Product{
                    Name="Box Of Chocolates",
                    Quantity=1,
                    price = 11.25m,
                    IsImported=true,
                    IsExempted=true
                }
            };

            return input3;

        }
    }
}

