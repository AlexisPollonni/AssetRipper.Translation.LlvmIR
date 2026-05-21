using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_int_1ul_Index_ejbtjs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIjLm1EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>::operator[](unsigned long)")]
	[CleanName("array_unsigned_int_1ul_Index")]
	public unsafe static void* Invoke(cpp_array_2v7m9i* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 4);
	}
}
