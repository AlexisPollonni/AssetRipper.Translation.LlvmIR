using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11string_view6lengthEPKc")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view::length(char const*)")]
internal static partial class cpp_string_view_length_char_const
{
	public unsafe static long Invoke(void* Str)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			for (ptr = Str; *(sbyte*)ptr != 0; ptr = (byte*)ptr + 1)
			{
			}
			long result = (long)ptr - (long)Str;
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
