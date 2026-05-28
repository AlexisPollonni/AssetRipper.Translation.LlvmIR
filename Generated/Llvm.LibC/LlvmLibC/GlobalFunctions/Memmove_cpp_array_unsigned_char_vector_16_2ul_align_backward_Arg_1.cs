using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_vector_16_2ul_align_backward_Arg_1
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIDv16_hLm2EEEE14align_backwardILNS_3ArgE1EEEvRPNS2_4byteERPKS9_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>>::align_backward<(__llvm_libc_20_1_2_::Arg)1>(__llvm_libc_20_1_2_::cpp::byte*&, __llvm_libc_20_1_2_::cpp::byte const*&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*&")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*&")] void* Src, [MangledName("count")][NativeType("unsigned long&")] void* Count)
	{
		void* dst = null;
		void* src = null;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &dst);
		unchecked
		{
			dst = (void*)((nint)(*(IntPtr*)Dst) + (nint)(*(long*)Count));
			Llvm_lifetime_start_p0.Invoke(8L, &src);
			src = (void*)((nint)(*(IntPtr*)Src) + (nint)(*(long*)Count));
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			Align_to_next_boundary_32ul_Arg_1_cpp_byte_cpp_byte_const.Invoke(&dst, &src, &num);
			Adjust_cpp_byte_cpp_byte_const.Invoke(-64L, &dst, &src, &num);
			Memmove_cpp_array_unsigned_char_vector_16_2ul_head_tail.Invoke(dst, src, num);
			*(long*)Count -= num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &src);
			Llvm_lifetime_end_p0.Invoke(8L, &dst);
		}
	}
}
