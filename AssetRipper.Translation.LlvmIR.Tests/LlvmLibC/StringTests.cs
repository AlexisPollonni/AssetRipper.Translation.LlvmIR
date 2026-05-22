using LlvmLibC;
using System.Text;

namespace AssetRipper.Translation.LlvmIR.Tests.LlvmLibC;

public class StringTests
{
    [Test]
    [Arguments("", 0L)]
    [Arguments("hello", 5L)]
    [Arguments("Hello, World!", 13L)]
    public async Task Strlen_ReturnsCorrectLength(string input, long expected)
    {
        byte[] buf = Encoding.UTF8.GetBytes(input + '\0');
        long result;
        unsafe
        {
            fixed (byte* p = buf)
            {
                result = LibC.Strlen(p);
            }
        }

        await Assert.That(result).IsEqualTo(expected);
    }

    [Test]
    public async Task Strcmp_OrdersStrings()
    {
        byte[] a = "abc\0"u8.ToArray();
        byte[] b = "abd\0"u8.ToArray();
        int cmp;
        unsafe
        {
            fixed (byte* pa = a, pb = b)
            {
                cmp = LibC.Strcmp(pa, pb);
            }
        }

        await Assert.That(cmp).IsLessThan(0);
    }

    [Test]
    public async Task Strncmp_RespectsCount()
    {
        byte[] a = "abcXX\0"u8.ToArray();
        byte[] b = "abcYY\0"u8.ToArray();
        int cmp3;
        int cmp5;
        unsafe
        {
            fixed (byte* pa = a, pb = b)
            {
                cmp3 = LibC.Strncmp(pa, pb, 3);
                cmp5 = LibC.Strncmp(pa, pb, 5);
            }
        }

        await Assert.That(cmp3).IsEqualTo(0);
        await Assert.That(cmp5).IsNotEqualTo(0);
    }

    [Test]
    public async Task Strcpy_CopiesAndReturnsDestination()
    {
        byte[] src = "hello\0"u8.ToArray();
        byte[] dst = new byte[16];
        nint ret;
        nint pd;
        unsafe
        {
            fixed (byte* ps = src, pdst = dst)
            {
                pd = (nint)pdst;
                ret = (nint)LibC.Strcpy(pdst, ps);
            }
        }

        await Assert.That(ret).IsEqualTo(pd);
        await Assert.That((int)dst[0]).IsEqualTo('h');
        await Assert.That((int)dst[4]).IsEqualTo('o');
        await Assert.That((int)dst[5]).IsEqualTo(0);
    }

    [Test]
    public async Task Strncpy_PadsWithNulls()
    {
        byte[] src = "abc\0"u8.ToArray();
        byte[] dst = new byte[8];
        for (int i = 0; i < dst.Length; i++) dst[i] = 0xFF;

        unsafe
        {
            fixed (byte* ps = src, pd = dst)
            {
                LibC.Strncpy(pd, ps, 7);
            }
        }

        await Assert.That((int)dst[0]).IsEqualTo('a');
        await Assert.That((int)dst[1]).IsEqualTo('b');
        await Assert.That((int)dst[2]).IsEqualTo('c');
        await Assert.That((int)dst[3]).IsEqualTo(0);
        await Assert.That((int)dst[6]).IsEqualTo(0);
    }

    [Test]
    public async Task Strchr_FindsCharacter()
    {
        byte[] buf = "hello\0"u8.ToArray();
        bool found;
        long offset = -1;
        unsafe
        {
            fixed (byte* p = buf)
            {
                void* ptr = LibC.Strchr(p, 'l');
                found = ptr != null;
                if (found)
                {
                    offset = (byte*)ptr - p;
                }
            }
        }

        await Assert.That(found).IsTrue();
        await Assert.That(offset).IsEqualTo(2L);
    }

    [Test]
    public async Task Strstr_FindsSubstring()
    {
	    Span<byte> test = [0xFF, 0xFF, 0xFF, 0xFF, 0xFF];
        byte[] haystack = "hello world\0"u8.ToArray();
        byte[] needle = "world\0"u8.ToArray();
        bool found;
        long offset = -1;
        unsafe
        {
            fixed (byte* ph = haystack, pn = needle)
            {
                void* ptr = LibC.Strstr(ph, pn);
                found = ptr != null;
                if (found)
                {
                    offset = (byte*)ptr - ph;
                }
            }
        }

        await Assert.That(found).IsTrue();
        await Assert.That(offset).IsEqualTo(6L);
    }

    [Test]
    public async Task Strnlen_ClampsToMaximum()
    {
        byte[] buf = "hello world\0"u8.ToArray();
        long result;
        unsafe
        {
            fixed (byte* p = buf)
            {
                result = LibC.Strnlen(p, 5);
            }
        }

        await Assert.That(result).IsEqualTo(5L);
    }

    [Test]
    public async Task Strdup_ReturnsDistinctCopy()
    {
        byte[] src = "hello\0"u8.ToArray();
        bool nonNull;
        bool different;
        byte[] copyBytes = new byte[6];

        unsafe
        {
            fixed (byte* ps = src)
            {
                byte* copy = (byte*)LibC.Strdup(ps);
                try
                {
                    nonNull = copy != null;
                    different = (nint)copy != (nint)ps;
                    if (copy != null)
                    {
                        for (int i = 0; i < copyBytes.Length; i++)
                        {
                            copyBytes[i] = copy[i];
                        }
                    }
                }
                finally
                {
                    if (copy != null)
                    {
                        LibC.Free(copy);
                    }
                }
            }
        }

        await Assert.That(nonNull).IsTrue();
        await Assert.That(different).IsTrue();
        for (int i = 0; i < copyBytes.Length; i++)
        {
            await Assert.That((int)copyBytes[i]).IsEqualTo(src[i]);
        }
    }

    [Test]
    [Arguments("42", 42)]
    [Arguments("-7", -7)]
    [Arguments("  123", 123)]
    public async Task Atoi_ParsesInteger(string input, int expected)
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
    [Arguments("3.14", 3.14)]
    [Arguments("-2.5", -2.5)]
    public async Task Atof_ParsesFloatingPoint(string input, double expected)
    {
        byte[] buf = Encoding.UTF8.GetBytes(input + '\0');
        double value;
        unsafe
        {
            fixed (byte* p = buf)
            {
                value = LibC.Atof(p);
            }
        }

        await Assert.That(Math.Abs(value - expected) < 1e-10).IsTrue();
    }
}
