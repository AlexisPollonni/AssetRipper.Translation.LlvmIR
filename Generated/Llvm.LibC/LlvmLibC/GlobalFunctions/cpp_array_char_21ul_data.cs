using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm21EE4dataEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 21ul>::data()")]
internal static partial class cpp_array_char_21ul_data
{
	public unsafe static void* Invoke(cpp_array_qkm4kn* @this)
	{
		return &@this->Data;
	}
}
