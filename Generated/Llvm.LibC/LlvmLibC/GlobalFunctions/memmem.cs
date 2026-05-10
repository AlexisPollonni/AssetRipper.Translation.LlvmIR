using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class memmem
{
	public unsafe static void* Invoke(void* haystack, long haystack_len, void* needle, long needle_len)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		void* result = void_inline_memmem_memmem_impl_void_const_unsigned_long_void_const_unsigned_long_0_const_void_const_unsigned_long_void_const_unsigned_long_memmem_impl_void_const_unsigned_long_void_const_unsigned_long_0_const.Invoke(haystack, haystack_len, needle, needle_len, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		return result;
	}
}
