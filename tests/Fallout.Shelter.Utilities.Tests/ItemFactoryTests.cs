using Fallout.Shelter.Utilities.Factories;

namespace Fallout.Shelter.Utilities.Tests;

public class ItemFactoryTests
{
    public void CreateWithInjuredDweller_CreateValidReward()
    {
        var reward = ItemFactory.CreateGoldenRetriever();

        reward.Name.Should().Be("Golden Retriever");
        reward.GiveActivateItemPossibility.Should().BeTrue();
        reward.GiveAdditionalDamage.Should().BeNull();
    }
}