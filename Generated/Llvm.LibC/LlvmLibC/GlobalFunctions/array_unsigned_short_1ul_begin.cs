using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_short_1ul_begin
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayItLm1EE5beginEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>::begin() const")]
	public unsafe static void* Invoke(cpp_array_knh6hw* @this)
	{
		return &@this->Data;
	}
}
