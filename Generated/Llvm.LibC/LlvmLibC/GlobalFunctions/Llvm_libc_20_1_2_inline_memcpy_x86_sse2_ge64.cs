using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memcpy_x86_sse2_ge64
{
	[MangledName("_ZN19__llvm_libc_20_1_2_27inline_memcpy_x86_sse2_ge64EPNS_3cpp4byteEPKS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memcpy_x86_sse2_ge64(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		void* dst = null;
		void* src = null;
		long num = 0L;
		dst = Dst;
		src = Src;
		num = Count;
		if (unchecked((ulong)num) <= 128uL)
		{
			Memcpy_64ul_head_tail.Invoke(dst, src, num);
			return;
		}
		Memcpy_32ul_block.Invoke(dst, src);
		Llvm_libc_20_1_2_align_to_next_boundary_32ul_Arg_0_cpp_byte_cpp_byte_const.Invoke(&dst, &src, &num);
		Memcpy_32ul_loop_and_tail.Invoke(dst, src, num);
	}
}
