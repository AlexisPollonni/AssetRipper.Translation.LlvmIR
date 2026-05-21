using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_char_21ul_data_wkczjf
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIcLm21EE4dataEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 21ul>::data() const")]
	[CleanName("array_char_21ul_data")]
	public unsafe static void* Invoke(cpp_array_qkm4kn* @this)
	{
		return &@this->Data;
	}
}
