using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7load_beItEET_PKNS_3cpp4byteEm")]
[DemangledName("unsigned short __llvm_libc_20_1_2_::generic::load_be<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_short_generic_load_be_unsigned_short_cpp_byte_const_unsigned_long
{
	public unsafe static short Invoke(void* ptr, long offset)
	{
		return unsigned_short_internal_Endian_1234u_to_big_endian_unsigned_short_unsigned_short.Invoke(unsigned_short_generic_load_unsigned_short_cpp_byte_const_unsigned_long.Invoke(ptr, offset));
	}
}
