using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm32EE13loop_and_tailEPNS_3cpp4byteEPKS4_m")]
[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<32ul>::loop_and_tail(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class builtin_Memcpy_32ul_loop_and_tail_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		builtin_Memcpy_32ul_loop_and_tail_offset_cpp_byte_cpp_byte_const_unsigned_long_unsigned_long.Invoke(dst, src, count, 0L);
	}
}
