using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class FindNearestNumberTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;
        var target = 5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Sut.FindNearestNumber(array, target));
    }

    [Fact]
    public void Throw_exception_when_array_is_empty()
    {
        // Arrange
        var array = new int[] { };
        var target = 5;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Sut.FindNearestNumber(array, target));
    }

    [Fact]
    public void Return_single_element_when_array_has_one_element()
    {
        // Arrange
        var array = new[] { 42 };
        var target = 100;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void Return_exact_match_when_target_exists_in_array()
    {
        // Arrange
        var array = new[] { 1, 5, 10, 15, 20 };
        var target = 10;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void Return_nearest_element_smaller_than_target()
    {
        // Arrange
        var array = new[] { 1, 3, 7, 12, 18 };
        var target = 10;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(12, result);
    }

    [Fact]
    public void Return_nearest_element_larger_than_target()
    {
        // Arrange
        var array = new[] { 5, 10, 15, 20, 25 };
        var target = 12;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void Return_any_element_when_multiple_elements_have_same_distance()
    {
        // Arrange
        var array = new[] { 8, 12, 16 };
        var target = 10;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Contains(result, new[] { 8, 12 });
    }

    [Fact]
    public void Handle_negative_numbers()
    {
        // Arrange
        var array = new[] { -10, -5, 0, 5, 10 };
        var target = -3;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(-5, result);
    }

    [Fact]
    public void Handle_mixed_positive_and_negative_numbers()
    {
        // Arrange
        var array = new[] { -20, -10, 0, 10, 20 };
        var target = 15;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void Handle_large_numbers()
    {
        // Arrange
        var array = new[] { 1000, 500, 750, 250 };
        var target = 600;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(500, result);
    }

    [Fact]
    public void Handle_negative_target()
    {
        // Arrange
        var array = new[] { 1, 5, 10, 15 };
        var target = -5;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(1, result);
    }

    [Fact]
    public void Handle_zero_target()
    {
        // Arrange
        var array = new[] { -5, -2, 3, 8 };
        var target = 0;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(-2, result);
    }

    [Fact]
    public void Handle_duplicate_elements()
    {
        // Arrange
        var array = new[] { 5, 5, 10, 10, 15 };
        var target = 7;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Handle_edge_case_with_maximum_values()
    {
        // Arrange
        var array = new[] { 1000, -1000, 999, -999 };
        var target = 0;

        // Act
        var result = Sut.FindNearestNumber(array, target);

        // Assert
        Assert.Contains(result, new[] { 999, -999 });
    }
}
