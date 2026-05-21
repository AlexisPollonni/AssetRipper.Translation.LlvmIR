using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_adjust_cpp_byte_const_cpp_byte
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6adjustIKNS_3cpp4byteES2_EEvlRrPT_RrPT0_Rm")]
	[DemangledName("void __llvm_libc_20_1_2_::adjust<__llvm_libc_20_1_2_::cpp::byte const, __llvm_libc_20_1_2_::cpp::byte>(long, __llvm_libc_20_1_2_::cpp::byte const* restrict&, __llvm_libc_20_1_2_::cpp::byte* restrict&, unsigned long&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("offset")][NativeType("long")] long Offset, [MangledName("p1")][NativeType("__llvm_libc_20_1_2_::cpp::byte const* restrict&")] void* P1, [MangledName("p2")][NativeType("__llvm_libc_20_1_2_::cpp::byte* restrict&")] void* P2, [MangledName("count")][NativeType("unsigned long&")] void* Count)
	{
		unchecked
		{
			*(IntPtr*)P1 += (nint)Offset;
			*(IntPtr*)P2 += (nint)Offset;
			*(long*)Count -= Offset;
		}
	}
}
