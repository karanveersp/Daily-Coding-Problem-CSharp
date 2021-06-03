using System.Collections.Generic;
using Xunit;

public class DailyCodeTests
{
    
    [Fact]
    public void TestProductArrayExcludingI()
    {
        // Arrange
        var input = new List<int>{1,2,3,4,5};
        var expected = new List<int>{120, 60, 40, 30, 24};

        // Act
        var actual = DailyCode.Runner.ProductArrayExcludingI(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestContainsPairAddingToTarget()
    {
        // Arrange
        var inputList = new List<int>{10, 15, 3, 7};
        var target = 17;

        // Act
        var result = DailyCode.Runner.ContainsPairAddingToTarget(inputList, target);

        // Assert
        Assert.True(result);
    }
}