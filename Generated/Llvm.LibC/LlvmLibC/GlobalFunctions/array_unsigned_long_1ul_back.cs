using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_1ul_back
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm1EE4backEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>::back()")]
	public unsafe static void* Invoke(cpp_array_rpgxvv* @this)
	{
		return &@this->Data;
	}
}
