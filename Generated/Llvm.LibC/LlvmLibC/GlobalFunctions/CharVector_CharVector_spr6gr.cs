using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10CharVectorD2Ev")]
[DemangledName("__llvm_libc_20_1_2_::CharVector::~CharVector()")]
[CleanName("CharVector_CharVector")]
internal static partial class CharVector_CharVector_spr6gr
{
	public unsafe static void Invoke(CharVector* @this)
	{
		if (@this->cur_str != &@this->local_buffer)
		{
			free.Invoke(@this->cur_str);
		}
	}
}
