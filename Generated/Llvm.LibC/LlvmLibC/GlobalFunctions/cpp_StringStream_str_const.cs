using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp12StringStream3strEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::StringStream::str() const")]
internal static partial class cpp_StringStream_str_const
{
	public unsafe static Struct_kqhe8i Invoke(void* @this)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, cpp_span_char_data_const.Invoke(&((details_StringBufferWriterImpl*)@this)->buffer), ((details_StringBufferWriterImpl*)@this)->index);
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
