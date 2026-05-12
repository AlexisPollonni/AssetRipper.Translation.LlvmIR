using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIjLm1EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_int_1ul_operator_unsigned_long
{
	public unsafe static void* Invoke(cpp_array_aj48id* @this, long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 4);
	}
}
