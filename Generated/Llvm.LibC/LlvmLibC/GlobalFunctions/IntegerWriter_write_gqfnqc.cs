using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_write_gqfnqc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter5writeEiRNS1_22StringBufferWriterImplILb0EEE")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write(int, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
	[CleanName("IntegerWriter_write")]
	public unsafe static void Invoke([MangledName("value")][NativeType("int")] int Value, [MangledName("sink")][NativeType("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&")] Llvm_libc_20_1_2_details_StringBufferWriterImpl* Sink)
	{
		IntegerWriter_write_unsigned_number_cxrqng.Invoke(IntegerWriter_abs_hawne3.Invoke(Value), Sink);
		while (StringBufferWriterImpl_false_ok.Invoke(Sink) && unchecked((ulong)StringBufferWriterImpl_false_size.Invoke(Sink)) < 1uL)
		{
			StringBufferWriterImpl_false_push.Invoke(Sink, 48);
		}
		if (Value < 0)
		{
			StringBufferWriterImpl_false_push.Invoke(Sink, 45);
		}
	}
}
