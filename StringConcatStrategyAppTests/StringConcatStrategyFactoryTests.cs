using StringConcatStrategyApp;

namespace StringConcatStrategyAppTests;

[TestFixture]
public class StringConcatStrategyFactoryTests
{
    [Test]
    public void CreateStrategy_Choice1_ReturnsPlusOperatorStrategy()
    {
        //TODO: Uncomment the following after you implement the PlusOperatorStrategy class.
        //var strategy = StringConcatStrategyFactory.CreateStrategy(1);
        //Assert.That(strategy, Is.InstanceOf<PlusOperatorStrategy>());
    }

    [Test]
    public void CreateStrategy_Choice2_ReturnsStringBuilderStrategy()
    {
        // TODO: Update this test once the StringBuilderStrategy class is implemented.
        Assert.Fail("StringBuilderStrategy class not implemented yet.");
    }

    [Test]
    public void CreateStrategy_Choice3_ReturnsStringFormatStrategy()
    {
        // TODO: Update this test once the StringFormatStrategy class is implemented.
        Assert.Fail("StringFormatStrategy class not implemented yet.");
    }

    [Test]
    public void CreateStrategy_Choice4_ReturnsStringInterpolationStrategy()
    {
        // TODO: Update this test once the StringInterpolationStrategy class is implemented.
        Assert.Fail("StringInterpolationStrategy class not implemented yet.");
    }

    [Test]
    public void CreateStrategy_InvalidChoice_ReturnsDefaultPlusOperatorStrategy()
    {
        // TODO: Uncomment the following after you implement the PlusOperatorStrategy class.
        // var strategy = StringConcatStrategyFactory.CreateStrategy(5);
        // Assert.That(strategy, Is.InstanceOf<PlusOperatorStrategy>());
    }
}