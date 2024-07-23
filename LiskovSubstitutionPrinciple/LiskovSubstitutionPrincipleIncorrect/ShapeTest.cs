using NUnit.Framework;

namespace LiskovSubstitutionPrincipleIncorrect
{
    [TestFixture]
    public class RectangleAndSquareTests
    {
        [Test]
        public void Square_GetArea_ReturnsIncorrectArea()
        {
            // Arrange
            Square square = new Square();
            square.SetWidth(5);
            square.SetHeight(5); // Ensuring square invariant

            // Act
            int area = square.GetArea();

            // Assert
            // Since Square's GetArea calculation is based on side * side, not width * height,
            // this test will fail.
            Assert.AreNotEqual(25, area);
        }

        [Test]
        public void Rectangle_IsSubstitutableForSquare()
        {
            // Arrange
            Rectangle rectangle = new Rectangle();
            rectangle.SetWidth(5);
            rectangle.SetHeight(10);

            // Act
            int area = rectangle.GetArea();

            // Assert
            // Rectangle is substitutable for itself, but not for Square due to different behavior.
            Assert.AreEqual(50, area);
        }
    }
}