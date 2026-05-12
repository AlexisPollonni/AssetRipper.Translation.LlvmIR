using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm10EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 10ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_long_10ul_operator_unsigned_long
{
	public unsafe static void* Invoke(cpp_array_f7mn55* @this, long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 8);
	}
}
