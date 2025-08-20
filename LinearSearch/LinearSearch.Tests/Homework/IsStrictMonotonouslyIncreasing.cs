using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class IsStrictMonotonouslyIncreasing
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.IsStrictMonotonouslyIncreasing(array));
    }

    [Fact]
    public void Return_true_when_array_is_empty()
    {
        // Arrange
        var array = new int[] { };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Return_true_for_simple_increasing_sequence()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Return_false_for_monotonicity_sequence_with_equal_elements()
    {
        // Arrange
        var array = new[] { 1, 2, 2, 3, 4 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_true_for_sequence_with_boundary_values()
    {
        // Arrange
        var array = new[] { int.MinValue, -1000, 0, 1000, int.MaxValue };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Return_false_for_simple_decreasing_sequence()
    {
        // Arrange
        var array = new[] { 5, 4, 3, 2, 1 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_false_when_monotonicity_violated_in_middle()
    {
        // Arrange
        var array = new[] { 1, 2, 5, 3, 4 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_false_when_monotonicity_violated_at_end()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 2 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_false_when_monotonicity_violated_at_start()
    {
        // Arrange
        var array = new[] { 3, 1, 2, 4, 5 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_false_for_sequence_with_repeating_elements()
    {
        // Arrange
        var array = new[] { 1, 1, 1, 2, 2, 3, 3, 3 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_false_for_sequence_with_alternating_pattern()
    {
        // Arrange
        var array = new[] { 1, 3, 2, 4, 3, 5 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_false_for_sequence_with_all_equal_elements()
    {
        // Arrange
        var array = new[] { 5, 5, 5, 5, 5 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_false_for_sequence_with_single_violation()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 1, 4, 5 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void Return_true_for_sequence_with_negative_numbers()
    {
        // Arrange
        var array = new[] { -10, -5, 0, 5, 10 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void Return_false_for_sequence_with_negative_numbers_violation()
    {
        // Arrange
        var array = new[] { -5, -10, 0, 5, 10 };

        // Act
        var result = Sut.IsStrictMonotonouslyIncreasing(array);

        // Assert
        Assert.False(result);
    }
}
