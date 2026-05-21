using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_float_32ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm32EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 32ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&((cpp_array_etzvdw*)@this)->Data) + (nint)Index * sizeof(float));
	}
}
