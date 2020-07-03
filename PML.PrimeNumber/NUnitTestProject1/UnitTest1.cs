using NUnit.Framework;
using PML.PrimeNumber;
using System;
using Moq;

namespace NUnitTestProject1
{
    public class Tests
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        //[Test]
        //public void Test1()
        //{
        //    Assert.Pass();
        //}
        //[TestClass()]
        [TestFixture]
        public class InteractionFactoryTests
        {
            //[TestMethod()]
            [Test]
            public void CreateInteractionTypeSpecialisedTest_UserInteraction()
            {
                // Arrange
                var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.ConsoleUser);

                // Act 
                Type rc = interactonType.GetType();

                // Assert
                Assert.IsTrue(rc.Name == "UserConsoleInteraction");
            }
            //[TestMethod()]
            [Test]
            public void CreateInteractionTypeSpecialisedTest_NonUserInteraction()
            {
                // Arrange
                var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.Default);

                // Act 
                Type rc = interactonType.GetType();

                // Assert
                Assert.IsTrue(rc.Name == "BaseInteraction");
            }
            //[TestMethod()]
            [Test]
            public void CreateInteractionTypeSpecialisedTest_NonUserInteractionCanRunMethodsGetValue()
            {
                // Arrange

                // Act 
                var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.Default);

                // Assert
                var rc = interactonType.GetValue();
                Assert.IsTrue(rc > 0);
            }
            //[TestMethod()]
            //[Test]
            //[ExpectedException(typeof(ArgumentException), ExpectedMessage = "expected message")]

            //[ExpectedException(typeof(NotImplementedException), "Expected exception")]
            //public void CreateInteractionTypeSpecialisedTest_NonUserInteractionCanRunMethodsPrint()
            //{
            //    // Arrange
            //    var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.Default);

            //    // Act 
            //    interactonType.PrintValue(new List<long>());
            //}
        }
    }
}