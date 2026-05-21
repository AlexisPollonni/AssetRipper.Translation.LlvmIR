using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_short_1ul_end
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayItLm1EE3endEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>::end() const")]
	public unsafe static void* Invoke(cpp_array_knh6hw* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 2;
	}
}
