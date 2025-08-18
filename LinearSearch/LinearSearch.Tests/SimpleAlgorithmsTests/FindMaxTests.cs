namespace LinearSearch.Tests.SimpleAlgorithmsTests;

using Sut = LinearSearch.SimpleAlgorithms.SimpleAlgorithms;

public class FindMaxTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.FindMax(array));
    }

    [Fact]
    public void Return_null_when_array_is_empty()
    {
        // Arrange
        var array = new int[] { };

        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void Return_single_element_when_array_has_one_element()
    {
        // Arrange
        var array = new[] { 42 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void Return_maximum_from_positive_numbers()
    {
        // Arrange
        var array = new[] { 3, 7, 2, 9, 1 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Return_maximum_from_negative_numbers()
    {
        // Arrange
        var array = new[] { -5, -2, -8, -1, -10 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(-1, result);
    }

    [Fact]
    public void Return_maximum_from_mixed_positive_and_negative()
    {
        // Arrange
        var array = new[] { -3, 5, -1, 8, -7, 2 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Return_maximum_when_duplicates_present()
    {
        // Arrange
        var array = new[] { 5, 9, 3, 9, 1, 9 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Return_maximum_with_boundary_values()
    {
        // Arrange
        var array = new[] { int.MinValue, 0, int.MaxValue, -100, 100 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(int.MaxValue, result);
    }

    [Fact]
    public void Return_minimum_boundary_when_only_minimum_values()
    {
        // Arrange
        var array = new[] { int.MinValue, int.MinValue };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(int.MinValue, result);
    }

    [Fact]
    public void Return_maximum_when_maximum_at_start()
    {
        // Arrange
        var array = new[] { 10, 5, 3, 1 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void Return_maximum_when_maximum_at_end()
    {
        // Arrange
        var array = new[] { 1, 3, 5, 10 };


        // Act
        var result = Sut.FindMax(array);

        // Assert
        Assert.Equal(10, result);
    }
}