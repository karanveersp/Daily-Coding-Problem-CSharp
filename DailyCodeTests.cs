using System.Collections.Generic;
using Xunit;
using DailyCode.BinaryTree;
using System;
using Xunit.Abstractions;

public class DailyCodeTests
{
    private readonly ITestOutputHelper output;

    public DailyCodeTests(ITestOutputHelper output)
    {
        this.output = output;
    }

    [Fact]
    public void TestSerializeBinaryTree()
    {
        var node = new Node("root",
            new Node(
                "left",
                new Node("left.left")
            ),
            new Node("right"));
        
        var result = Node.Serialize(node);
        output.WriteLine(result);
        Assert.Equal("root left right left.left # # # # #", result);
    }

    [Fact]
    public void TestDeserializeBinaryTree()
    {
        var serialized = "root left right left.left # # # # #";
        var expected = new Node("root",
            new Node(
                "left",
                new Node("left.left")
            ),
            new Node("right"));
        
        var result = Node.Deserialize(serialized);

        Assert.Equal("left.left", result.Left.Left.Val);
    }

    [Fact]
    public void TestProductArrayExcludingI()
    {
        // Arrange
        var input = new List<int> { 1, 2, 3, 4, 5 };
        var expected = new List<int> { 120, 60, 40, 30, 24 };

        // Act
        var actual = DailyCode.Runner.ProductArrayExcludingI(input);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestContainsPairAddingToTarget()
    {
        // Arrange
        var inputList = new List<int> { 10, 15, 3, 7 };
        var target = 17;

        // Act
        var result = DailyCode.Runner.ContainsPairAddingToTarget(inputList, target);

        // Assert
        Assert.True(result);
    }
}