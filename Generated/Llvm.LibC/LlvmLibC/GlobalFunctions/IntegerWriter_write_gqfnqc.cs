using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_write_gqfnqc
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter5writeEiRNS1_22StringBufferWriterImplILb0EEE")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write(int, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
	[CleanName("IntegerWriter_write")]
	public unsafe static void Invoke([NativeType("int")] int value, [NativeType("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&")] details_StringBufferWriterImpl* sink)
	{
		IntegerWriter_write_unsigned_number_cxrqng.Invoke(IntegerWriter_abs_hawne3.Invoke(value), sink);
		while (StringBufferWriterImpl_false_ok.Invoke(sink) && unchecked((ulong)StringBufferWriterImpl_false_size.Invoke(sink)) < 1uL)
		{
			StringBufferWriterImpl_false_push.Invoke(sink, 48);
		}
		if (value < 0)
		{
			StringBufferWriterImpl_false_push.Invoke(sink, 45);
		}
	}
}
