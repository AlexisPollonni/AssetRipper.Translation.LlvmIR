using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringStream_str
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp12StringStream3strEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::str() const")]
	public unsafe static Struct_kqhe8i Invoke(void* @this)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			string_view_Constructor.Invoke(&cpp_string_view2, span_char_data.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer), ((details_StringBufferWriterImpl*)@this)->index);
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
