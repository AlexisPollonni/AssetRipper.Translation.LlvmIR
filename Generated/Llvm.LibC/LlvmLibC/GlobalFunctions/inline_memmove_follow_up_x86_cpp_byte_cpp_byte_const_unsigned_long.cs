using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_28inline_memmove_follow_up_x86EPNS_3cpp4byteEPKS1_m")]
[DemangledName("__llvm_libc_20_1_2_::inline_memmove_follow_up_x86(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*, unsigned long)")]
internal static partial class inline_memmove_follow_up_x86_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, long count)
	{
		void* ptr = null;
		void* ptr2 = null;
		long count2 = 0L;
		ptr = dst;
		ptr2 = src;
		count2 = count;
		if (ptr < ptr2)
		{
			void_generic_Memmove_cpp_array_unsigned_char_vector_16_2ul_align_forward_Arg_1_cpp_byte_cpp_byte_const_unsigned_long.Invoke(&ptr, &ptr2, &count2);
			generic_Memmove_cpp_array_unsigned_char_vector_16_4ul_loop_and_tail_forward_cpp_byte_cpp_byte_const_unsigned_long.Invoke(ptr, ptr2, count2);
		}
		else
		{
			void_generic_Memmove_cpp_array_unsigned_char_vector_16_2ul_align_backward_Arg_1_cpp_byte_cpp_byte_const_unsigned_long.Invoke(&ptr, &ptr2, &count2);
			generic_Memmove_cpp_array_unsigned_char_vector_16_4ul_loop_and_tail_backward_cpp_byte_cpp_byte_const_unsigned_long.Invoke(ptr, ptr2, count2);
		}
	}
}
