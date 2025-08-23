using LinearSearch.Homework;

namespace LinearSearch.Tests.Homework;

using Sut = HomeworkAlgorithms;

public class TriangleOfMaximTests
{
    [Fact]
    public void Test1_Should_Return_Correct_Interval()
    {
        // Arrange
        var comparisons = new List<(int frequency, string result)>
        {
            (440, ""), // Первая нота без сравнения
            (220, "closer"),
            (300, "further")
        };

        // Act
        var result = Sut.TriangleOfMaxim(comparisons);

        // Assert
        Assert.Equal(30.0, result.Item1, 6); // minFrequency
        Assert.Equal(260.0, result.Item2, 6); // maxFrequency
    }

    [Fact]
    public void Test2_Should_Return_Correct_Interval()
    {
        // Arrange
        var comparisons = new List<(int frequency, string result)>
        {
            (554, ""), // Первая нота без сравнения
            (880, "further"),
            (440, "closer"),
            (622, "closer")
        };

        // Act
        var result = Sut.TriangleOfMaxim(comparisons);

        // Assert
        Assert.Equal(531.0, result.Item1, 6); // minFrequency
        Assert.Equal(660.0, result.Item2, 6); // maxFrequency
    }
}
