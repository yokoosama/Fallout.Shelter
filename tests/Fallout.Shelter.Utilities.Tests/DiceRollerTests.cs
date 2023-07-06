namespace Fallout.Shelter.Utilities.Tests;

public class DiceRollerTests
{
    [Test]
    [Repeat(25)]
    public void Roll_AlwaysBetweenOneAndSix()
    {
        var result = DiceRoller.Roll();

        result.Item1.Should().BeGreaterOrEqualTo(1).And.BeLessThanOrEqualTo(6);
        result.Item2.Should().BeGreaterOrEqualTo(1).And.BeLessThanOrEqualTo(6);
    }

    [Test]
    [Repeat(25)]
    public void RollSum_AlwaysBetweenTwoAndTwelve()
    {
        var result = DiceRoller.RollSum();

        result.Should().BeGreaterOrEqualTo(2).And.BeLessThanOrEqualTo(12);
    }
}