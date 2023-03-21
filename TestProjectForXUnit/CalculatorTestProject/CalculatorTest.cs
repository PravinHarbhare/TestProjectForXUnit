using System;
using TestProjectForXUnit;
using Xunit;

namespace CalculatorTestProject
{
    public class CalculatorTest
    {
        Calculator cal = new Calculator();

        [Fact]
        public void Add_CheckForValid()
        {
            //Arrange

            int a = 2;
            int b = 3;

            //Act
            int result  = cal.Add(2, 3);

            //Assert

            Assert.Equal(5, result);


        }


        [Fact]
        public void Add_CheckForInValid()
        {
            //Arrange

            int a = 2;
            int b = 3;

            //Act
            int result = cal.Add(2, 3);

            //Assert

            Assert.Equal(6, result);
        }
    }
}
