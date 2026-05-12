using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10CharVector6lengthEv")]
[DemangledName("__llvm_libc_20_1_2_::CharVector::length()")]
internal static partial class CharVector_length
{
	public unsafe static long Invoke(CharVector* @this)
	{
		return @this->index;
	}
}
