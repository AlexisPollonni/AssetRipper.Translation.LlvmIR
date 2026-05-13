using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm4EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 4ul>::operator[](unsigned long) const")]
internal static partial class cpp_array_float_4ul_operator_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_scvvei*)@this)->Data) + (nint)Index * sizeof(float));
	}
}
