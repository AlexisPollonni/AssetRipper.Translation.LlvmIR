using System;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6high64ERKo")]
[DemangledName("__llvm_libc_20_1_2_::internal::high64(unsigned __int128 const&)")]
internal static partial class internal_high64_unsigned_int128_const
{
	public unsafe static long Invoke(void* num)
	{
		return unchecked((long)NumericHelper.ShiftRightLogical(*(Int128*)num, 64L));
	}
}
