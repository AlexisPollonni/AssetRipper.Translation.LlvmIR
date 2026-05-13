using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayImLm258EE3endEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>::end()")]
internal static partial class cpp_array_unsigned_long_258ul_end
{
	public unsafe static void* Invoke(cpp_array_vnnqx8* @this)
	{
		return unchecked((byte*)(&@this->Data)) + 2064;
	}
}
