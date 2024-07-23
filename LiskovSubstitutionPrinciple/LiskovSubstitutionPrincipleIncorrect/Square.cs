using System.Xml.Linq;

namespace LiskovSubstitutionPrincipleIncorrect
{
    public class Square : Rectangle
    {
        private int _width;
        private int _height;

        public override void SetWidth(int width)
        {
            _width = width;
            _height = width;
        }

        public override void SetHeight(int height)
        {
            _width = height;
            _height = height;
        }

        public int GetWidth()
        {
            return _width;
        }

        public int GetHeight()
        {
            return _height;
        }   
    }
}
