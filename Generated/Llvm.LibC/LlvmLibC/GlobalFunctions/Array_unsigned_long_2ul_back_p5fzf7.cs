using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_2ul_back_p5fzf7
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm2EE4backEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::back()")]
	[CleanName("Array_unsigned_long_2ul_back")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_i3937k* This)
	{
		return unchecked((byte*)(&This->Data)) + 8;
	}
}
