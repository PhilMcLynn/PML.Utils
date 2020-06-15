using Microsoft.VisualStudio.TestTools.UnitTesting;
using PML.PrimeNumber;
using System;
using System.Collections.Generic;
using System.Text;

namespace PML.PrimeNumber.Tests
{
    [TestClass()]
    public class InteractionFactoryTests
    {
        [TestMethod()]
        public void CreateInteractionTypeSpecialisedTest_UserInteraction()
        {
            // Arrange
            var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.ConsoleUser);
            
            // Act 
            Type rc = interactonType.GetType();

            // Assert
            Assert.IsTrue(rc.Name == "UserConsoleInteraction");
        }
        [TestMethod()]
        public void CreateInteractionTypeSpecialisedTest_NonUserInteraction()
        {
            // Arrange
            var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.Default);

            // Act 
            Type rc = interactonType.GetType();

            // Assert
            Assert.IsTrue(rc.Name == "BaseInteraction");
        }
        [TestMethod()]
        public void CreateInteractionTypeSpecialisedTest_NonUserInteractionCanRunMethodsGetValue()
        {
            // Arrange

            // Act 
            var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.Default);

            // Assert
            var rc = interactonType.GetValue();
            Assert.IsTrue(rc > 0);
        }
        [TestMethod()]
        [ExpectedException(typeof(NotImplementedException),"Expected exception")]
        public void CreateInteractionTypeSpecialisedTest_NonUserInteractionCanRunMethodsPrint()
        {
            // Arrange
            var interactonType = InteractionFactory.CreateInteractionTypeSpecialised(InteractionTypeEnum.Default);

            // Act 
            interactonType.PrintValue(new List<long>());
        }
    }
}