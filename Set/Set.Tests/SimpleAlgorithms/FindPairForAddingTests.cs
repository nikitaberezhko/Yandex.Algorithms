namespace Set.Tests;

using Sut = Set.SimpleAlgorithms.SimpleAlgorithms;

public class FindPairForAddingTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;
        var targetSum = 10;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.FindPairForAdding(array, targetSum));
    }

    [Fact]
    public void Return_zero_pair_when_array_is_empty()
    {
        // Arrange
        var array = new int[] { };
        var targetSum = 10;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.Equal((0, 0), result);
    }

    [Fact]
    public void Return_zero_pair_when_array_has_single_element()
    {
        // Arrange
        var array = new[] { 5 };
        var targetSum = 10;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.Equal((0, 0), result);
    }

    [Fact]
    public void Return_zero_pair_when_no_pair_found()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4 };
        var targetSum = 10;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.Equal((0, 0), result);
    }

    [Fact]
    public void Return_correct_pair_when_pair_exists()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };
        var targetSum = 7;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.True(result.Item1 + result.Item2 == targetSum);
        Assert.Contains(result.Item1, array);
        Assert.Contains(result.Item2, array);
    }

    [Fact]
    public void Return_correct_pair_with_negative_numbers()
    {
        // Arrange
        var array = new[] { -5, -2, 0, 3, 7 };
        var targetSum = 1;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.True(result.Item1 + result.Item2 == targetSum);
        Assert.Contains(result.Item1, array);
        Assert.Contains(result.Item2, array);
    }

    [Fact]
    public void Return_zero_zero_pair_with_duplicate_elements()
    {
        // Arrange
        var array = new[] { 2, 2, 3, 4, 5 };
        var targetSum = 4;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.Equal((0, 0), result);
    }

    [Fact]
    public void Return_zero_pair_when_target_sum_is_double_of_single_element()
    {
        // Arrange
        var array = new[] { 5 };
        var targetSum = 10;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.Equal((0, 0), result);
    }

    [Fact]
    public void Return_correct_pair_with_large_numbers()
    {
        // Arrange
        var array = new[] { 1000000, 2000000, 3000000, 4000000 };
        var targetSum = 5000000;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.True(result.Item1 + result.Item2 == targetSum);
        Assert.Contains(result.Item1, array);
        Assert.Contains(result.Item2, array);
    }

    [Fact]
    public void Return_correct_pair_with_boundary_values()
    {
        // Arrange
        var array = new[] { int.MinValue, 0, int.MaxValue };
        var targetSum = int.MaxValue;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.True(result.Item1 + result.Item2 == targetSum);
        Assert.Contains(result.Item1, array);
        Assert.Contains(result.Item2, array);
    }

    [Fact]
    public void Return_correct_pair_when_target_sum_is_zero()
    {
        // Arrange
        var array = new[] { -5, -3, 0, 3, 5 };
        var targetSum = 0;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.True(result.Item1 + result.Item2 == targetSum);
        Assert.Contains(result.Item1, array);
        Assert.Contains(result.Item2, array);
    }

    [Fact]
    public void Return_correct_pair_with_multiple_possible_pairs()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5, 6 };
        var targetSum = 7;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.True(result.Item1 + result.Item2 == targetSum);
        Assert.Contains(result.Item1, array);
        Assert.Contains(result.Item2, array);
    }

    [Fact]
    public void Return_zero_pair_when_all_elements_are_same_and_no_pair()
    {
        // Arrange
        var array = new[] { 3, 3, 3, 3 };
        var targetSum = 7;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.Equal((0, 0), result);
    }

    [Fact]
    public void Return_correct_pair_with_very_small_array()
    {
        // Arrange
        var array = new[] { 1, 2 };
        var targetSum = 3;

        // Act
        var result = Sut.FindPairForAdding(array, targetSum);

        // Assert
        Assert.True(result.Item1 + result.Item2 == targetSum);
        Assert.Contains(result.Item1, array);
        Assert.Contains(result.Item2, array);
    }
}
