using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class DetermineTypeSeqTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.DetermineTypeSeq(array));
    }

    [Fact]
    public void Return_constant_for_empty_array()
    {
        // Arrange
        var array = new int[] { };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Constant, result);
    }

    [Fact]
    public void Return_constant_for_single_element_array()
    {
        // Arrange
        var array = new[] { 42 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Constant, result);
    }

    [Fact]
    public void Return_constant_for_sequence_with_identical_elements()
    {
        // Arrange
        var array = new[] { 5, 5, 5, 5, 5 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Constant, result);
    }

    [Fact]
    public void Return_ascending_for_strictly_increasing_sequence()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Ascending, result);
    }

    [Fact]
    public void Return_weakly_ascending_for_non_strictly_increasing_sequence()
    {
        // Arrange
        var array = new[] { 1, 2, 2, 3, 4 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.WeaklyAscending, result);
    }

    [Fact]
    public void Return_descending_for_strictly_decreasing_sequence()
    {
        // Arrange
        var array = new[] { 5, 4, 3, 2, 1 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Descending, result);
    }

    [Fact]
    public void Return_weakly_descending_for_non_strictly_decreasing_sequence()
    {
        // Arrange
        var array = new[] { 5, 4, 4, 3, 2 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.WeaklyDescending, result);
    }

    [Fact]
    public void Return_random_for_sequence_not_belonging_to_any_type()
    {
        // Arrange
        var array = new[] { 1, 3, 2, 4, 1 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Random, result);
    }

    [Fact]
    public void Return_random_for_sequence_with_fluctuating_values()
    {
        // Arrange
        var array = new[] { 1, 5, 2, 8, 3 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Random, result);
    }

    [Fact]
    public void Return_ascending_for_sequence_with_boundary_values()
    {
        // Arrange
        var array = new[] { int.MinValue, -1000, 0, 1000, int.MaxValue };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Ascending, result);
    }

    [Fact]
    public void Return_descending_for_sequence_with_boundary_values_reversed()
    {
        // Arrange
        var array = new[] { int.MaxValue, 1000, 0, -1000, int.MinValue };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Descending, result);
    }

    [Fact]
    public void Return_weakly_ascending_for_sequence_with_repeated_elements_at_start()
    {
        // Arrange
        var array = new[] { 1, 1, 2, 3, 4 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.WeaklyAscending, result);
    }

    [Fact]
    public void Return_weakly_ascending_for_sequence_with_repeated_elements_at_end()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 4 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.WeaklyAscending, result);
    }

    [Fact]
    public void Return_weakly_descending_for_sequence_with_repeated_elements_at_start()
    {
        // Arrange
        var array = new[] { 5, 5, 4, 3, 2 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.WeaklyDescending, result);
    }

    [Fact]
    public void Return_weakly_descending_for_sequence_with_repeated_elements_at_end()
    {
        // Arrange
        var array = new[] { 5, 4, 3, 2, 2 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.WeaklyDescending, result);
    }

    [Fact]
    public void Return_constant_for_sequence_with_all_zeros()
    {
        // Arrange
        var array = new[] { 0, 0, 0, 0, 0 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Constant, result);
    }

    [Fact]
    public void Return_constant_for_sequence_with_all_negative_values()
    {
        // Arrange
        var array = new[] { -5, -5, -5, -5, -5 };

        // Act
        var result = Sut.DetermineTypeSeq(array);

        // Assert
        Assert.Equal(Sut.TypeSequence.Constant, result);
    }
}
