namespace GlowingApp.Models
{
    internal class MaxLenghtAttribute : Attribute
    {
        private int v;

        public MaxLenghtAttribute(int v)
        {
            this.v = v;
        }
    }
}