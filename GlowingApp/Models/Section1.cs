namespace GlowingApp.Models
{
    public class Section1
    {
        public int Id { get; set; }
        [MaxLenght(250)]
        public string SubTitle { get; set; }
        [MaxLenght(250)]
        public string Header { get; set; } = null!;
        [MaxLenght(350)]
        public string Description { get; set; }
        [MaxLenght(350)]
        public string? PhotoUrl { get; set; }


    }
}
