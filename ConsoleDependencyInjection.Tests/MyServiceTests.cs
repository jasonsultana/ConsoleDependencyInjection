using ConsoleDependencyInjection.Library;
using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDependencyInjection.Tests;

public class Tests
{
    private IMyService _sut;

    [SetUp]
    public void Setup()
    {
        _sut = ServiceProviderFactory
            .CreateServiceProvider()
            .GetService<IMyService>();
    }

    [Test]
    public void Test1()
    {
        Assert.DoesNotThrow(() =>
        {
            _sut.DoTheThing();
        });
    }
}
