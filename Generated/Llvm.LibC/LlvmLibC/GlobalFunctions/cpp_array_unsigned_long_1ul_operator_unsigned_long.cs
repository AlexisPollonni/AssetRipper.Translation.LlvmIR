using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm1EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_long_1ul_operator_unsigned_long
{
	public unsafe static void* Invoke(cpp_array_rpgxvv* @this, long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 8);
	}
}
