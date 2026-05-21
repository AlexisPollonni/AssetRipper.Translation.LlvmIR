using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_float_31ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm31EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 31ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke(cpp_array_55dk65* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * sizeof(float));
	}
}
