using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_8ul_Index_32sgdp
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm8EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 8ul>::operator[](unsigned long) const")]
	[CleanName("Array_unsigned_long_8ul_Index")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_array_uibb79* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 8);
	}
}
