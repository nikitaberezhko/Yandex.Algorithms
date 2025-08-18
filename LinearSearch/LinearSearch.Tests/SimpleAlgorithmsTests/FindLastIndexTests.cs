namespace LinearSearch.Tests.SimpleAlgorithmsTests;

using Sut = LinearSearch.SimpleAlgorithms.SimpleAlgorithms;

public class FindLastIndexTests
{
    [Fact]
    public void Return_last_index_when_target_at_start()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var index = Sut.FindLastIndex(array, 1);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void Return_last_index_when_target_in_middle()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };

        // Act
        var index = Sut.FindLastIndex(array, 3);

        // Assert
        Assert.Equal(2, index);
    }

    [Fact]
    public void Return_last_index_when_target_at_end()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var index = Sut.FindLastIndex(array, 3);

        // Assert
        Assert.Equal(2, index);
    }

    [Fact]
    public void Return_last_index_with_duplicates()
    {
        // Arrange
        var array = new[] { 2, 3, 2, 4, 2 };

        // Act
        var index = Sut.FindLastIndex(array, 2);

        // Assert
        Assert.Equal(4, index);
    }

    [Fact]
    public void Return_last_index_with_all_duplicates()
    {
        // Arrange
        var array = new[] { 2, 2, 2 };

        // Act
        var index = Sut.FindLastIndex(array, 2);

        // Assert
        Assert.Equal(2, index);
    }

    [Fact]
    public void Return_null_when_target_absent()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var index = Sut.FindLastIndex(array, 4);

        // Assert
        Assert.Null(index);
    }

    [Fact]
    public void Return_null_when_array_is_empty()
    {
        // Arrange
        var array = Array.Empty<int>();

        // Act
        var index = Sut.FindLastIndex(array, 1);

        // Assert
        Assert.Null(index);
    }

    [Fact]
    public void Return_last_index_for_negative_and_zero()
    {
        // Arrange
        var array = new[] { -3, -2, -1, 0, 1, -2 };

        // Act
        var index = Sut.FindLastIndex(array, -2);

        // Assert
        Assert.Equal(5, index);
    }

    [Fact]
    public void Return_last_index_for_int_boundaries()
    {
        // Arrange
        var array = new[] { int.MinValue, 0, int.MaxValue, int.MinValue };

        // Act
        var index = Sut.FindLastIndex(array, int.MinValue);

        // Assert
        Assert.Equal(3, index);
    }

    [Fact]
    public void Return_last_index_for_zero_values()
    {
        // Arrange
        var array = new[] { 0, 1, 0, 2, 0 };

        // Act
        var index = Sut.FindLastIndex(array, 0);

        // Assert
        Assert.Equal(4, index);
    }

    [Fact]
    public void Return_zero_when_zero_is_first_element()
    {
        // Arrange
        var array = new[] { 0, 1, 2 };

        // Act
        var index = Sut.FindLastIndex(array, 0);

        // Assert
        Assert.Equal(0, index);
    }

    [Fact]
    public void Throw_ArgumentNullException_if_array_is_null()
    {
        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.FindLastIndex(null!, 0));
    }
}