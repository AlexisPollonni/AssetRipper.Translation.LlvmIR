using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_1ul_begin
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm1EE5beginEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>::begin() const")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_rpgxvv* This)
	{
		return &This->Data;
	}
}
