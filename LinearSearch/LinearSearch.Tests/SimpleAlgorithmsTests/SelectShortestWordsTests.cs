namespace LinearSearch.Tests.SimpleAlgorithmsTests;

using Sut = LinearSearch.SimpleAlgorithms.SimpleAlgorithms;

public class SelectShortestWordsTests
{
    [Fact]
    public void Throw_exception_when_string_is_null()
    {
        // Arrange
        string str = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.SelectShortestWords(str));
    }

    [Fact]
    public void Return_empty_array_when_string_is_empty()
    {
        // Arrange
        var str = "";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Empty(result);
    }

    [Fact]
    public void Return_single_word_when_string_has_one_word()
    {
        // Arrange
        var str = "hello";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Single(result);
        Assert.Equal("hello", result[0]);
    }

    [Fact]
    public void Return_shortest_words_when_words_have_different_lengths()
    {
        // Arrange
        var str = "cat dog elephant bird";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Contains("cat", result);
        Assert.Contains("dog", result);
    }

    [Fact]
    public void Return_all_words_when_all_words_have_same_length()
    {
        // Arrange
        var str = "cat dog pig";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Equal(3, result.Length);
        Assert.Contains("cat", result);
        Assert.Contains("dog", result);
        Assert.Contains("pig", result);
    }

    [Fact]
    public void Return_shortest_words_in_different_positions()
    {
        // Arrange
        var str = "elephant cat dog bird";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Contains("cat", result);
        Assert.Contains("dog", result);
    }

    [Fact]
    public void Handle_single_character_words()
    {
        // Arrange
        var str = "a bc def";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Single(result);
        Assert.Equal("a", result[0]);
    }

    [Fact]
    public void Handle_words_with_minimum_length_at_start_and_end()
    {
        // Arrange
        var str = "cat elephant dog";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Equal(2, result.Length);
        Assert.Contains("cat", result);
        Assert.Contains("dog", result);
    }

    [Fact]
    public void Handle_duplicate_shortest_words()
    {
        // Arrange
        var str = "cat dog cat elephant";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Equal(3, result.Length);
        Assert.Equal(2, result.Count(w => w == "cat"));
        Assert.Contains("dog", result);
    }

    [Fact]
    public void Handle_words_with_special_characters()
    {
        // Arrange
        var str = "a! b@ c# def";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Equal(3, result.Length);
        Assert.Contains("a!", result);
        Assert.Contains("b@", result);
        Assert.Contains("c#", result);
    }

    [Fact]
    public void Handle_numbers_as_words()
    {
        // Arrange
        var str = "1 22 333 4444";

        // Act
        var result = Sut.SelectShortestWords(str);

        // Assert
        Assert.Single(result);
        Assert.Equal("1", result[0]);
    }
}
