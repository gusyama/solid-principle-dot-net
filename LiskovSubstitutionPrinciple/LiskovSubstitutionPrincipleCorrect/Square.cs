namespace LiskovSubstitutionPrincipleCorrect
{
    public class Square : Shape
    {
        protected int side;

        public void SetSide(int side)
        {
            this.side = side;
        }

        public override int GetArea()
        {
            return side * side;
        }
    }
}
