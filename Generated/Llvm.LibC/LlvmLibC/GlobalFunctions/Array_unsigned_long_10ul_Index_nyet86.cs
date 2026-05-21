using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_10ul_Index_nyet86
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm10EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 10ul>::operator[](unsigned long)")]
	[CleanName("Array_unsigned_long_10ul_Index")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_array_f7mn55* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 8);
	}
}
