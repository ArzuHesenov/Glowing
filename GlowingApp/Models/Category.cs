namespace GlowingApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [MaxLenght(250)]
        public string CatagoryName { get; set; } = null!;
        [MaxLenght(650)]

        public string? Icon { get; set; }
    }
}
