using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic3neqImEEjPKNS_3cpp4byteES5_m")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::neq<unsigned long>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_int_generic_neq_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long offset)
	{
		return unchecked((byte)((bool_generic_eq_unsigned_long_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, offset) ? 1 : 0) ^ -1));
	}
}
