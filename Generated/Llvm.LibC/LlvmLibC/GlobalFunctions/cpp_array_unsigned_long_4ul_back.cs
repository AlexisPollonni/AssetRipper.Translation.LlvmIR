using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm4EE4backEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>::back()")]
internal static partial class cpp_array_unsigned_long_4ul_back
{
	public unsafe static void* Invoke(cpp_array_jgy3xh* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 24;
	}
}
