using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm3EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 3ul>::operator[](unsigned long) const")]
internal static partial class cpp_array_unsigned_long_3ul_operator_unsigned_long_const
{
	public unsafe static void* Invoke(cpp_array_8cyvs4* @this, long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 8);
	}
}
