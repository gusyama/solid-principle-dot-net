namespace LiskovSubstitutionPrincipleIncorrect
{
    public class Rectangle
    {
        protected int width;
        protected int height;

        public virtual void SetWidth(int width)
        {
            this.width = width;
        }

        public virtual void SetHeight(int height)
        {
            this.height = height;
        }

        public int GetArea()
        {
            return width * height;
        }
    }
}
