using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm11EE4dataEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 11ul>::data()")]
internal static partial class cpp_array_char_11ul_data
{
	public unsafe static void* Invoke(cpp_array_sbzi9g* @this)
	{
		return &@this->Data;
	}
}
