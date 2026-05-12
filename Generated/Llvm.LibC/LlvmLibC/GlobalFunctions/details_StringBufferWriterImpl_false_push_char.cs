using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE4pushEc")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::push(char)")]
internal static partial class details_StringBufferWriterImpl_false_push_char
{
	public unsafe static details_StringBufferWriterImpl* Invoke(details_StringBufferWriterImpl* @this, sbyte c)
	{
		sbyte b = c;
		unchecked
		{
			if (details_StringBufferWriterImpl_false_ok_const.Invoke(@this))
			{
				if (!details_StringBufferWriterImpl_false_full_const.Invoke(@this))
				{
					*(sbyte*)cpp_span_char_operator_unsigned_long_const.Invoke(&@this->buffer, details_StringBufferWriterImpl_false_location_const.Invoke(@this)) = b;
					@this->index++;
				}
				else
				{
					@this->out_of_range = 1;
				}
			}
			return @this;
		}
	}
}
