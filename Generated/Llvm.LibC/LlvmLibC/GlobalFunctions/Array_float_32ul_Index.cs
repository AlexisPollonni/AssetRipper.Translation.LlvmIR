using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_float_32ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm32EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 32ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&((Llvm_libc_20_1_2_cpp_array_etzvdw*)This)->Data) + (nint)Index * sizeof(float));
	}
}
