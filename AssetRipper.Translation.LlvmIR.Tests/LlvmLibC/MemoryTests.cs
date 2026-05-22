using LlvmLibC;

namespace AssetRipper.Translation.LlvmIR.Tests.LlvmLibC;

public class MemoryTests
{
    [Test]
    public async Task Memset_FillsBufferAndReturnsDestination()
    {
	    //CHANGE THIS
        byte[] buf = new byte[8];
        nint ret;
        nint dst;
        unsafe
        {
            fixed (byte* p = buf)
            {
                dst = (nint)p;
                ret = (nint)LibC.Memset(p, 0xAB, buf.Length);
            }
        }

        await Assert.That(ret).IsEqualTo(dst);
        for (int i = 0; i < buf.Length; i++)
        {
            await Assert.That((int)buf[i]).IsEqualTo(0xAB);
        }
    }

    [Test]
    public async Task Memcpy_CopiesBytes()
    {
        byte[] src = [1, 2, 3, 4, 5];
        byte[] dst = new byte[src.Length];

        unsafe
        {
            fixed (byte* ps = src, pd = dst)
            {
                LibC.Memcpy(pd, ps, src.Length);
            }
        }

        for (int i = 0; i < src.Length; i++)
        {
            await Assert.That((int)dst[i]).IsEqualTo(src[i]);
        }
    }

    [Test]
    public async Task Memmove_OverlappingForward_CopiesCorrectly()
    {
        byte[] buf = [1, 2, 3, 4, 5, 0, 0];

        unsafe
        {
            fixed (byte* p = buf)
            {
                LibC.Memmove(p + 2, p, 5);
            }
        }

        await Assert.That((int)buf[2]).IsEqualTo(1);
        await Assert.That((int)buf[3]).IsEqualTo(2);
        await Assert.That((int)buf[4]).IsEqualTo(3);
        await Assert.That((int)buf[5]).IsEqualTo(4);
        await Assert.That((int)buf[6]).IsEqualTo(5);
    }

    [Test]
    public async Task Memcmp_Ordering()
    {
        byte[] a = [1, 2, 3, 4];
        byte[] b = [1, 2, 3, 5];
        int cmp;

        unsafe
        {
            fixed (byte* pa = a, pb = b)
            {
                cmp = LibC.Memcmp(pa, pb, a.Length);
            }
        }

        await Assert.That(cmp).IsLessThan(0);
    }

    [Test]
    public async Task Memchr_FindsElement()
    {
        byte[] buf = [10, 20, 30, 40];
        bool found;
        long offset = -1;

        unsafe
        {
            fixed (byte* p = buf)
            {
                void* ptr = LibC.Memchr(p, 30, buf.Length);
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
    public async Task Bzero_ZerosBuffer()
    {
        byte[] buf = [0xAA, 0xBB, 0xCC];

        unsafe
        {
            fixed (byte* p = buf)
            {
                LibC.Bzero(p, buf.Length);
            }
        }

        for (int i = 0; i < buf.Length; i++)
        {
            await Assert.That((int)buf[i]).IsEqualTo(0);
        }
    }

    [Test]
    public async Task Memccpy_StopsAfterDelimiter()
    {
        byte[] src = [1, 2, 3, 4, 5];
        byte[] dst = new byte[8];
        bool found;
        long afterOffset = -1;

        unsafe
        {
            fixed (byte* ps = src, pd = dst)
            {
                void* after = LibC.Memccpy(pd, ps, 3, src.Length);
                found = after != null;
                if (found)
                {
                    afterOffset = (byte*)after - pd;
                }
            }
        }

        await Assert.That(found).IsTrue();
        await Assert.That(afterOffset).IsEqualTo(3L);
        await Assert.That((int)dst[0]).IsEqualTo(1);
        await Assert.That((int)dst[1]).IsEqualTo(2);
        await Assert.That((int)dst[2]).IsEqualTo(3);
    }
}
