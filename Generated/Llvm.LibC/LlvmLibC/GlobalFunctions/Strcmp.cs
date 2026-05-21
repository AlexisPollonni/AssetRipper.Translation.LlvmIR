using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strcmp
{
	[MangledName("strcmp")]
	[DemangledName("strcmp")]
	public unsafe static int Invoke([MangledName("left")] void* Left, [MangledName("right")] void* Right)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		*unchecked((sbyte*)(&anon_izyfb)) = -86;
		int result = Llvm_libc_20_1_2_inline_strcmp_strcmp_impl_char_const_char_const_0.Invoke(Left, Right, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		return result;
	}
}
