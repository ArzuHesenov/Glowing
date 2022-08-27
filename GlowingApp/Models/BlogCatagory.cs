namespace GlowingApp.Models
{
    public class BlogCatagory
    {
        public int Id { get; set; }
        [MaxLenght(200)]
        public string Name { get; set; } = null!;
    }
}
