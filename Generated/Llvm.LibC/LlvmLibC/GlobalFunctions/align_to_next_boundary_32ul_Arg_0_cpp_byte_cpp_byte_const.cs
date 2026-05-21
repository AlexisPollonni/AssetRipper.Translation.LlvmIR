using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class align_to_next_boundary_32ul_Arg_0_cpp_byte_cpp_byte_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_22align_to_next_boundaryILm32ELNS_3ArgE0ENS_3cpp4byteEKS3_EEvRrPT1_RrPT2_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::align_to_next_boundary<32ul, (__llvm_libc_20_1_2_::Arg)0, __llvm_libc_20_1_2_::cpp::byte, __llvm_libc_20_1_2_::cpp::byte const>(__llvm_libc_20_1_2_::cpp::byte* restrict&, __llvm_libc_20_1_2_::cpp::byte const* restrict&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte* restrict&")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const* restrict&")] void* p2, [NativeType("unsigned long&")] void* count)
	{
		align_p1_to_next_boundary_32ul_cpp_byte_cpp_byte_const.Invoke(p1, p2, count);
	}
}
