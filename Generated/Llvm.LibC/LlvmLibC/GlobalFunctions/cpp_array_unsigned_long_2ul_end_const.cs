using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm2EE3endEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::end() const")]
internal static partial class cpp_array_unsigned_long_2ul_end_const
{
	public unsafe static void* Invoke(cpp_array_i3937k* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 16;
	}
}
