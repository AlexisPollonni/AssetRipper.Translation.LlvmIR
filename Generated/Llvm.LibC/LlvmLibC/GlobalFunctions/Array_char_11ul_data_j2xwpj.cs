using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_char_11ul_data_j2xwpj
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIcLm11EE4dataEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 11ul>::data() const")]
	[CleanName("Array_char_11ul_data")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_array_sbzi9g* This)
	{
		return &This->Data;
	}
}
