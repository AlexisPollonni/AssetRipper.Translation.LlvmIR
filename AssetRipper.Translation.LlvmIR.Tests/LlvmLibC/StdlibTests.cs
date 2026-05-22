using LlvmLibC;
using System.Text;

namespace AssetRipper.Translation.LlvmIR.Tests.LlvmLibC;

public class StdlibTests
{
    [Test]
    [Arguments(0, 0)]
    [Arguments(42, 42)]
    [Arguments(-42, 42)]
    public async Task Abs_KnownValues(int n, int expected)
    {
        await Assert.That(LibC.Abs(n)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(0L, 0L)]
    [Arguments(1000L, 1000L)]
    [Arguments(-1000L, 1000L)]
    public async Task Labs_KnownValues(long n, long expected)
    {
        await Assert.That(LibC.Labs(n)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(10, 3, 3, 1)]
    [Arguments(-7, 2, -3, -1)]
    [Arguments(7, -2, -3, 1)]
    public async Task Div_KnownValues(int x, int y, int expectedQuot, int expectedRem)
    {
        long result = LibC.Div(x, y);
        int quot = unchecked((int)result);
        int rem = unchecked((int)(result >> 32));
        await Assert.That(quot).IsEqualTo(expectedQuot);
        await Assert.That(rem).IsEqualTo(expectedRem);
    }

    [Test]
    [Arguments("42", 10, 42L)]
    [Arguments("0xFF", 0, 255L)]
    [Arguments("0777", 0, 511L)]
    public async Task Strtol_ParsesValues(string input, int @base, long expected)
    {
        byte[] buf = Encoding.UTF8.GetBytes(input + '\0');
        long value;
        unsafe
        {
            fixed (byte* p = buf)
            {
                value = LibC.Strtol(p, null, @base);
            }
        }

        await Assert.That(value).IsEqualTo(expected);
    }

    [Test]
    [Arguments("3.14", 3.14)]
    [Arguments("-2.718", -2.718)]
    [Arguments("1e4", 10000.0)]
    public async Task Strtod_ParsesValues(string input, double expected)
    {
        byte[] buf = Encoding.UTF8.GetBytes(input + '\0');
        double value;
        unsafe
        {
            fixed (byte* p = buf)
            {
                value = LibC.Strtod(p, null);
            }
        }

        await Assert.That(Math.Abs(value - expected) < 1e-9).IsTrue();
    }

    [Test]
    [Arguments("42", 42)]
    [Arguments("-7", -7)]
    [Arguments("  123", 123)]
    public async Task Atoi_ParsesValues(string input, int expected)
    {
        byte[] buf = Encoding.UTF8.GetBytes(input + '\0');
        int value;
        unsafe
        {
            fixed (byte* p = buf)
            {
                value = LibC.Atoi(p);
            }
        }

        await Assert.That(value).IsEqualTo(expected);
    }

    [Test]
    public async Task Srand_SameSeed_ProducesSameSequence()
    {
        LibC.Srand(42);
        int a1 = LibC.Rand();
        int a2 = LibC.Rand();
        int a3 = LibC.Rand();

        LibC.Srand(42);
        await Assert.That(LibC.Rand()).IsEqualTo(a1);
        await Assert.That(LibC.Rand()).IsEqualTo(a2);
        await Assert.That(LibC.Rand()).IsEqualTo(a3);
    }

}
