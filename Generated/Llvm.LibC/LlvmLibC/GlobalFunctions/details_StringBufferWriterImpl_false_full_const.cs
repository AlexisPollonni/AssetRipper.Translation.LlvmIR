using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE4fullEv")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::full() const")]
internal static partial class details_StringBufferWriterImpl_false_full_const
{
	public unsafe static bool Invoke(void* @this)
	{
		return details_StringBufferWriterImpl_false_size_const.Invoke(@this) == cpp_span_char_size_const.Invoke(&unchecked((details_StringBufferWriterImpl*)@this)->buffer);
	}
}
