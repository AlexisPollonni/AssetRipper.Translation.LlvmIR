using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_char_265ul_Index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIcLm265EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<char, 265ul>::operator[](unsigned long)")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_knc3mr* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data)) + Index;
	}
}
