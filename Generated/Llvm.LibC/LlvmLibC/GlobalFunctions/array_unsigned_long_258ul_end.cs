using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_long_258ul_end
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm258EE3endEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>::end()")]
	public unsafe static void* Invoke(cpp_array_anzbtp* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 2064;
	}
}
