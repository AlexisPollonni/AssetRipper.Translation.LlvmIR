using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringBufferWriterImpl_false_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EEC2ENS_3cpp4spanIcEE")]
	[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::StringBufferWriterImpl(__llvm_libc_20_1_2_::cpp::span<char>)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_details_StringBufferWriterImpl* This, [MangledName("buffer.coerce0")] void* Buffer, [MangledName("buffer.coerce1")] long Buffer_coerce1)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			*(void**)(&llvm_libc_20_1_2_cpp_string_view) = Buffer;
			((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = Buffer_coerce1;
			Span_char_span_char_true.Invoke(&This->Buffer, &llvm_libc_20_1_2_cpp_string_view);
			This->Index = 0L;
			This->Out_of_range = 0;
		}
	}
}
