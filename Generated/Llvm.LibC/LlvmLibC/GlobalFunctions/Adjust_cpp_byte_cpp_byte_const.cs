using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Adjust_cpp_byte_cpp_byte_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6adjustINS_3cpp4byteEKS2_EEvlRrPT_RrPT0_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::adjust<__llvm_libc_20_1_2_::cpp::byte, __llvm_libc_20_1_2_::cpp::byte const>(long, __llvm_libc_20_1_2_::cpp::byte* restrict&, __llvm_libc_20_1_2_::cpp::byte const* restrict&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("offset")][NativeType("long")] long Offset, [MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte* restrict&")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte const* restrict&")] void* P2, [MangledName("count")][NativeType("unsigned long&")] void* Count)
	{
		unchecked
		{
			*(IntPtr*)P1 += (nint)Offset;
			*(IntPtr*)P2 += (nint)Offset;
			*(long*)Count -= Offset;
		}
	}
}
