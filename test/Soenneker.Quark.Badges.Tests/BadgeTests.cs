using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Quark.Badges.Tests;

[Collection("Collection")]
public sealed class BadgeTests : FixturedUnitTest
{
    public BadgeTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
