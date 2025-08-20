namespace LinearSearch.Tests.SimpleAlgorithmsTests;

using Sut = LinearSearch.SimpleAlgorithms.SimpleAlgorithms;

public class IslandTests
{
    [Fact]
    public void Throw_exception_when_array_is_null()
    {
        // Arrange
        int[] heights = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => Sut.CalculateWaterSquares(heights));
    }

    [Fact]
    public void Return_zero_when_array_is_empty()
    {
        // Arrange
        var heights = new int[] { };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_array_has_one_element()
    {
        // Arrange
        var heights = new[] { 5 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_when_array_has_two_elements()
    {
        // Arrange
        var heights = new[] { 3, 5 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Calculate_water_between_two_equal_heights()
    {
        // Arrange
        var heights = new[] { 3, 0, 3 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Calculate_water_with_intermediate_height()
    {
        // Arrange
        var heights = new[] { 3, 1, 3 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(2, result);
    }

    [Fact]
    public void Calculate_water_in_complex_terrain()
    {
        // Arrange
        var heights = new[] { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Calculate_water_with_peak_in_middle()
    {
        // Arrange
        var heights = new[] { 4, 2, 0, 3, 2, 5 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(9, result);
    }

    [Fact]
    public void Return_zero_for_decreasing_heights()
    {
        // Arrange
        var heights = new[] { 5, 4, 3, 2, 1 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_for_increasing_heights()
    {
        // Arrange
        var heights = new[] { 1, 2, 3, 4, 5 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Return_zero_for_equal_heights()
    {
        // Arrange
        var heights = new[] { 3, 3, 3, 3, 3 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(0, result);
    }

    [Fact]
    public void Calculate_water_with_multiple_peaks()
    {
        // Arrange
        var heights = new[] { 1, 3, 2, 4, 1, 3, 1, 4, 2, 1 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Calculate_water_with_single_valley()
    {
        // Arrange
        var heights = new[] { 5, 2, 5 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Calculate_water_with_deep_valley()
    {
        // Arrange
        var heights = new[] { 5, 0, 5 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(5, result);
    }

    [Fact]
    public void Calculate_water_with_asymmetric_peaks()
    {
        // Arrange
        var heights = new[] { 3, 0, 5, 0, 3 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Calculate_water_with_plateau()
    {
        // Arrange
        var heights = new[] { 3, 3, 0, 3, 3 };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(3, result);
    }

    [Fact]
    public void Calculate_water_with_boundary_values()
    {
        // Arrange
        var heights = new[] { int.MaxValue, 0, int.MaxValue };

        // Act
        var result = Sut.CalculateWaterSquares(heights);

        // Assert
        Assert.Equal(int.MaxValue, result);
    }
}
