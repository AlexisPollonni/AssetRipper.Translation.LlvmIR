using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm265EE4dataEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 265ul>::data()")]
internal static partial class cpp_array_char_265ul_data
{
	public unsafe static void* Invoke(cpp_array_knc3mr* @this)
	{
		return &@this->Data;
	}
}
