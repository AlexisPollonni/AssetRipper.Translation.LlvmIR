using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_write_unsigned_number_cxrqng
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter21write_unsigned_numberEjRNS1_22StringBufferWriterImplILb0EEE")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::write_unsigned_number(unsigned int, __llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&)")]
	[CleanName("IntegerWriter_write_unsigned_number")]
	public unsafe static void Invoke([NativeType("unsigned int")] int value, [NativeType("__llvm_libc_20_1_2_::details::StringBufferWriterImpl<false>&")] details_StringBufferWriterImpl* sink)
	{
		sbyte digit = 0;
		int num = value;
		unchecked
		{
			while (StringBufferWriterImpl_false_ok.Invoke(sink) && num != 0)
			{
				llvm_lifetime_start_p0.Invoke(1L, &digit);
				digit = (sbyte)((uint)num % 10u);
				StringBufferWriterImpl_false_push.Invoke(sink, IntegerWriter_digit_char_6prhss.Invoke(digit));
				llvm_lifetime_end_p0.Invoke(1L, &digit);
				num = (int)((uint)num / 10u);
			}
		}
	}
}
