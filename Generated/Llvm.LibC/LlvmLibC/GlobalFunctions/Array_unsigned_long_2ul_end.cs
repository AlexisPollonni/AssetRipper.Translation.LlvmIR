using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_2ul_end
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm2EE3endEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::end() const")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_i3937k* This)
	{
		return unchecked((byte*)(&This->Data)) + 16;
	}
}
