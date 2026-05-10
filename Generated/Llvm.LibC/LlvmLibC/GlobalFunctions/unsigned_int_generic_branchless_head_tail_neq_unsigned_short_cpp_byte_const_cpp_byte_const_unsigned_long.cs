using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic24branchless_head_tail_neqItEEjPKNS_3cpp4byteES5_m")]
[DemangledName("unsigned int __llvm_libc_20_1_2_::generic::branchless_head_tail_neq<unsigned short>(__llvm_libc_20_1_2_::cpp::byte const*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class unsigned_int_generic_branchless_head_tail_neq_unsigned_short_cpp_byte_const_cpp_byte_const_unsigned_long
{
	public unsafe static int Invoke(void* p1, void* p2, long count)
	{
		return unsigned_int_generic_neq_unsigned_short_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, 0L) | unsigned_int_generic_neq_unsigned_short_cpp_byte_const_cpp_byte_const_unsigned_long.Invoke(p1, p2, unchecked(count - 2L));
	}
}
