using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_align_p1_to_next_boundary_32ul_cpp_byte_const_cpp_byte
{
	[MangledName("_ZN19__llvm_libc_20_1_2_25align_p1_to_next_boundaryILm32EKNS_3cpp4byteES2_EEvRrPT0_RrPT1_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::align_p1_to_next_boundary<32ul, __llvm_libc_20_1_2_::cpp::byte const, __llvm_libc_20_1_2_::cpp::byte>(__llvm_libc_20_1_2_::cpp::byte const* restrict&, __llvm_libc_20_1_2_::cpp::byte* restrict&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const* restrict&")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte* restrict&")] void* P2, [MangledName("count")][NativeType("unsigned long&")] void* Count)
	{
		unchecked
		{
			Llvm_libc_20_1_2_adjust_cpp_byte_const_cpp_byte.Invoke(Llvm_libc_20_1_2_distance_to_next_aligned_32ul.Invoke(*(void**)P1), P1, P2, Count);
			*(void**)P1 = Llvm_libc_20_1_2_assume_aligned_32ul_cpp_byte_const.Invoke(*(void**)P1);
		}
	}
}
