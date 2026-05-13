using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm2EEEE13align_forwardILNS_3ArgE1EEEvRPNS2_4byteERPKS9_Rm")]
[DemangledName("void __llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::align_forward<(__llvm_libc_20_1_2_::Arg)1>(__llvm_libc_20_1_2_::cpp::byte*&, __llvm_libc_20_1_2_::cpp::byte const*&, unsigned long&)")]
internal static partial class void_generic_Memmove_cpp_array_unsigned_char_vector_16_2ul_align_forward_Arg_1_cpp_byte_cpp_byte_const_unsigned_long
{
	public unsafe static void Invoke(void* dst, void* src, void* count)
	{
		void* dst2 = null;
		void* src2 = null;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &dst2);
		unchecked
		{
			dst2 = *(void**)dst;
			llvm_lifetime_start_p0.Invoke(8L, &src2);
			src2 = *(void**)src;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = *(long*)count;
			void_align_to_next_boundary_32ul_Arg_1_cpp_byte_cpp_byte_const_cpp_byte_restrict_cpp_byte_const_restrict_unsigned_long.Invoke(dst, src, count);
			void_adjust_cpp_byte_cpp_byte_const_long_cpp_byte_restrict_cpp_byte_const_restrict_unsigned_long.Invoke(32L, dst, src, count);
			generic_Memmove_cpp_array_unsigned_char_vector_16_2ul_head_tail_cpp_byte_cpp_byte_const_unsigned_long.Invoke(dst2, src2, num - *(long*)count);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &src2);
			llvm_lifetime_end_p0.Invoke(8L, &dst2);
		}
	}
}
