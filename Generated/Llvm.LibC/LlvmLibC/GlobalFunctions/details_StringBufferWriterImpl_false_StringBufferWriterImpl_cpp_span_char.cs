using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EEC2ENS_3cpp4spanIcEE")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::StringBufferWriterImpl(__llvm_libc_20_1_2_::cpp::span<char>)")]
internal static partial class details_StringBufferWriterImpl_false_StringBufferWriterImpl_cpp_span_char
{
	public unsafe static void Invoke(details_StringBufferWriterImpl* @this, [MangledName("buffer.coerce0")] void* buffer, [MangledName("buffer.coerce1")] long buffer_coerce1)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			*(void**)(&cpp_string_view2) = buffer;
			((long*)(&cpp_string_view2))[1] = buffer_coerce1;
			cpp_span_char_span_char_true_cpp_span_char.Invoke(&@this->buffer, &cpp_string_view2);
			@this->index = 0L;
			@this->out_of_range = 0;
		}
	}
}
