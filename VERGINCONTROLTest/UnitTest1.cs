using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace VERGINCONTROLTest;
[TestClass]
public class UnitTest1
{
    [TestMethod]
     public void TakeGradeByPercentage_ReturnsCorrectGrade()
        {
            // Arrange
            var functions = new Functions();
            var percentage = 85;

            // Act
            var grade = functions.TakeGradeByPercentage(percentage);

            // Assert
            Assert.Equal("B+", grade);
        }
}