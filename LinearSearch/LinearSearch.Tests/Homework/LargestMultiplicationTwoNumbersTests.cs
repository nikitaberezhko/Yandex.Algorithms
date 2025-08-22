using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class LargestMultiplicationTwoNumbersTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.LargestMultiplicationTwoNumbers(array));
    }

    [Theory]
    [InlineData(new int[] { })]
    [InlineData(new int[] { 1 })]
    public void Throw_exception_when_array_length_less_than_two(int[] array)
    {
        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Sut.LargestMultiplicationTwoNumbers(array));
    }

    [Fact]
    public void Return_correct_result_for_zero_zero()
    {
        // Arrange
        var array = new[] { 0, 0 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((0, 0), result);
    }
    
    [Fact]
    public void Return_correct_result_for_example()
    {
        // Arrange
        var array = new[] { 4, 3, 5, 2, 5 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((5, 5), result);
    }

    [Fact]
    public void Return_correct_result_for_example_with_some_negative_numbers()
    {
        // Arrange
        var array = new[] { -4, 3, -5, 2, 5 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-5, -4), result);
    }

    [Fact]
    public void Return_correct_result_for_two_positive_numbers()
    {
        // Arrange
        var array = new[] { 10, 20 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((10, 20), result);
    }

    [Fact]
    public void Return_correct_result_for_two_negative_numbers()
    {
        // Arrange
        var array = new[] { -10, -20 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-20, -10), result);
    }

    [Fact]
    public void Return_correct_result_for_positive_and_negative_numbers()
    {
        // Arrange
        var array = new[] { 10, -20, 30, -40 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-40, -20), result);
    }

    [Fact]
    public void Return_correct_result_for_all_negative_numbers()
    {
        // Arrange
        var array = new[] { -1, -2, -3, -4, -5 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-5, -4), result);
    }

    [Fact]
    public void Return_correct_result_for_all_positive_numbers()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((4, 5), result);
    }

    [Fact]
    public void Return_correct_result_for_mixed_numbers_with_zeros()
    {
        // Arrange
        var array = new[] { 0, 1, -2, 3, -4 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-4, -2), result);
    }

    [Fact]
    public void Return_correct_result_for_duplicate_numbers()
    {
        // Arrange
        var array = new[] { 5, 5, 5, 5, 5 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((5, 5), result);
    }

    [Fact]
    public void Return_correct_result_for_large_numbers()
    {
        // Arrange
        var array = new[] { 1000000, 999999, 1000001, 999998 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((1000000, 1000001), result);
    }

    [Fact]
    public void Return_correct_result_for_small_numbers()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((3, 4), result);
    }

    [Fact]
    public void Return_correct_result_for_numbers_with_max_int_values()
    {
        // Arrange
        var array = new[] { int.MaxValue, int.MaxValue - 1, 1, 2 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((int.MaxValue - 1, int.MaxValue), result);
    }

    [Fact]
    public void Return_correct_result_for_numbers_with_min_int_values()
    {
        // Arrange
        var array = new[] { int.MinValue, int.MinValue + 1, -1, -2 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-2, -1), result);
    }

    [Fact]
    public void Return_correct_result_for_alternating_positive_negative()
    {
        // Arrange
        var array = new[] { 1, -1, 2, -2, 3 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((2, 3), result);
    }

    [Fact]
    public void Return_correct_result_for_three_elements()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((2, 3), result);
    }

    [Fact]
    public void Return_correct_result_for_three_elements_with_negatives()
    {
        // Arrange
        var array = new[] { -1, -2, -3 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-3, -2), result);
    }

    [Fact]
    public void Return_correct_result_for_mixed_case_with_large_negative_product()
    {
        // Arrange
        var array = new[] { -100, -99, 1, 2, 3 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-100, -99), result);
    }

    [Fact]
    public void Return_correct_result_for_mixed_case_with_large_positive_product()
    {
        // Arrange
        var array = new[] { 100, 99, -1, -2, -3 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((99, 100), result);
    }

    [Fact]
    public void Return_correct_result_for_array_with_one_positive_one_negative()
    {
        // Arrange
        var array = new[] { 5, -5 };

        // Act
        var result = Sut.LargestMultiplicationTwoNumbers(array);

        // Assert
        Assert.Equal((-5, 5), result);
    }
}
