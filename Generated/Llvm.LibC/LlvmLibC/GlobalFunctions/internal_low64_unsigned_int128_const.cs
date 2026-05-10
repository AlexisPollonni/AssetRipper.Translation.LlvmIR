using System;
using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal5low64ERKo")]
[DemangledName("__llvm_libc_20_1_2_::internal::low64(unsigned __int128 const&)")]
internal static partial class internal_low64_unsigned_int128_const
{
	public unsafe static long Invoke(void* num)
	{
		return unchecked((long)NumericHelper.BitwiseAnd(*(Int128*)num, -1L));
	}
}
