using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_write_c69wyf
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEE13IntegerWriter5writeElRNS1_22StringBufferWriterImplILb0EEE")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::IntegerWriter::write(long, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
	[CleanName("IntegerWriter_write")]
	public unsafe static void Invoke([MangledName("value")][NativeType("long")] long Value, [MangledName("sink")][NativeType("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&")] Llvm_libc_20_1_2_details_StringBufferWriterImpl* Sink)
	{
		IntegerWriter_write_unsigned_number_m63729.Invoke(IntegerWriter_abs_zj72qx.Invoke(Value), Sink);
		while (StringBufferWriterImpl_false_ok.Invoke(Sink) && unchecked((ulong)StringBufferWriterImpl_false_size.Invoke(Sink)) < 2uL)
		{
			StringBufferWriterImpl_false_push.Invoke(Sink, 48);
		}
		if (Value < 0L)
		{
			StringBufferWriterImpl_false_push.Invoke(Sink, 45);
		}
		else
		{
			StringBufferWriterImpl_false_push.Invoke(Sink, 43);
		}
	}
}
