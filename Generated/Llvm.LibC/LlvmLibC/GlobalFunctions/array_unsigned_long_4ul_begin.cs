using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_4ul_begin
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm4EE5beginEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>::begin() const")]
	public unsafe static void* Invoke(cpp_array_jgy3xh* @this)
	{
		return &@this->Data;
	}
}
