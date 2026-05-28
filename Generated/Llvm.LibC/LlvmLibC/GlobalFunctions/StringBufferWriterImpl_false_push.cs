using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringBufferWriterImpl_false_push
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE4pushEc")]
	[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::push(char)")]
	public unsafe static Details_StringBufferWriterImpl* Invoke([MangledName("this")] Details_StringBufferWriterImpl* This, [MangledName("c")][NativeType("char")] sbyte C)
	{
		sbyte b = C;
		unchecked
		{
			if (StringBufferWriterImpl_false_ok.Invoke(This))
			{
				if (!StringBufferWriterImpl_false_full.Invoke(This))
				{
					*(sbyte*)Span_char_Index.Invoke(&This->Buffer, StringBufferWriterImpl_false_location.Invoke(This)) = b;
					This->Index++;
				}
				else
				{
					This->Out_of_range = 1;
				}
			}
			return This;
		}
	}
}
