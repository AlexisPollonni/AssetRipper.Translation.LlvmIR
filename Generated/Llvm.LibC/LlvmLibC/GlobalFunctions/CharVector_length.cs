using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class CharVector_length
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10CharVector6lengthEv")]
	[DemangledName("__llvm_libc_20_1_2_::CharVector::length()")]
	public unsafe static long Invoke([MangledName("this")] CharVector* This)
	{
		return This->Index;
	}
}
