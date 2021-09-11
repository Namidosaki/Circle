using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindingInCircle;

namespace TestFindingInCircle
{
    [TestClass]
    public class FindingInCirclePositiveTest
    {
        private readonly IInCircleService service;

        public FindingInCirclePositiveTest()
        {
            service = new InCircleService();
        }


        [TestMethod]
        public void DotCenterCircleTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 2, 1, 1);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DotInCircleTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 3, 2, 1);
            //Assert
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void DotInCircumferenceTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 2, 3, 1);
            //Assert
            Assert.AreEqual(true, result);
        }
    }
}
