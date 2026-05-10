using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayItLm1EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_short_1ul_operator_unsigned_long
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_knh6hw*)@this)->Data) + (nint)Index * 2);
	}
}
