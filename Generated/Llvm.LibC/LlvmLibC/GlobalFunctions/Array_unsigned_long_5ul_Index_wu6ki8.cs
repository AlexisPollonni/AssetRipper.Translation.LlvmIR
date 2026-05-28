using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_5ul_Index_wu6ki8
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm5EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>::operator[](unsigned long)")]
	[CleanName("Array_unsigned_long_5ul_Index")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_msasyg* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 8);
	}
}
