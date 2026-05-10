using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10CharVectorC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::CharVector::CharVector()")]
[CleanName("CharVector_CharVector")]
internal static partial class CharVector_CharVector_yauiu7
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			((CharVector*)@this)->cur_str = &((CharVector*)@this)->local_buffer;
			((CharVector*)@this)->cur_buff_size = 64L;
			((CharVector*)@this)->index = 0L;
		}
	}
}
