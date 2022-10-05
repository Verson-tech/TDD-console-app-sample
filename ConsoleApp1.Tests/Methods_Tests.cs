using Xunit;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1_Tests;

internal class Methods_Tests
{
    [Theory]
    [InlineData(1,1,2)]
    [InlineData(-1, -1, -2)]
    [InlineData(1, -1, 0)]
    [InlineData(0, 0, 0)]
    public void Add(int num1, int num2, int expectedSum)
    {
        //Arrange: This is where we prepare the code in order to call the method you need to test
        var m = new Methods_Tests();
        //For example, we may need to instantiate an instance of the class that will contain the code we are testing
        //Act: This is where we actually call the method we want to test
        var actual = m.Add(num1, num2);
        //Simply put, we need to call what we want to test
        //Assert: Check against a constant(check against what is expected)
        //Verify that the code we wrote behaves as expected
        Assert.Equal(expectedSum, actual);
    }
}
