namespace LinearSearch.Tests;

using Sut = LinearSearch.Rle;

public class RleTests
{
    [Fact]
    public void Throw_exception_when_input_is_null()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.Compress(input));
    }

    [Fact]
    public void Return_empty_string_when_input_is_empty()
    {
        // Arrange
        var input = string.Empty;

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal(string.Empty, result);
    }

    [Fact]
    public void Return_single_character_when_input_has_one_character()
    {
        // Arrange
        var input = "a";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("a", result);
    }

    [Fact]
    public void Compress_repeated_characters()
    {
        // Arrange
        var input = "aaa";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("a3", result);
    }

    [Fact]
    public void Compress_mixed_repeated_and_single_characters()
    {
        // Arrange
        var input = "aaab";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("a3b", result);
    }

    [Fact]
    public void Compress_multiple_groups_of_repeated_characters()
    {
        // Arrange
        var input = "aaabbb";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("a3b3", result);
    }

    [Fact]
    public void Compress_alternating_single_characters()
    {
        // Arrange
        var input = "abab";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("abab", result);
    }

    [Fact]
    public void Compress_complex_pattern()
    {
        // Arrange
        var input = "aaabbbcccd";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("a3b3c3d", result);
    }

    [Fact]
    public void Compress_numbers_as_characters()
    {
        // Arrange
        var input = "111222333";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("132333", result);
    }

    [Fact]
    public void Compress_special_characters()
    {
        // Arrange
        var input = "!!!@@@###";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("!3@3#3", result);
    }

    [Fact]
    public void Compress_single_character_at_end()
    {
        // Arrange
        var input = "aaab";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("a3b", result);
    }

    [Fact]
    public void Compress_single_character_at_start()
    {
        // Arrange
        var input = "abbb";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("ab3", result);
    }

    [Fact]
    public void Compress_all_single_characters()
    {
        // Arrange
        var input = "abcdef";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("abcdef", result);
    }

    [Fact]
    public void Compress_large_repetition()
    {
        // Arrange
        var input = new string('a', 10);

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("a10", result);
    }

    [Fact]
    public void Compress_mixed_case_characters()
    {
        // Arrange
        var input = "AAAaaaBBBbbb";

        // Act
        var result = Sut.Compress(input);

        // Assert
        Assert.Equal("A3a3B3b3", result);
    }
}