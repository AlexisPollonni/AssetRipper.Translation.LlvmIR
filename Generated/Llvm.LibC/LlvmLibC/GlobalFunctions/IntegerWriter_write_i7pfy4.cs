using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_write_i7pfy4
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter5writeElRNS1_22StringBufferWriterImplILb0EEE")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write(long, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
	[CleanName("IntegerWriter_write")]
	public unsafe static void Invoke([NativeType("long")] long value, [NativeType("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&")] details_StringBufferWriterImpl* sink)
	{
		IntegerWriter_write_unsigned_number_gjvwqf.Invoke(IntegerWriter_abs_jus6fi.Invoke(value), sink);
		while (StringBufferWriterImpl_false_ok.Invoke(sink) && unchecked((ulong)StringBufferWriterImpl_false_size.Invoke(sink)) < 1uL)
		{
			StringBufferWriterImpl_false_push.Invoke(sink, 48);
		}
		if (value < 0L)
		{
			StringBufferWriterImpl_false_push.Invoke(sink, 45);
		}
	}
}
