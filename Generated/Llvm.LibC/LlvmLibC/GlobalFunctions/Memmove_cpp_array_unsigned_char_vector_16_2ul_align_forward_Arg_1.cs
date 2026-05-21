using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_vector_16_2ul_align_forward_Arg_1
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm2EEEE13align_forwardILNS_3ArgE1EEEvRPNS2_4byteERPKS9_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::align_forward<(__llvm_libc_20_1_2_::Arg)1>(__llvm_libc_20_1_2_::cpp::byte*&, __llvm_libc_20_1_2_::cpp::byte const*&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*&")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*&")] void* Src, [MangledName("count")][NativeType("unsigned long&")] void* Count)
	{
		void* dst = null;
		void* src = null;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &dst);
		unchecked
		{
			dst = *(void**)Dst;
			Llvm_lifetime_start_p0.Invoke(8L, &src);
			src = *(void**)Src;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = *(long*)Count;
			Llvm_libc_20_1_2_align_to_next_boundary_32ul_Arg_1_cpp_byte_cpp_byte_const.Invoke(Dst, Src, Count);
			Llvm_libc_20_1_2_adjust_cpp_byte_cpp_byte_const.Invoke(32L, Dst, Src, Count);
			Memmove_cpp_array_unsigned_char_vector_16_2ul_head_tail.Invoke(dst, src, num - *(long*)Count);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &src);
			Llvm_lifetime_end_p0.Invoke(8L, &dst);
		}
	}
}
