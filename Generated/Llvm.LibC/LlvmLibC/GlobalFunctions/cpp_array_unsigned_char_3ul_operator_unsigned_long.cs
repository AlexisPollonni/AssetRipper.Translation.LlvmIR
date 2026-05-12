using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIhLm3EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_char_3ul_operator_unsigned_long
{
	public unsafe static void* Invoke(cpp_array_cdhstp* @this, long Index)
	{
		return unchecked((byte*)(&@this->Data)) + Index;
	}
}
