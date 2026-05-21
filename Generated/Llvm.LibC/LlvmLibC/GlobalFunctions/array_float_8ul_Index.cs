using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_float_8ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm8EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 8ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&((cpp_array_dsir8b*)@this)->Data) + (nint)Index * sizeof(float));
	}
}
