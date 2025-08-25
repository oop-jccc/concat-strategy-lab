using StringConcatStrategyApp;

namespace StringConcatStrategyAppTests;

[TestFixture]
public class StringConcatStrategyFactoryTests
{
    [Test]
    public void CreateStrategy_Choice1_ReturnsPlusOperatorStrategy()
    {
        var strategy = StringConcatStrategyFactory.CreateStrategy(1);
        Assert.That(strategy, Is.InstanceOf<PlusOperatorStrategy>());
    }

    [Test]
    public void CreateStrategy_Choice2_ReturnsStringBuilderStrategy()
    {
        var strategy = StringConcatStrategyFactory.CreateStrategy(2);
        Assert.That(strategy, Is.InstanceOf<StringBuilderStrategy>());
    }

    [Test]
    public void CreateStrategy_Choice3_ReturnsStringFormatStrategy()
    {
        var strategy = StringConcatStrategyFactory.CreateStrategy(3);
        Assert.That(strategy, Is.InstanceOf<StringFormatStrategy>());
    }

    [Test]
    public void CreateStrategy_Choice4_ReturnsStringInterpolationStrategy()
    {
        var strategy = StringConcatStrategyFactory.CreateStrategy(4);
        Assert.That(strategy, Is.InstanceOf<StringInterpolationStrategy>());
    }

    [Test]
    public void CreateStrategy_InvalidChoice_ReturnsDefaultPlusOperatorStrategy()
    {
        var strategy = StringConcatStrategyFactory.CreateStrategy(5);
        Assert.That(strategy, Is.InstanceOf<PlusOperatorStrategy>());
    }
}