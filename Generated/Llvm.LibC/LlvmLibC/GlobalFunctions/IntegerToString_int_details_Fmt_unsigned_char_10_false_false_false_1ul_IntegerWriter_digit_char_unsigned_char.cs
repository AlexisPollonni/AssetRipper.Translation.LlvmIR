using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter10digit_charEh")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::digit_char(unsigned char)")]
internal static partial class IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_digit_char_unsigned_char
{
	public unsafe static sbyte Invoke(sbyte digit)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = internal_int_to_b36_char_int_187.Invoke((byte)digit);
			sbyte result = (sbyte)num;
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
