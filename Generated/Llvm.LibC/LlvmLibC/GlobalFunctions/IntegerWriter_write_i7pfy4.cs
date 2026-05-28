using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_write_i7pfy4
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter5writeElRNS1_22StringBufferWriterImplILb0EEE")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write(long, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
	[CleanName("IntegerWriter_write")]
	public unsafe static void Invoke([MangledName("value")][NativeType("long")] long Value, [MangledName("sink")][NativeType("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&")] Details_StringBufferWriterImpl* Sink)
	{
		IntegerWriter_write_unsigned_number_gjvwqf.Invoke(IntegerWriter_abs_jus6fi.Invoke(Value), Sink);
		while (StringBufferWriterImpl_false_ok.Invoke(Sink) && unchecked((ulong)StringBufferWriterImpl_false_size.Invoke(Sink)) < 1uL)
		{
			StringBufferWriterImpl_false_push.Invoke(Sink, 48);
		}
		if (Value < 0L)
		{
			StringBufferWriterImpl_false_push.Invoke(Sink, 45);
		}
	}
}
