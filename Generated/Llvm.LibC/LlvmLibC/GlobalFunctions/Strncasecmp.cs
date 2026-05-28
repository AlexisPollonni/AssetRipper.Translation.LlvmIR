using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strncasecmp
{
	[MangledName("strncasecmp")]
	[DemangledName("strncasecmp")]
	public unsafe static int Invoke([MangledName("left")] void* Left, [MangledName("right")] void* Right, [MangledName("n")] long N)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		*unchecked((sbyte*)(&anon_izyfb)) = -86;
		int result = Inline_strncmp_strncasecmp_impl_char_const_char_const_unsigned_long_0.Invoke(Left, Right, N, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		return result;
	}
}
