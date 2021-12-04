using System.Collections.Generic;
using Xunit;
using DailyCode.BinaryTree;
using DailyCode;
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
    public void TestGcd()
    {
        int expected = 14;
        int[] numbers = new int[] { 42, 56, 14 };

        int actual = Mathematical.Gcd(numbers);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestGcd2()
    {
        int expected = 4;
        int[] numbers = new int[] { 4, 12, 24 };

        int actual = Mathematical.Gcd(numbers);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestGcdReturns1WhenNoGcd()
    {
        int expected = 1;
        int[] numbers = new int[] { 3, 5, 18 };

        int actual = Mathematical.Gcd(numbers);
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestGcd3()
    {
        int expected = 2;
        int[] numbers = new int[] { 4, 8, 6 };

        int actual = Mathematical.Gcd(numbers);
        Assert.Equal(expected, actual);
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
        var actual = DailyCode.Array.ProductArrayExcludingI(input);

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
        var result = DailyCode.Array.ContainsPairAddingToTarget(inputList, target);

        // Assert
        Assert.True(result);
    }
}