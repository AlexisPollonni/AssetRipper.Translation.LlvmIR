using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Align_to_next_boundary_32ul_Arg_1_cpp_byte_cpp_byte_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_22align_to_next_boundaryILm32ELNS_3ArgE1ENS_3cpp4byteEKS3_EEvRrPT1_RrPT2_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::align_to_next_boundary<32ul, (__llvm_libc_20_1_2_::Arg)1, __llvm_libc_20_1_2_::cpp::byte, __llvm_libc_20_1_2_::cpp::byte const>(__llvm_libc_20_1_2_::cpp::byte* restrict&, __llvm_libc_20_1_2_::cpp::byte const* restrict&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte* restrict&")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const* restrict&")] void* P2, [MangledName("count")][NativeType("unsigned long&")] void* Count)
	{
		Align_p1_to_next_boundary_32ul_cpp_byte_const_cpp_byte.Invoke(P2, P1, Count);
	}
}
