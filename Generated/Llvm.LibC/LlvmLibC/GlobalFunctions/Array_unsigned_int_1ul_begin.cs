using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_int_1ul_begin
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIjLm1EE5beginEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>::begin() const")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_array_2v7m9i* This)
	{
		return &This->Data;
	}
}
