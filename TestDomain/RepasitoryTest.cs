using Domain;
using NUnit.Framework;

namespace TestDomain
{
    public class RepasitoryTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(30)]
        public void Test_GetNumber(int num)
        {
            //Arrange
            int arrNum = 10;

            //Act 
            int result = Repasitory.GetNumber(num);

            //Assert
            Assert.AreEqual(arrNum, result);
        }

        [Test]
        [TestCase(1)]
        [TestCase(10)]
        [TestCase(30)]
        public void Test_PostNumber(int num)
        {
            //Arrange
            int arrNum = 15;

            //Act 
            int result = Repasitory.PostNumber(num);

            //Assert
            Assert.AreEqual(arrNum, result);
        }

        [Test]
        [TestCase(15)]
        [TestCase(15)]
        [TestCase(15)]
        public void Test_PutNumber(int num)
        {
            //Arrange
            int arrNum = 15;

            //Act 
            int result = Repasitory.PutNumber(num);

            //Assert
            Assert.AreEqual(arrNum, result);
        }

        [Test]
        [TestCase(15)]
        [TestCase(15)]
        [TestCase(15)]
        public void Test_DeleteNumber(int num)
        {
            //Arrange
            int arrNum = 15;

            //Act 
            int result = Repasitory.DeleteNumber(num);

            //Assert
            Assert.AreEqual(arrNum, result);
        }
    }
}