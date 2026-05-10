using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIjLm1EE3endEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>::end() const")]
internal static partial class cpp_array_unsigned_int_1ul_end_const
{
	public unsafe static void* Invoke(void* @this)
	{
		return unchecked((byte*)(&((cpp_array_aj48id*)@this)->Data)) + 4;
	}
}
