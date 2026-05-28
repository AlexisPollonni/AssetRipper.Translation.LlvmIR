using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_2ul_Index_j6w6uu
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm2EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::operator[](unsigned long) const")]
	[CleanName("Array_unsigned_long_2ul_Index")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_i3937k* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 8);
	}
}
