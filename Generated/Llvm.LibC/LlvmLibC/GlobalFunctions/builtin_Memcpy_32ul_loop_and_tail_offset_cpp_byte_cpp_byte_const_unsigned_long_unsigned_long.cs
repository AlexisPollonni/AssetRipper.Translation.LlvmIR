using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7builtin6MemcpyILm32EE20loop_and_tail_offsetEPNS_3cpp4byteEPKS4_mm")]
[DemangledName("__llvm_libc_20_1_2_::builtin::Memcpy<32ul>::loop_and_tail_offset(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long, unsigned long)")]
internal static partial class builtin_Memcpy_32ul_loop_and_tail_offset_cpp_byte_cpp_byte_const_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count, long offset)
	{
		long num = offset;
		unchecked
		{
			do
			{
				builtin_Memcpy_32ul_block_offset_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, num);
				num += 32L;
			}
			while ((ulong)num < (ulong)(count - 32L));
			builtin_Memcpy_32ul_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst, src, count);
		}
	}
}
