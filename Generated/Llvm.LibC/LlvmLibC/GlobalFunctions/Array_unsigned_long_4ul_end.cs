using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_4ul_end
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm4EE3endEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>::end() const")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_array_jgy3xh* This)
	{
		return unchecked((byte*)(&This->Data)) + 32;
	}
}
