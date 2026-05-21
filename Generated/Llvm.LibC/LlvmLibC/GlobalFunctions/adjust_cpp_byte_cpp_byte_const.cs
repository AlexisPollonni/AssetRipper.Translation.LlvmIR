using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class adjust_cpp_byte_cpp_byte_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6adjustINS_3cpp4byteEKS2_EEvlRrPT_RrPT0_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::adjust<__llvm_libc_20_1_2_::cpp::byte, __llvm_libc_20_1_2_::cpp::byte const>(long, __llvm_libc_20_1_2_::cpp::byte* restrict&, __llvm_libc_20_1_2_::cpp::byte const* restrict&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("long")] long offset, [NativeType("__llvm_libc_20_1_2_::cpp::byte* restrict&")] void* p1, [NativeType("__llvm_libc_20_1_2_::cpp::byte const* restrict&")] void* p2, [NativeType("unsigned long&")] void* count)
	{
		unchecked
		{
			*(IntPtr*)p1 += (nint)offset;
			*(IntPtr*)p2 += (nint)offset;
			*(long*)count -= offset;
		}
	}
}
