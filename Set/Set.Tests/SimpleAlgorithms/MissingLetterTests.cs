namespace Set.Tests;

using Sut = Set.SimpleAlgorithms.SimpleAlgorithms;

public class MissingLetterTests
{
    [Fact]
    public void Throw_argument_null_exception_when_dictionary_is_null()
    {
        // Arrange
        string[] dictionary = null;
        var words = new[] { "test" };

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.MissingLetter(dictionary, words));
    }

    [Fact]
    public void Throw_argument_null_exception_when_words_is_null()
    {
        // Arrange
        var dictionary = new[] { "test" };
        string[] words = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.MissingLetter(dictionary, words));
    }

    [Fact]
    public void Throw_argument_out_of_range_exception_when_dictionary_is_empty()
    {
        // Arrange
        var dictionary = new string[] { };
        var words = new[] { "test" };

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Sut.MissingLetter(dictionary, words));
    }

    [Fact]
    public void Throw_argument_out_of_range_exception_when_words_is_empty()
    {
        // Arrange
        var dictionary = new[] { "test" };
        var words = new string[] { };

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Sut.MissingLetter(dictionary, words));
    }

    [Fact]
    public void Return_true_for_exact_match_in_dictionary()
    {
        // Arrange
        var dictionary = new[] { "hello", "world" };
        var words = new[] { "hello" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("hello", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_false_for_word_not_in_dictionary()
    {
        // Arrange
        var dictionary = new[] { "hello", "world" };
        var words = new[] { "test" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("test", result[0].words);
        Assert.False(result[0].found);
    }

    [Fact]
    public void Return_true_for_word_with_one_missing_letter()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "ello" }; // пропущена первая буква 'h'

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("ello", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_true_for_word_with_missing_letter_in_middle()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "helo" }; // пропущена буква 'l' в середине

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("helo", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_true_for_word_with_missing_letter_at_end()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "hell" }; // пропущена последняя буква 'o'

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("hell", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_false_for_word_with_multiple_missing_letters()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "hel" }; // пропущены две буквы 'l' и 'o'

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("hel", result[0].words);
        Assert.False(result[0].found);
    }

    [Fact]
    public void Return_true_for_single_letter_word_in_dictionary()
    {
        // Arrange
        var dictionary = new[] { "a", "hello" };
        var words = new[] { "a" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("a", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_false_for_single_letter_word_not_in_dictionary()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "a" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("a", result[0].words);
        Assert.False(result[0].found);
    }

    [Fact]
    public void Return_true_for_two_letter_word_with_missing_letter()
    {
        // Arrange
        var dictionary = new[] { "ab" };
        var words = new[] { "a" }; // пропущена буква 'b'

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("a", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_true_for_two_letter_word_with_missing_first_letter()
    {
        // Arrange
        var dictionary = new[] { "ab" };
        var words = new[] { "b" }; // пропущена буква 'a'

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("b", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_correct_results_for_multiple_words()
    {
        // Arrange
        var dictionary = new[] { "hello", "world" };
        var words = new[] { "hello", "ello", "world", "worl", "test" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Equal(5, result.Count);
        Assert.Equal("hello", result[0].words);
        Assert.True(result[0].found);
        Assert.Equal("ello", result[1].words);
        Assert.True(result[1].found);
        Assert.Equal("world", result[2].words);
        Assert.True(result[2].found);
        Assert.Equal("worl", result[3].words);
        Assert.True(result[3].found);
        Assert.Equal("test", result[4].words);
        Assert.False(result[4].found);
    }

    [Fact]
    public void Return_correct_results_for_duplicate_words_in_dictionary()
    {
        // Arrange
        var dictionary = new[] { "hello", "hello", "world" };
        var words = new[] { "hello", "ello" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("hello", result[0].words);
        Assert.True(result[0].found);
        Assert.Equal("ello", result[1].words);
        Assert.True(result[1].found);
    }

    [Fact]
    public void Return_correct_results_for_duplicate_words_to_check()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "hello", "hello", "ello" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.Equal("hello", result[0].words);
        Assert.True(result[0].found);
        Assert.Equal("hello", result[1].words);
        Assert.True(result[1].found);
        Assert.Equal("ello", result[2].words);
        Assert.True(result[2].found);
    }

    [Fact]
    public void Return_false_for_word_longer_than_dictionary_words()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "helloo" }; // на одну букву длиннее

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("helloo", result[0].words);
        Assert.False(result[0].found);
    }

    [Fact]
    public void Return_true_for_all_variants_of_missing_letters()
    {
        // Arrange
        var dictionary = new[] { "abc" };
        var words = new[] { "bc", "ac", "ab" }; // все варианты с одной пропущенной буквой

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Equal(3, result.Count);
        Assert.All(result, item => Assert.True(item.found));
    }

    [Fact]
    public void Return_correct_results_for_empty_strings()
    {
        // Arrange
        var dictionary = new[] { "" };
        var words = new[] { "" };

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("", result[0].words);
        Assert.True(result[0].found);
    }

    [Fact]
    public void Return_false_for_word_with_different_letters()
    {
        // Arrange
        var dictionary = new[] { "hello" };
        var words = new[] { "hallo" }; // отличается на одну букву, но не является вариантом с пропущенной буквой

        // Act
        var result = Sut.MissingLetter(dictionary, words);

        // Assert
        Assert.Single(result);
        Assert.Equal("hallo", result[0].words);
        Assert.False(result[0].found);
    }
}
