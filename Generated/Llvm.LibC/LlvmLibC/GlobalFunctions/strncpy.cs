using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strncpy
{
	public unsafe static readonly void* __pointer = PointerIndices.Register((delegate*<void*, void*, long, void*>)(&Invoke));

	public unsafe static void* Invoke(void* dest, void* src, long n)
	{
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < (ulong)n && ((sbyte*)src)[num] != 0; num++)
			{
				sbyte b = ((sbyte*)src)[num];
				((sbyte*)dest)[num] = b;
			}
			for (; (ulong)num < (ulong)n; num++)
			{
				((sbyte*)dest)[num] = 0;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return dest;
		}
	}
}
