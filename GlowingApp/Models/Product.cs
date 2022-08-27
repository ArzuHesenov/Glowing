namespace GlowingApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLenght(250)]
        public string Name { get; set; } = null!;
        [MaxLenght(650)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        [MaxLenght(650)]
        public string? PhotoUrl { get; set; }
        public bool IsNew { get; set; }
        public bool Isfeatured { get; set; }
        public decimal Rating { get; set; }

        public int CatagoryId { get; set; }
        public virtual Category? Catagory { get; set; }


    }
}
