using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_2ul_begin
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm2EE5beginEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::begin() const")]
	public unsafe static void* Invoke(cpp_array_i3937k* @this)
	{
		return &@this->Data;
	}
}
