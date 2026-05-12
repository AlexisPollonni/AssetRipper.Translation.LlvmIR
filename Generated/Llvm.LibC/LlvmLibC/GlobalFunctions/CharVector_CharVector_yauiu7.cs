using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10CharVectorC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::CharVector::CharVector()")]
[CleanName("CharVector_CharVector")]
internal static partial class CharVector_CharVector_yauiu7
{
	public unsafe static void Invoke(CharVector* @this)
	{
		@this->cur_str = &@this->local_buffer;
		@this->cur_buff_size = 64L;
		@this->index = 0L;
	}
}
