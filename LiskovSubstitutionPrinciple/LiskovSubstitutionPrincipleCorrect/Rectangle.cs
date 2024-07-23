namespace LiskovSubstitutionPrincipleCorrect
{
    public class Rectangle : Shape
    {
        protected int width;
        protected int height;

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public override int GetArea()
        {
            return width * height;
        }
    }
}

