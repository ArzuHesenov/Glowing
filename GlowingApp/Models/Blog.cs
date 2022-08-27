namespace GlowingApp.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [MaxLenght(250)]
        public string Name { get; set; } = null!;
        [MaxLenght(550)]
        public string Description { get; set; }
        [MaxLenght(650)]
        public string PhotoUrl { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime ModifiedOn { get; set; }

    }
}
