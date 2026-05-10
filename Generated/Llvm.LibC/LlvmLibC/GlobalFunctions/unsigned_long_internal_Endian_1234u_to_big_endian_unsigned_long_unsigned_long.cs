using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6EndianILj1234EE13to_big_endianImEET_S4_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::Endian<1234u>::to_big_endian<unsigned long>(unsigned long)")]
internal static partial class unsigned_long_internal_Endian_1234u_to_big_endian_unsigned_long_unsigned_long
{
	public static long Invoke(long v)
	{
		return llvm_bswap_i64.Invoke(v);
	}
}
