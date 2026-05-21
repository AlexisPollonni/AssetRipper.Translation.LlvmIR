using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Strcasestr
{
	[MangledName("strcasestr")]
	[DemangledName("strcasestr")]
	public unsafe static void* Invoke([MangledName("haystack")] void* Haystack, [MangledName("needle")] void* Needle)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		*unchecked((sbyte*)(&anon_izyfb)) = -86;
		void* result = Llvm_libc_20_1_2_inline_strstr_strcasestr_impl_char_const_char_const_0.Invoke(Haystack, Needle, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		return result;
	}
}
