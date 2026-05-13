using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIcLm11EE4dataEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 11ul>::data() const")]
internal static partial class cpp_array_char_11ul_data_const
{
	public unsafe static void* Invoke(cpp_array_be88n4* @this)
	{
		return &@this->Data;
	}
}
