using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class StringBufferWriterImpl_false_location
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EE8locationEv")]
	[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>::location() const")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_details_StringBufferWriterImpl* This)
	{
		return unchecked(Span_char_size.Invoke(&This->Buffer) - 1L - This->Index);
	}
}
