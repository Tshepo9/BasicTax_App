namespace BasicTaxApp.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
        public bool IsImported { get; set; }
        public  bool IsExempted { get; set; }   
    }
}
