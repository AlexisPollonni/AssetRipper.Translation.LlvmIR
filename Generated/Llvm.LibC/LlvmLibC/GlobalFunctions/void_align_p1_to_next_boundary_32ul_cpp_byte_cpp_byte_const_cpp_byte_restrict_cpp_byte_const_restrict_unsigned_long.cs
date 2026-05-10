using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_25align_p1_to_next_boundaryILm32ENS_3cpp4byteEKS2_EEvRrPT0_RrPT1_Rm")]
[DemangledName("void __llvm_libc_20_1_2_::align_p1_to_next_boundary<32ul, __llvm_libc_20_1_2_::cpp::byte, __llvm_libc_20_1_2_::cpp::byte const>(__llvm_libc_20_1_2_::cpp::byte* restrict&, __llvm_libc_20_1_2_::cpp::byte const* restrict&, unsigned long&)")]
internal static partial class void_align_p1_to_next_boundary_32ul_cpp_byte_cpp_byte_const_cpp_byte_restrict_cpp_byte_const_restrict_unsigned_long
{
	public unsafe static void Invoke(void* p1, void* p2, void* count)
	{
		unchecked
		{
			void_adjust_cpp_byte_cpp_byte_const_long_cpp_byte_restrict_cpp_byte_const_restrict_unsigned_long.Invoke(unsigned_long_distance_to_next_aligned_32ul_void_const.Invoke(*(void**)p1), p1, p2, count);
			*(void**)p1 = cpp_byte_assume_aligned_32ul_cpp_byte_cpp_byte.Invoke(*(void**)p1);
		}
	}
}
