using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_str
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp12StringStream3strEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::str() const")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("this")] void* This)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, Span_char_data.Invoke(&((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Buffer), ((Llvm_libc_20_1_2_details_StringBufferWriterImpl*)This)->Index);
			return *(Struct_kqhe8i*)(&llvm_libc_20_1_2_cpp_string_view);
		}
	}
}
