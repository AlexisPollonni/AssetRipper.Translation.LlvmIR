using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7load_beIjEET_PKNS_3cpp4byteEm")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::load_be<unsigned int>(__llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_int_generic_load_be_unsigned_int_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* ptr, long offset)
	{
		return unsigned_int_internal_Endian_1234u_to_big_endian_unsigned_int_unsigned_int.Invoke(unsigned_int_generic_load_unsigned_int_cpp_byte_const_unsigned_long.Invoke(ptr, offset));
	}
}
