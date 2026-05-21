using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class strncmp
{
	public unsafe static int Invoke(void* left, void* right, long n)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		*unchecked((sbyte*)(&anon_izyfb8)) = -86;
		int result = inline_strncmp_strncmp_impl_char_const_char_const_unsigned_long_0.Invoke(left, right, n, &anon_izyfb8);
		llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
		return result;
	}
}
