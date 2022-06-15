using FirstResponsiveWebAppClark.Models;
using System;
using Xunit;

namespace FutureAgeTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingCaseTest()
        {
            // Arrange
            String Name = "Noah";
            int? BirthYear = 1999;
            FutureAgeModel model = new FutureAgeModel (Name, BirthYear);

            int? expected = 23;
            int? actual;

            // Act
            actual = model.AgeThisYear();

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FailingCaseTest()
        {
            // Arrange
            String Name = "Noah";
            int? BirthYear = 1998;
            FutureAgeModel model = new FutureAgeModel(Name, BirthYear);

            int? expected = 23;
            int? actual;

            // Act
            actual = model.AgeThisYear();

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
