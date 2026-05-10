using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strcasecmp
{
	public unsafe static int Invoke(void* left, void* right)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		*unchecked((sbyte*)(&anon_izyfb8)) = -86;
		int result = int_inline_strcmp_strcasecmp_impl_char_const_char_const_0_char_const_char_const_strcasecmp_impl_char_const_char_const_0.Invoke(left, right, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		return result;
	}
}
