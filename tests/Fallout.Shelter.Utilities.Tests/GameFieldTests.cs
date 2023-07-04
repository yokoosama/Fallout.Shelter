namespace Fallout.Shelter.Utilities.Tests;

public class GameFieldTests
{
    private GameField _gameField = null!;

    [SetUp]
    public void Setup()
    {
        _gameField = new GameField(2);
        _gameField.ThreatPool.Push(new Threat("test"));
        _gameField.ThreatPool.Push(new Threat("test2"));
    }

    [Test]
    public void GetThreat_ReturnsThreatAndAddToDiscarded()
    {
        _gameField.DiscardedThreats.Should().BeEmpty();
        _gameField.ThreatPool.Should().HaveCount(2);

        var threat = _gameField.GetThreat();
        threat.Should().NotBeNull();
        threat.Name.Should().Be("test2");
        _gameField.DiscardedThreats.Should().HaveCount(1);
        _gameField.ThreatPool.Should().HaveCount(1);

        threat = _gameField.GetThreat();
        threat.Should().NotBeNull();
        threat.Name.Should().Be("test");
        _gameField.DiscardedThreats.Should().HaveCount(2);
        _gameField.ThreatPool.Should().HaveCount(0);
    }
}