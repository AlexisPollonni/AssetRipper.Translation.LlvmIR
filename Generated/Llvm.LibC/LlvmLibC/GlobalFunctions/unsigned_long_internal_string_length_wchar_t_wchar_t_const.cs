using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal13string_lengthIwEEmPKT_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::string_length<wchar_t>(wchar_t const*)")]
internal static partial class unsigned_long_internal_string_length_wchar_t_wchar_t_const
{
	public unsafe static long Invoke(void* src)
	{
		long num = 0L;
		void* ptr = src;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = -6148914691236517206L;
		num = 0L;
		unchecked
		{
			while (*(int*)ptr != 0)
			{
				ptr = (byte*)ptr + 4;
				num++;
			}
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
