using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_char_11ul_data_fyrfca
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm11EE4dataEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 11ul>::data()")]
	[CleanName("Array_char_11ul_data")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_sbzi9g* This)
	{
		return &This->Data;
	}
}
