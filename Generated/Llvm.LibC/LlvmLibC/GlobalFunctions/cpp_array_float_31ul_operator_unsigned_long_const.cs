using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIfLm31EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<float, 31ul>::operator[](unsigned long) const")]
internal static partial class cpp_array_float_31ul_operator_unsigned_long_const
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_fe7abs*)@this)->Data) + (nint)Index * sizeof(float));
	}
}
