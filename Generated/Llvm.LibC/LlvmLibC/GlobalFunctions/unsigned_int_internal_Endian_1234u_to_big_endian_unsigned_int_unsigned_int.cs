using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal6EndianILj1234EE13to_big_endianIjEET_S4_")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::internal::Endian<1234u>::to_big_endian<unsigned int>(unsigned int)")]
internal static partial class unsigned_int_internal_Endian_1234u_to_big_endian_unsigned_int_unsigned_int
{
	public static int Invoke(int v)
	{
		return llvm_bswap_i32.Invoke(v);
	}
}
