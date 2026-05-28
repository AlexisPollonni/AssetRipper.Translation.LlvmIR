using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_4ul_Index_pwcpnu
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm4EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>::operator[](unsigned long) const")]
	[CleanName("Array_unsigned_long_4ul_Index")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_jgy3xh* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 8);
	}
}
