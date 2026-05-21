using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_digit_char_6prhss
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter10digit_charEh")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::digit_char(unsigned char)")]
	[CleanName("IntegerWriter_digit_char")]
	public unsafe static sbyte Invoke([MangledName("digit")][NativeType("unsigned char")] sbyte Digit)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = Internal_int_to_b36_char_eyr9tw.Invoke((byte)Digit);
			sbyte result = (sbyte)num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
