using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_27inline_memcpy_x86_sse2_ge64EPNS_3cpp4byteEPKS1_m")]
[DemangledName("__llvm_libc_20_1_2_::inline_memcpy_x86_sse2_ge64(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class inline_memcpy_x86_sse2_ge64_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		void* dst2 = null;
		void* src2 = null;
		long num = 0L;
		dst2 = dst;
		src2 = src;
		num = count;
		if (unchecked((ulong)num) <= 128uL)
		{
			builtin_Memcpy_64ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst2, src2, num);
			return;
		}
		builtin_Memcpy_32ul_block_cpp_byte_cpp_byte_const.Invoke(dst2, src2);
		void_align_to_next_boundary_32ul_Arg_0_cpp_byte_cpp_byte_const_cpp_byte_restrict_cpp_byte_const_restrict_unsigned_long.Invoke(&dst2, &src2, &num);
		builtin_Memcpy_32ul_loop_and_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst2, src2, num);
	}
}
