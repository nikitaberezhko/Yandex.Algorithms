using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class SymmetricalSeqTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] array = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.SymmetricalSeq(array));
    }

    [Theory]
    [InlineData(new int[] { })]
    [InlineData(new int[] { 1 })]
    [InlineData(new int[] { 1, 2 })]
    public void Return_empty_sequence_when_array_length_less_than_three(int[] array)
    {
        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(0, result.QuantityForAdd);
        Assert.Null(result.NumbersForAdd);
    }

    [Fact]
    public void Return_empty_sequence_when_array_is_already_symmetrical()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 2, 1 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(0, result.QuantityForAdd);
        Assert.Empty(result.NumbersForAdd);
    }

    [Fact]
    public void Return_empty_sequence_when_array_has_symmetrical_pattern()
    {
        // Arrange
        var array = new[] { 1, 2, 1, 2, 2, 1, 2, 1 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(0, result.QuantityForAdd);
        Assert.Empty(result.NumbersForAdd);
    }

    [Fact]
    public void Return_correct_sequence_for_simple_non_symmetrical_array()
    {
        // Arrange
        var array = new[] { 1, 2, 3 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(2, result.QuantityForAdd);
        Assert.Equal(2, result.NumbersForAdd.Length);
        Assert.Equal(2, result.NumbersForAdd[0]);
        Assert.Equal(1, result.NumbersForAdd[1]);
    }

    [Fact]
    public void Return_correct_sequence_for_array_with_partial_symmetry()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 3, 2 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(1, result.QuantityForAdd);
        Assert.Equal(1, result.NumbersForAdd.Length);
        Assert.Equal(1, result.NumbersForAdd[0]);
    }

    [Fact]
    public void Return_correct_sequence_for_array_with_all_same_elements()
    {
        // Arrange
        var array = new[] { 5, 5, 5, 5 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(0, result.QuantityForAdd);
        Assert.Empty(result.NumbersForAdd);
    }

    [Fact]
    public void Return_correct_sequence_for_strictly_increasing_array()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(4, result.QuantityForAdd);
        Assert.Equal(4, result.NumbersForAdd.Length);
        Assert.Equal(4, result.NumbersForAdd[0]);
        Assert.Equal(3, result.NumbersForAdd[1]);
        Assert.Equal(2, result.NumbersForAdd[2]);
        Assert.Equal(1, result.NumbersForAdd[3]);
    }

    [Fact]
    public void Return_correct_sequence_for_strictly_decreasing_array()
    {
        // Arrange
        var array = new[] { 5, 4, 3, 2, 1 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(4, result.QuantityForAdd);
        Assert.Equal(4, result.NumbersForAdd.Length);
        Assert.Equal(2, result.NumbersForAdd[0]);
        Assert.Equal(3, result.NumbersForAdd[1]);
        Assert.Equal(4, result.NumbersForAdd[2]);
        Assert.Equal(5, result.NumbersForAdd[3]);
    }

    [Fact]
    public void Return_correct_sequence_for_complex_pattern()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 1 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(3, result.QuantityForAdd);
        Assert.Equal(3, result.NumbersForAdd.Length);
        Assert.Equal(3, result.NumbersForAdd[0]);
        Assert.Equal(2, result.NumbersForAdd[1]);
        Assert.Equal(1, result.NumbersForAdd[2]);
    }

    [Fact]
    public void Return_correct_sequence_for_array_with_repeating_elements()
    {
        // Arrange
        var array = new[] { 1, 1, 2, 2, 1 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(1, result.QuantityForAdd);
        Assert.Equal(1, result.NumbersForAdd.Length);
        Assert.Equal(1, result.NumbersForAdd[0]);
    }

    [Fact]
    public void Return_correct_sequence_for_large_array()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(9, result.QuantityForAdd);
        Assert.Equal(9, result.NumbersForAdd.Length);
        Assert.Equal(9, result.NumbersForAdd[0]);
        Assert.Equal(8, result.NumbersForAdd[1]);
        Assert.Equal(7, result.NumbersForAdd[2]);
        Assert.Equal(6, result.NumbersForAdd[3]);
        Assert.Equal(5, result.NumbersForAdd[4]);
        Assert.Equal(4, result.NumbersForAdd[5]);
        Assert.Equal(3, result.NumbersForAdd[6]);
        Assert.Equal(2, result.NumbersForAdd[7]);
        Assert.Equal(1, result.NumbersForAdd[8]);
    }

    [Fact]
    public void Return_correct_sequence_for_array_with_alternating_pattern()
    {
        // Arrange
        var array = new[] { 1, 0, 1, 0, 1 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(0, result.QuantityForAdd);
        Assert.Empty(result.NumbersForAdd);
    }

    [Fact]
    public void Return_correct_sequence_for_array_with_center_symmetry()
    {
        // Arrange
        var array = new[] { 1, 2, 3, 4, 3, 2, 1, 5 };

        // Act
        var result = Sut.SymmetricalSeq(array);

        // Assert
        Assert.Equal(7, result.QuantityForAdd);
        Assert.Equal(7, result.NumbersForAdd.Length);
        Assert.Equal(1, result.NumbersForAdd[0]);
        Assert.Equal(2, result.NumbersForAdd[1]);
        Assert.Equal(3, result.NumbersForAdd[2]);
        Assert.Equal(4, result.NumbersForAdd[3]);
        Assert.Equal(3, result.NumbersForAdd[4]);
        Assert.Equal(2, result.NumbersForAdd[5]);
        Assert.Equal(1, result.NumbersForAdd[6]);
    }
}
