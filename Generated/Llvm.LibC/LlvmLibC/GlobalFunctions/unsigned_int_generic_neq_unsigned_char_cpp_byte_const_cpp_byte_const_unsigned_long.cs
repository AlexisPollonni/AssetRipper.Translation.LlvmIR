using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic3neqIhEEjPKNS_3cpp4byteES5_m")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::neq<unsigned char>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_int_generic_neq_unsigned_char_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long offset)
	{
		return unchecked((byte)unsigned_char_generic_load_unsigned_char_cpp_byte_const_unsigned_long.Invoke(p1, offset) ^ (byte)unsigned_char_generic_load_unsigned_char_cpp_byte_const_unsigned_long.Invoke(p2, offset));
	}
}
