using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_memcpy_x86_sse2_ge64
{
	[MangledName("_ZN19__llvm_libc_20_1_2_27inline_memcpy_x86_sse2_ge64EPNS_3cpp4byteEPKS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memcpy_x86_sse2_ge64(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src, [NativeType("unsigned long")] long count)
	{
		void* dst2 = null;
		void* src2 = null;
		long num = 0L;
		dst2 = dst;
		src2 = src;
		num = count;
		if (unchecked((ulong)num) <= 128uL)
		{
			Memcpy_64ul_head_tail.Invoke(dst2, src2, num);
			return;
		}
		Memcpy_32ul_block.Invoke(dst2, src2);
		align_to_next_boundary_32ul_Arg_0_cpp_byte_cpp_byte_const.Invoke(&dst2, &src2, &num);
		Memcpy_32ul_loop_and_tail.Invoke(dst2, src2, num);
	}
}
