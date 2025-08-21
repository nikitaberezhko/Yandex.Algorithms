using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class GreaterThanNeighborsTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Sut.GreaterThanNeighbors(array));
    }

    [Theory]
    [InlineData(new int[] { })]
    [InlineData(new int[] { 1 })]
    [InlineData(new int[] { 1, 2 })]
    public void Return_zero_when_array_length_less_than_three(int[] array)
    {
        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_no_element_greater_than_neighbors()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_one_when_middle_element_greater_than_neighbors()
    {
        // Arrange
        var array = new[] { 1, 3, 2 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Return_zero_when_all_elements_are_equal()
    {
        // Arrange
        var array = new[] { 5, 5, 5, 5, 5 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_array_is_strictly_increasing()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_array_is_strictly_decreasing()
    {
        // Arrange
        var array = new[] { 5, 4, 3, 2, 1 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_multiple_elements_greater_than_neighbors()
    {
        // Arrange
        var array = new[] { 1, 3, 2, 5, 3, 7, 4 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Return_zero_when_only_first_element_greater_than_neighbors()
    {
        // Arrange
        var array = new[] { 5, 2, 3, 4, 6 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_only_last_element_greater_than_neighbors()
    {
        // Arrange
        var array = new[] { 1, 2, 2, 2, 5 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_elements_greater_than_neighbors_at_beginning_and_end()
    {
        // Arrange
        var array = new[] { 5, 2, 2, 2, 7 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_adjacent_elements_are_equal()
    {
        // Arrange
        var array = new[] { 1, 2, 2, 3, 4 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_one_when_element_greater_than_equal_neighbors()
    {
        // Arrange
        var array = new[] { 2, 3, 2, 2, 4 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Return_zero_when_no_element_strictly_greater_than_neighbors()
    {
        // Arrange
        var array = new[] { 2, 2, 2, 2, 2 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_three_when_multiple_peaks_in_array()
    {
        // Arrange
        var array = new[] { 1, 3, 1, 4, 1, 5, 1 };

        // Act
        var result = Sut.GreaterThanNeighbors(array);

        // Assert
        Assert.Equal(3, result);
    }
}
