using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_char_265ul_data
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm265EE4dataEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 265ul>::data()")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_array_knc3mr* This)
	{
		return &This->Data;
	}
}
