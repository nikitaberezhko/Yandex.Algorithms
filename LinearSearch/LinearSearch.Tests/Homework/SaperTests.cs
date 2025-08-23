using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class SaperTests
{
    [Fact]
    public void Test1_3x2_field_with_2_mines()
    {
        // Arrange
        int n = 3, m = 2, k = 2;
        var mines = new List<(int p, int q)> { (1, 1), (2, 2) };
        var expected = new int[,] 
        { 
            { -1, 2 }, 
            { 2, -1 }, 
            { 1, 1 } 
        };

        // Act
        var result = Sut.Saper(n, m, k, mines);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test2_2x2_field_with_no_mines()
    {
        // Arrange
        int n = 2, m = 2, k = 0;
        var mines = new List<(int p, int q)>();
        var expected = new int[,] 
        { 
            { 0, 0 }, 
            { 0, 0 } 
        };

        // Act
        var result = Sut.Saper(n, m, k, mines);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Test3_4x4_field_with_4_mines()
    {
        // Arrange
        int n = 4, m = 4, k = 4;
        var mines = new List<(int p, int q)> { (1, 3), (2, 1), (4, 2), (4, 4) };
        var expected = new int[,] 
        { 
            { 1, 2, -1, 1 }, 
            { -1, 2, 1, 1 }, 
            { 2, 2, 2, 1 }, 
            { 1, -1, 2, -1 } 
        };

        // Act
        var result = Sut.Saper(n, m, k, mines);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(expected, result);
    }
}
