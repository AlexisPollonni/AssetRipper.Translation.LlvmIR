using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIjLm8EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 8ul>::operator[](unsigned long) const")]
internal static partial class cpp_array_unsigned_int_8ul_operator_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_wwfw4y*)@this)->Data) + (nint)Index * 4);
	}
}
