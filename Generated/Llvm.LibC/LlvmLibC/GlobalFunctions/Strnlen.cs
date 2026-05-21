using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strnlen
{
	[MangledName("strnlen")]
	[DemangledName("strnlen")]
	public unsafe static long Invoke([MangledName("src")] void* Src, [MangledName("n")] long N)
	{
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = Internal_find_first_character.Invoke(Src, 0, N);
		long result = ((ptr == null) ? N : unchecked((long)ptr - (long)Src));
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
