using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6EndianILj1234EE13to_big_endianItEET_S4_")]
[DemangledName("unsigned short __llvm_libc_20_1_2_::internal::Endian<1234u>::to_big_endian<unsigned short>(unsigned short)")]
internal static partial class unsigned_short_internal_Endian_1234u_to_big_endian_unsigned_short_unsigned_short
{
	public static short Invoke(short v)
	{
		return llvm_bswap_i16.Invoke(v);
	}
}
