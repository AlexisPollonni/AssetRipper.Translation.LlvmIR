using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_short_1ul_Index_25c283
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayItLm1EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>::operator[](unsigned long) const")]
	[CleanName("array_unsigned_short_1ul_Index")]
	public unsafe static void* Invoke(cpp_array_knh6hw* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 2);
	}
}
