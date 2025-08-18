namespace LinearSearch.Tests.SimpleAlgorithmsTests;

using Sut = LinearSearch.SimpleAlgorithms.SimpleAlgorithms;

public class FindFirstIndexTests
{
    [Fact]
    public void Return_first_index_when_target_at_start()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var index = Sut.FindFirstIndex(array, 1);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void Return_first_index_when_target_in_middle()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };

        // Act
        var index = Sut.FindFirstIndex(array, 3);

        // Assert
        Assert.Equal(2, index);
    }

    [Fact]
    public void Return_first_index_when_target_at_end()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var index = Sut.FindFirstIndex(array, 3);

        // Assert
        Assert.Equal(2, index);
    }

    [Fact]
    public void Return_first_index_with_duplicates()
    {
        // Arrange
        var array = new[] { 2, 2, 2 };

        // Act
        var index = Sut.FindFirstIndex(array, 2);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void Return_null_when_target_absent()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var index = Sut.FindFirstIndex(array, 4);

        // Assert
        Assert.Null(index);
    }

    [Fact]
    public void Return_null_when_array_is_empty()
    {
        // Arrange
        var array = Array.Empty<int>();

        // Act
        var index = Sut.FindFirstIndex(array, 1);

        // Assert
        Assert.Null(index);
    }

    [Fact]
    public void Return_first_index_for_negative_and_zero()
    {
        // Arrange
        var array = new[] { -3, -2, -1, 0, 1 };

        // Act
        var index = Sut.FindFirstIndex(array, -2);

        // Assert
        Assert.Equal(1, index);
    }

    [Fact]
    public void Return_first_index_for_int_boundaries()
    {
        // Arrange
        var array = new[] { int.MinValue, 0, int.MaxValue };

        // Act
        var index = Sut.FindFirstIndex(array, int.MaxValue);

        // Assert
        Assert.Equal(2, index);
    }

    [Fact]
    public void Throw_ArgumentNullException_if_array_is_null()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.FindFirstIndex(null!, 0));
    }
}