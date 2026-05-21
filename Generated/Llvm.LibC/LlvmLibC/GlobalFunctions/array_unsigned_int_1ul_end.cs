using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_int_1ul_end
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIjLm1EE3endEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>::end() const")]
	public unsafe static void* Invoke(cpp_array_2v7m9i* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 4;
	}
}
