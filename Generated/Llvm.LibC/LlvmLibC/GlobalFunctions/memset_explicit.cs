using AssetRipper.Translation.LlvmIR.Runtime;

namespace LlvmLibC.GlobalFunctions;

internal static partial class memset_explicit
{
	public unsafe static void* Invoke(void* dst, int value, long count)
	{
		inline_memset_rivytf.Invoke(dst, unchecked((sbyte)value), count);
		IntrinsicFunctions.AsmMemoryBarrierPtr(dst);
		return dst;
	}
}
