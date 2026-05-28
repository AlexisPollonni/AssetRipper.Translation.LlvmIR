using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_float_31ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm31EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 31ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_55dk65* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * sizeof(float));
	}
}
