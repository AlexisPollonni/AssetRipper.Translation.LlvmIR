using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm5EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_long_5ul_operator_unsigned_long
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_v97b5b*)@this)->Data) + (nint)Index * 8);
	}
}
