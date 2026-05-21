using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringBufferWriterImpl_false_push
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE4pushEc")]
	[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::push(char)")]
	public unsafe static details_StringBufferWriterImpl* Invoke(details_StringBufferWriterImpl* @this, [NativeType("char")] sbyte c)
	{
		sbyte b = c;
		unchecked
		{
			if (StringBufferWriterImpl_false_ok.Invoke(@this))
			{
				if (!StringBufferWriterImpl_false_full.Invoke(@this))
				{
					*(sbyte*)span_char_Index.Invoke(&@this->buffer, StringBufferWriterImpl_false_location.Invoke(@this)) = b;
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
