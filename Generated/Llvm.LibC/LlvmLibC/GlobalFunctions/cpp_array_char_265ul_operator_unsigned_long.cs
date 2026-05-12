using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm265EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 265ul>::operator[](unsigned long)")]
internal static partial class cpp_array_char_265ul_operator_unsigned_long
{
	public unsafe static void* Invoke(cpp_array_55kc72* @this, long Index)
	{
		return unchecked((byte*)(&@this->Data)) + Index;
	}
}
