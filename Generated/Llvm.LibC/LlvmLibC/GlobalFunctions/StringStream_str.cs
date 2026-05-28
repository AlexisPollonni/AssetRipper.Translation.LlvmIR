using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_str
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp12StringStream3strEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::str() const")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("this")] void* This)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		unchecked
		{
			String_view_Constructor.Invoke(&cpp_string_view, Span_char_data.Invoke(&((Details_StringBufferWriterImpl*)This)->Buffer), ((Details_StringBufferWriterImpl*)This)->Index);
			return *(Struct_kqhe8i*)(&cpp_string_view);
		}
	}
}
