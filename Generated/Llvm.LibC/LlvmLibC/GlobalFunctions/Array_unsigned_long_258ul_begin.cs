using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_long_258ul_begin
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm258EE5beginEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>::begin()")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_anzbtp* This)
	{
		return &This->Data;
	}
}
