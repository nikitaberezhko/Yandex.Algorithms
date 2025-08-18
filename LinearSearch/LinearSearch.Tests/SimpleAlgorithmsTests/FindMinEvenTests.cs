namespace LinearSearch.Tests.SimpleAlgorithmsTests;

using Sut = LinearSearch.SimpleAlgorithms.SimpleAlgorithms;

public class FindMinEvenTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.FindMinEven(array));
    }

    [Fact]
    public void Return_null_when_array_is_empty()
    {
        // Arrange
        var array = new int[] { };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Return_minimum_even_from_positive_numbers()
    {
        // Arrange
        var array = new[] { 3, 7, 2, 9, 1, 8, 4 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Return_minimum_even_from_negative_numbers()
    {
        // Arrange
        var array = new[] { -5, -2, -8, -1, -10, -6 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(-10, result);
    }

    [Fact]
    public void Return_minimum_even_from_mixed_numbers()
    {
        // Arrange
        var array = new[] { -3, 5, -2, 8, -7, 2, -4 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(-4, result);
    }

    [Fact]
    public void Return_null_when_no_even_numbers()
    {
        // Arrange
        var array = new[] { 1, 3, 5, 7, 9, -1, -3 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Return_single_even_number()
    {
        // Arrange
        var array = new[] { 42 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void Return_minimum_even_when_duplicates_present()
    {
        // Arrange
        var array = new[] { 5, 8, 3, 8, 1, 8, 2, 2 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Return_minimum_even_with_boundary_values()
    {
        // Arrange
        var array = new[] { int.MinValue, 0, int.MaxValue, -100, 100, 2 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(int.MinValue, result);
    }

    [Fact]
    public void Return_minimum_even_when_at_start()
    {
        // Arrange
        var array = new[] { 2, 5, 3, 1, 8, 10 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Return_minimum_even_when_at_end()
    {
        // Arrange
        var array = new[] { 1, 3, 5, 10, 8, 2 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Return_null_when_all_numbers_are_odd()
    {
        // Arrange
        var array = new[] { 1, 3, 5, 7, 9, 11, 13 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Return_single_even_number_in_array()
    {
        // Arrange
        var array = new[] { 1, 3, 4, 5, 7 };

        // Act
        var result = Sut.FindMinEven(array);

        // Assert
        Assert.Equal(4, result);
    }
}