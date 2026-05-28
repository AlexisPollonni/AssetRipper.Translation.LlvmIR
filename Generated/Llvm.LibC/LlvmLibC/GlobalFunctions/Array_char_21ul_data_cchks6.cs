using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_char_21ul_data_cchks6
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm21EE4dataEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 21ul>::data()")]
	[CleanName("Array_char_21ul_data")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_qkm4kn* This)
	{
		return &This->Data;
	}
}
