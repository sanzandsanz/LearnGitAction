namespace LearnGitAction.Tests;

public class CalculationServiceTests
{
    [Fact]
    public void AddTwoAndThreeShouldReturnFive()
    {
        // Arrange
        int a = 2;
        int b = 3;

        // Act
        var result = CalculationService.Add(a, b);

        // Assert
        Assert.Equal(5, result);
    }
}