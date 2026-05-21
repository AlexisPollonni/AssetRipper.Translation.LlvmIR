using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_1ul_Index_3erz3i
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm1EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>::operator[](unsigned long)")]
	[CleanName("array_unsigned_long_1ul_Index")]
	public unsafe static void* Invoke(cpp_array_rpgxvv* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 8);
	}
}
