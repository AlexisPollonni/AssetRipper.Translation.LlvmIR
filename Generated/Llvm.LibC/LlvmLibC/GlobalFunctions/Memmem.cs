using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmem
{
	[MangledName("memmem")]
	[DemangledName("memmem")]
	public unsafe static void* Invoke([MangledName("haystack")] void* Haystack, [MangledName("haystack_len")] long Haystack_len, [MangledName("needle")] void* Needle, [MangledName("needle_len")] long Needle_len)
	{
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
		void* result = Inline_memmem_memmem_impl_void_const_unsigned_long_void_const_unsigned_long_0_const.Invoke(Haystack, Haystack_len, Needle, Needle_len, &anon_izyfb);
		Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
		return result;
	}
}
