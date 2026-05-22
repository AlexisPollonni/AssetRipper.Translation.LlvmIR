using LlvmLibC;

namespace AssetRipper.Translation.LlvmIR.Tests.LlvmLibC;

public class MathTests
{
    private static async Task AssertClose(double actual, double expected, double eps = 1e-9)
    {
        await Assert.That(Math.Abs(actual - expected) <= eps).IsTrue();
    }

    [Test]
    [Arguments(0.0, 0.0)]
    [Arguments(1.0, 1.0)]
    [Arguments(4.0, 2.0)]
    [Arguments(2.0, 1.4142135623730951)]
    public Task Sqrt_KnownValues(double x, double expected) => AssertClose(LibC.Sqrt(x), expected, 1e-12);

    [Test]
    public async Task Sqrt_Negative_ReturnsNaN()
    {
        await Assert.That(double.IsNaN(LibC.Sqrt(-1.0))).IsTrue();
    }

    [Test]
    [Arguments(0.0, 0.0)]
    [Arguments(Math.PI / 2, 1.0)]
    [Arguments(Math.PI, 0.0)]
    public Task Sin_KnownValues(double x, double expected) => AssertClose(LibC.Sin(x), expected);

    [Test]
    [Arguments(0.0, 1.0)]
    [Arguments(Math.PI, -1.0)]
    public Task Cos_KnownValues(double x, double expected) => AssertClose(LibC.Cos(x), expected);

    [Test]
    [Arguments(0.0, 1.0)]
    [Arguments(1.0, Math.E)]
    public Task Exp_KnownValues(double x, double expected) => AssertClose(LibC.Exp(x), expected);

    [Test]
    [Arguments(1.0, 0.0)]
    [Arguments(Math.E, 1.0)]
    public Task Log_KnownValues(double x, double expected) => AssertClose(LibC.Log(x), expected);

    [Test]
    [Arguments(2.0, 3.0, 8.0)]
    [Arguments(9.0, 0.5, 3.0)]
    [Arguments(4.0, -1.0, 0.25)]
    public Task Pow_KnownValues(double x, double y, double expected) => AssertClose(LibC.Pow(x, y), expected);

    [Test]
    [Arguments(1.9, 1.0)]
    [Arguments(-1.1, -2.0)]
    public async Task Floor_KnownValues(double x, double expected)
    {
        await Assert.That(LibC.Floor(x)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(1.1, 2.0)]
    [Arguments(-1.9, -1.0)]
    public async Task Ceil_KnownValues(double x, double expected)
    {
        await Assert.That(LibC.Ceil(x)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(0.5, 1.0)]
    [Arguments(-0.5, -1.0)]
    [Arguments(1.5, 2.0)]
    public async Task Round_KnownValues(double x, double expected)
    {
        await Assert.That(LibC.Round(x)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(-1.5, 1.5)]
    [Arguments(1.5, 1.5)]
    public async Task Fabs_KnownValues(double x, double expected)
    {
        await Assert.That(LibC.Fabs(x)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(5.3, 2.0, 1.3)]
    [Arguments(-5.3, 2.0, -1.3)]
    public Task Fmod_KnownValues(double x, double y, double expected) => AssertClose(LibC.Fmod(x, y), expected);

    [Test]
    [Arguments(3.0, 5.0, 5.0)]
    [Arguments(5.0, 3.0, 5.0)]
    public async Task Fmax_KnownValues(double x, double y, double expected)
    {
        await Assert.That(LibC.Fmax(x, y)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(3.0, 5.0, 3.0)]
    [Arguments(5.0, 3.0, 3.0)]
    public async Task Fmin_KnownValues(double x, double y, double expected)
    {
        await Assert.That(LibC.Fmin(x, y)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(3.0, 4.0, 5.0)]
    [Arguments(5.0, 12.0, 13.0)]
    public Task Hypot_KnownValues(double x, double y, double expected) => AssertClose(LibC.Hypot(x, y), expected);

    [Test]
    [Arguments(8.0, 2.0)]
    [Arguments(27.0, 3.0)]
    [Arguments(-8.0, -2.0)]
    public Task Cbrt_KnownValues(double x, double expected) => AssertClose(LibC.Cbrt(x), expected);

    [Test]
    [Arguments(1.0, -1.0, -1.0)]
    [Arguments(-1.0, 1.0, 1.0)]
    public async Task Copysign_KnownValues(double x, double y, double expected)
    {
        await Assert.That(LibC.Copysign(x, y)).IsEqualTo(expected);
    }
}
