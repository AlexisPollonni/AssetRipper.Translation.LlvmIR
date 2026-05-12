using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm2EE4backEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::back()")]
internal static partial class cpp_array_unsigned_long_2ul_back
{
	public unsafe static void* Invoke(cpp_array_i3937k* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 8;
	}
}
