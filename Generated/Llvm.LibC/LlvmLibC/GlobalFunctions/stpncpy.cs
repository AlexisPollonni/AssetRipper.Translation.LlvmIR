using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class stpncpy
{
	public unsafe static void* Invoke(void* dest, void* src, long n)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		unchecked
		{
			for (num = 0L; (ulong)num < (ulong)n && ((sbyte*)src)[num] != 0; num++)
			{
				sbyte b = ((sbyte*)src)[num];
				((sbyte*)dest)[num] = b;
			}
			if ((ulong)n > (ulong)num)
			{
				inline_bzero_void_unsigned_long_200.Invoke((byte*)dest + num, n - num);
			}
			byte* result = (byte*)dest + num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
