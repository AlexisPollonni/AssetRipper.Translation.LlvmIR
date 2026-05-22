using LlvmLibC;

namespace AssetRipper.Translation.LlvmIR.Tests.LlvmLibC;

public class CharTests
{
    [Test]
    [Arguments('a', true)]
    [Arguments('Z', true)]
    [Arguments('0', false)]
    [Arguments(' ', false)]
    public async Task Isalpha_BasicCases(int c, bool expected)
    {
        await Assert.That(LibC.Isalpha(c) != 0).IsEqualTo(expected);
    }

    [Test]
    [Arguments('0', true)]
    [Arguments('9', true)]
    [Arguments('a', false)]
    [Arguments('/', false)]
    public async Task Isdigit_BasicCases(int c, bool expected)
    {
        await Assert.That(LibC.Isdigit(c) != 0).IsEqualTo(expected);
    }

    [Test]
    [Arguments('A', true)]
    [Arguments('z', true)]
    [Arguments('7', true)]
    [Arguments('!', false)]
    public async Task Isalnum_BasicCases(int c, bool expected)
    {
        await Assert.That(LibC.Isalnum(c) != 0).IsEqualTo(expected);
    }

    [Test]
    [Arguments(' ', true)]
    [Arguments('\t', true)]
    [Arguments('\n', true)]
    [Arguments('A', false)]
    public async Task Isspace_BasicCases(int c, bool expected)
    {
        await Assert.That(LibC.Isspace(c) != 0).IsEqualTo(expected);
    }

    [Test]
    [Arguments('A', true)]
    [Arguments('Z', true)]
    [Arguments('a', false)]
    public async Task Isupper_BasicCases(int c, bool expected)
    {
        await Assert.That(LibC.Isupper(c) != 0).IsEqualTo(expected);
    }

    [Test]
    [Arguments('a', true)]
    [Arguments('z', true)]
    [Arguments('A', false)]
    public async Task Islower_BasicCases(int c, bool expected)
    {
        await Assert.That(LibC.Islower(c) != 0).IsEqualTo(expected);
    }

    [Test]
    [Arguments('a', 'A')]
    [Arguments('z', 'Z')]
    [Arguments('A', 'A')]
    [Arguments('0', '0')]
    public async Task Toupper_BasicCases(int c, int expected)
    {
        await Assert.That(LibC.Toupper(c)).IsEqualTo(expected);
    }

    [Test]
    [Arguments('A', 'a')]
    [Arguments('Z', 'z')]
    [Arguments('a', 'a')]
    [Arguments('0', '0')]
    public async Task Tolower_BasicCases(int c, int expected)
    {
        await Assert.That(LibC.Tolower(c)).IsEqualTo(expected);
    }

    [Test]
    public async Task ToupperTolower_RoundTrip_Letters()
    {
        for (char c = 'a'; c <= 'z'; c++)
        {
            int upper = LibC.Toupper(c);
            int lower = LibC.Tolower(upper);
            await Assert.That(lower).IsEqualTo((int)c);
        }
    }
}
