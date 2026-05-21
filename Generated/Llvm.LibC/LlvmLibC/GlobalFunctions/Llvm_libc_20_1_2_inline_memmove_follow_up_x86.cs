using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_memmove_follow_up_x86
{
	[MangledName("_ZN19__llvm_libc_20_1_2_28inline_memmove_follow_up_x86EPNS_3cpp4byteEPKS1_m")]
	[DemangledName("__llvm_libc_20_1_2_::inline_memmove_follow_up_x86(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		void* ptr = null;
		void* ptr2 = null;
		long count = 0L;
		ptr = Dst;
		ptr2 = Src;
		count = Count;
		if (ptr < ptr2)
		{
			Memmove_cpp_array_unsigned_char_vector_16_2ul_align_forward_Arg_1.Invoke(&ptr, &ptr2, &count);
			Memmove_cpp_array_unsigned_char_vector_16_4ul_loop_and_tail_forward.Invoke(ptr, ptr2, count);
		}
		else
		{
			Memmove_cpp_array_unsigned_char_vector_16_2ul_align_backward_Arg_1.Invoke(&ptr, &ptr2, &count);
			Memmove_cpp_array_unsigned_char_vector_16_4ul_loop_and_tail_backward.Invoke(ptr, ptr2, count);
		}
	}
}
