using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_short_1ul_begin
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayItLm1EE5beginEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>::begin() const")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_knh6hw* This)
	{
		return &This->Data;
	}
}
