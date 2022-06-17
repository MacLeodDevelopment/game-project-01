using FluentAssertions;
using Game.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;
#pragma warning disable CS8618

namespace Game.Api.UnitTests.Controllers;

[TestFixture]
public class HealthCheckControllerTests
{
    private HealthCheckController _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new HealthCheckController();
    }

    [Test]
    public void Get_ShouldReturn_VersionNumber()
    {
        var result = _sut.Get();

        result.Should().BeOfType<OkObjectResult>();
        result.StatusCode.Should().Be(200);
        result.Value.Should().Be("1");
    }
}