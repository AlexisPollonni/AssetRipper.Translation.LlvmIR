using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_258ul_Index_7gdq4k
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm258EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>::operator[](unsigned long) const")]
	[CleanName("Array_unsigned_long_258ul_Index")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_anzbtp* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 8);
	}
}
