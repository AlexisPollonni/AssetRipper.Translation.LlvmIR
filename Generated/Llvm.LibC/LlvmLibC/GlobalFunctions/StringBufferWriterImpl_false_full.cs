using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringBufferWriterImpl_false_full
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE4fullEv")]
	[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::full() const")]
	public unsafe static bool Invoke([MangledName("this")] Details_StringBufferWriterImpl* This)
	{
		return StringBufferWriterImpl_false_size.Invoke(This) == Span_char_size.Invoke(&This->Buffer);
	}
}
