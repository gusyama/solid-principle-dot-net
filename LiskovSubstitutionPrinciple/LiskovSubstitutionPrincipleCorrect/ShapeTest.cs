using NUnit.Framework;

namespace LiskovSubstitutionPrincipleCorrect
{
    public class ShapeTests
    {
        [Test]
        public void Rectangle_GetArea_ReturnsCorrectArea()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(5);
            rectangle.SetHeight(10);

            // Act
            int area = rectangle.GetArea();

            // Assert
            Assert.AreEqual(50, area);
        }

        [Test]
        public void Square_GetArea_ReturnsCorrectArea()
        {
            // Arrange
            Square square = new Square();
            square.SetSide(5);

            // Act
            int area = square.GetArea();

            // Assert
            Assert.AreEqual(25, area);
        }

        [Test]
        public void Square_IsSubstitutableForShape()
        {
            // Arrange
            Shape square = new Square();
            
            // Act
            int area = square.GetArea();
        }

        [Test]
        public void Rectangle_IsSubstitutableForShape()
        {
            // Arrange
            Shape rectangle = new Rectangle();

            // Act
            int area = rectangle.GetArea();

        }
    }
}