namespace Ecommerse_practice.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public string? ImageUrl {  get; set; }
        public int Quantity {  get; set; }


        public Products() { }

        //for creating products/add products
        public Products(int id, string title, string description, double unitPrice, string? imageUrl, int quantity)
        {
            Id = id;
            Title = title;
            Description = description;
            UnitPrice = unitPrice;
            ImageUrl = imageUrl;
            Quantity = quantity;
        }
        //for updating products
        public Products(string title, string description, double unitPrice, string? imageUrl, int quantity)
        {
            Title = title;
            Description = description;
            UnitPrice = unitPrice;
            ImageUrl = imageUrl;
            Quantity = quantity;
        }
    }
}
