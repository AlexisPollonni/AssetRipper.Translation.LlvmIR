using LlvmLibC;

namespace AssetRipper.Translation.LlvmIR.Tests.LlvmLibC;

public class MathFloatTests
{
    private static async Task AssertClose(float actual, float expected, float eps = 1e-3f)
    {
        await Assert.That(MathF.Abs(actual - expected) <= eps).IsTrue();
    }

    [Test]
    [Arguments(0.0f, 0.0f)]
    [Arguments(1.0f, 1.0f)]
    [Arguments(4.0f, 2.0f)]
    public Task Sqrtf_KnownValues(float x, float expected) => AssertClose(LibC.Sqrtf(x), expected, 1e-6f);

    [Test]
    public async Task Sqrtf_Negative_ReturnsNaN()
    {
        await Assert.That(float.IsNaN(LibC.Sqrtf(-1.0f))).IsTrue();
    }

    [Test]
    [Arguments(0.0f, 0.0f)]
    [Arguments((float)(Math.PI / 2), 1.0f)]
    public Task Sinf_KnownValues(float x, float expected) => AssertClose(LibC.Sinf(x), expected);

    [Test]
    [Arguments(0.0f, 1.0f)]
    [Arguments((float)Math.PI, -1.0f)]
    public Task Cosf_KnownValues(float x, float expected) => AssertClose(LibC.Cosf(x), expected);

    [Test]
    [Arguments(0.0f, 1.0f)]
    [Arguments(1.0f, (float)Math.E)]
    public Task Expf_KnownValues(float x, float expected) => AssertClose(LibC.Expf(x), expected);

    [Test]
    [Arguments(1.0f, 0.0f)]
    [Arguments((float)Math.E, 1.0f)]
    public Task Logf_KnownValues(float x, float expected) => AssertClose(LibC.Logf(x), expected);

    [Test]
    [Arguments(2.0f, 3.0f, 8.0f)]
    [Arguments(4.0f, 0.5f, 2.0f)]
    public Task Powf_KnownValues(float x, float y, float expected) => AssertClose(LibC.Powf(x, y), expected);

    [Test]
    [Arguments(1.9f, 1.0f)]
    [Arguments(-1.1f, -2.0f)]
    public async Task Floorf_KnownValues(float x, float expected)
    {
        await Assert.That(LibC.Floorf(x)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(1.1f, 2.0f)]
    [Arguments(-1.9f, -1.0f)]
    public async Task Ceilf_KnownValues(float x, float expected)
    {
        await Assert.That(LibC.Ceilf(x)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(-1.5f, 1.5f)]
    [Arguments(1.5f, 1.5f)]
    public async Task Fabsf_KnownValues(float x, float expected)
    {
        await Assert.That(LibC.Fabsf(x)).IsEqualTo(expected);
    }

    [Test]
    [Arguments(5.3f, 2.0f, 1.3f)]
    [Arguments(10.0f, 3.0f, 1.0f)]
    public Task Fmodf_KnownValues(float x, float y, float expected) => AssertClose(LibC.Fmodf(x, y), expected);
}
