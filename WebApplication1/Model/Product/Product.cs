using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model.Product
{
    public class Product
    {
        [Key]
        public string productId { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }


        public Product() { /*For ORM*/ }

        public Product(string productId, string name, string description, double price)
        {
            this.productId = productId;
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
