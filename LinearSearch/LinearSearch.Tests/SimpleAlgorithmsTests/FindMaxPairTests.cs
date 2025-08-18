namespace LinearSearch.Tests.SimpleAlgorithmsTests;

using Sut = LinearSearch.SimpleAlgorithms.SimpleAlgorithms;

public class FindMaxPairTests
{
    [Fact]
    public void Return_correct_pair_for_two_elements()
    {
        // Arrange
        var array = new[] { 3, 1 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(3, result.Max);
        Assert.Equal(1, result.SecondMax);
    }

    [Fact]
    public void Return_correct_pair_when_max_at_start()
    {
        // Arrange
        var array = new[] { 10, 3, 5, 1 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(10, result.Max);
        Assert.Equal(5, result.SecondMax);
    }

    [Fact]
    public void Return_correct_pair_when_max_at_end()
    {
        // Arrange
        var array = new[] { 1, 3, 5, 10 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(10, result.Max);
        Assert.Equal(5, result.SecondMax);
    }

    [Fact]
    public void Return_correct_pair_when_max_in_middle()
    {
        // Arrange
        var array = new[] { 3, 10, 5, 1 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(10, result.Max);
        Assert.Equal(5, result.SecondMax);
    }

    [Fact]
    public void Return_correct_pair_with_duplicate_max_values()
    {
        // Arrange
        var array = new[] { 10, 5, 10, 3 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(10, result.Max);
        Assert.Equal(10, result.SecondMax);
    }

    [Fact]
    public void Return_correct_pair_with_negative_numbers()
    {
        // Arrange
        var array = new[] { -5, -1, -10, -3 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(-1, result.Max);
        Assert.Equal(-3, result.SecondMax);
    }

    [Fact]
    public void Return_correct_pair_for_int_boundaries()
    {
        // Arrange
        var array = new[] { int.MinValue, 0, int.MaxValue, 100 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(int.MaxValue, result.Max);
        Assert.Equal(100, result.SecondMax);
    }

    [Fact]
    public void Return_correct_pair_when_all_elements_same()
    {
        // Arrange
        var array = new[] { 5, 5, 5, 5 };

        // Act
        var result = Sut.FindMaxPair(array);

        // Assert
        Assert.Equal(5, result.Max);
        Assert.Equal(5, result.SecondMax);
    }

    [Fact]
    public void Throw_ArgumentNullException_when_array_is_null()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.FindMaxPair(null!));
    }

    [Fact]
    public void Throw_ArgumentOutOfRangeException_when_array_is_empty()
    {
        // Arrange
        var array = Array.Empty<int>();

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Sut.FindMaxPair(array));
    }

    [Fact]
    public void Throw_ArgumentOutOfRangeException_when_array_has_one_element()
    {
        // Arrange
        var array = new[] { 42 };

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Sut.FindMaxPair(array));
    }
}