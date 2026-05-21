using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_4ul_back
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm4EE4backEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>::back()")]
	public unsafe static void* Invoke(cpp_array_jgy3xh* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 24;
	}
}
