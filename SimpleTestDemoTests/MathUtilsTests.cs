using SimpleTestDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTestDemoTests
{
    [TestClass]
    public class MathUtilsTests
    {
        [TestMethod]
        public void GetRectangleArea_ReturnsCorrectResult()
        {
            // Arrange
            double sideA = 2;
            double sideB = 3;

            // Act
            double result = MathUtils.GetRectangleArea(sideA, sideB);

            // Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void GetRectangleArea_ReturnsCorrectResultForNegativeNumbers()
        {
            // Arrange
            double sideA = -4;
            double sideB = 7;

            // Act
            double result = MathUtils.GetRectangleArea(sideA, sideB);

            // Assert
            Assert.AreEqual(-28, result);
        }

        [TestMethod]
        public void GetHypotenuse_ReturnsCorrectHyptotenuse()
        {
            // Arrange
            double a = 3;
            double b = 4;

            // Act
            double result = MathUtils.GetHypotenuse(a, b);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void GetRectangleSide_ReturnCorrectSideForSimpleRectangle()
        {
            // Arrange
            double area = 4;
            double side = 2;

            // Act
            double result = MathUtils.GetRectangleSide(area, side);

            // Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetRectangleSide_ExceptionOnSide0()
        {
            // Arrange
            double area = 4;
            double side = 0;

            // Act
            double result = MathUtils.GetRectangleSide(area, side);
        }
    }
}
