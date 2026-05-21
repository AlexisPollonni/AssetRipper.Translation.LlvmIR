using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_3ul_Index_urpq28
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm3EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 3ul>::operator[](unsigned long) const")]
	[CleanName("array_unsigned_long_3ul_Index")]
	public unsafe static void* Invoke(cpp_array_tqfcue* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 8);
	}
}
