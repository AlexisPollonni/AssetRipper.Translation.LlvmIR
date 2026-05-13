using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_22align_to_next_boundaryILm32ELNS_3ArgE1ENS_3cpp4byteEKS3_EEvRrPT1_RrPT2_Rm")]
[DemangledName("void __llvm_libc_20_1_2_::align_to_next_boundary<32ul, (__llvm_libc_20_1_2_::Arg)1, __llvm_libc_20_1_2_::cpp::byte, __llvm_libc_20_1_2_::cpp::byte const>(__llvm_libc_20_1_2_::cpp::byte* restrict&, __llvm_libc_20_1_2_::cpp::byte const* restrict&, unsigned long&)")]
internal static partial class void_align_to_next_boundary_32ul_Arg_1_cpp_byte_cpp_byte_const_cpp_byte_restrict_cpp_byte_const_restrict_unsigned_long
{
	public unsafe static void Invoke(void* p1, void* p2, void* count)
	{
		void_align_p1_to_next_boundary_32ul_cpp_byte_const_cpp_byte_cpp_byte_const_restrict_cpp_byte_restrict_unsigned_long.Invoke(p2, p1, count);
	}
}
