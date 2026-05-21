using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_write_unsigned_number_m63729
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEE13IntegerWriter21write_unsigned_numberEmRNS1_22StringBufferWriterImplILb0EEE")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::IntegerWriter::write_unsigned_number(unsigned long, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
	[CleanName("IntegerWriter_write_unsigned_number")]
	public unsafe static void Invoke([NativeType("unsigned long")] long value, [NativeType("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&")] details_StringBufferWriterImpl* sink)
	{
		sbyte digit = 0;
		long num = value;
		unchecked
		{
			while (StringBufferWriterImpl_false_ok.Invoke(sink) && num != 0L)
			{
				llvm_lifetime_start_p0.Invoke(1L, &digit);
				digit = (sbyte)((ulong)num % 10uL);
				StringBufferWriterImpl_false_push.Invoke(sink, IntegerWriter_digit_char_axy8j2.Invoke(digit));
				llvm_lifetime_end_p0.Invoke(1L, &digit);
				num = (long)((ulong)num / 10uL);
			}
		}
	}
}
