using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm1EE3endEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>::end() const")]
internal static partial class cpp_array_unsigned_long_1ul_end_const
{
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((byte*)(&((cpp_array_rpgxvv*)@this)->Data)) + 8;
	}
}
