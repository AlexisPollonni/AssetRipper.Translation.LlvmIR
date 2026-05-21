using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_float_4ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm4EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 4ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&((Llvm_libc_20_1_2_cpp_array_scvvei*)This)->Data) + (nint)Index * sizeof(float));
	}
}
