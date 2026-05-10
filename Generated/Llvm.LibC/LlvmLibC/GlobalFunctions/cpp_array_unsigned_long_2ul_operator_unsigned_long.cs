using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm2EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_long_2ul_operator_unsigned_long
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_i3937k*)@this)->Data) + (nint)Index * 8);
	}
}
