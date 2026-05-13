using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6Reader10chars_readEv")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Reader::chars_read()")]
internal static partial class scanf_core_Reader_chars_read
{
	public unsafe static long Invoke(scanf_core_Reader* @this)
	{
		return @this->cur_chars_read;
	}
}
