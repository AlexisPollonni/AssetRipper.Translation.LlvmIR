using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_8ul_Index_32sgdp
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm8EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 8ul>::operator[](unsigned long) const")]
	[CleanName("array_unsigned_long_8ul_Index")]
	public unsafe static void* Invoke(cpp_array_uibb79* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 8);
	}
}
