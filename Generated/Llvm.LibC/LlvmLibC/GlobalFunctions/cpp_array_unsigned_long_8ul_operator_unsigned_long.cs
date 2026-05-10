using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm8EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 8ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_long_8ul_operator_unsigned_long
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_uibb79*)@this)->Data) + (nint)Index * 8);
	}
}
