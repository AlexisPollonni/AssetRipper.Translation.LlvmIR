using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10CharVectorD2Ev")]
[DemangledName("__llvm_libc_20_1_2_::CharVector::~CharVector()")]
[CleanName("CharVector_CharVector")]
internal static partial class CharVector_CharVector_spr6gr
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			if (((CharVector*)@this)->cur_str != &((CharVector*)@this)->local_buffer)
			{
				free.Invoke(((CharVector*)@this)->cur_str);
			}
		}
	}
}
