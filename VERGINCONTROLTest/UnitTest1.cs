using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibraries;
namespace VERGINCONTROLTest;
[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TakeGradeByPercentage()
    {
        //assert
        var percentage = 90;

        //act
        var grade = TakeGradeByPercentage(percentage);

        //assert
        assert.that(grade, is.Equalto("A+"));
    }
}