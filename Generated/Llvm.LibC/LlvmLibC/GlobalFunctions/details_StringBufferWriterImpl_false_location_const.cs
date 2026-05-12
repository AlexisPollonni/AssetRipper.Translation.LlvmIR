using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE8locationEv")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::location() const")]
internal static partial class details_StringBufferWriterImpl_false_location_const
{
	public unsafe static long Invoke(details_StringBufferWriterImpl* @this)
	{
		return unchecked(cpp_span_char_size_const.Invoke(&@this->buffer) - 1L - @this->index);
	}
}
