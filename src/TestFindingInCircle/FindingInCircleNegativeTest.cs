using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindingInCircle;

namespace TestFindingInCircle
{
    [TestClass]
    public class FindingInCircleNegativeTest
    {
        private readonly IInCircleService service;

        public FindingInCircleNegativeTest()
        {
            service = new InCircleService();
        }

        [TestMethod]
        public void DotThereoverCircleTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 2, 4, 1);
            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void DotDextralCircleTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 2, 1, 4);
            //Assert
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void DotFromDownCircleTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 2, -2, 1);
            //Assert
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void DotFromLeftCircleTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 2, 1, -2);
            //Assert
            Assert.AreEqual(false, result);
        }
        
        [TestMethod]
        public void DotInCornerCircleTest()
        {
            //Arrange
            bool? result;
            //Act
            result = service.Affiliation(1, 1, 2, 3, 3);
            //Assert
            Assert.AreEqual(false, result);
        }

    }
}
