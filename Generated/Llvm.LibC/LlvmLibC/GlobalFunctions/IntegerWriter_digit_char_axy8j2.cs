using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerWriter_digit_char_axy8j2
{
	[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEE13IntegerWriter10digit_charEh")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::IntegerWriter::digit_char(unsigned char)")]
	[CleanName("IntegerWriter_digit_char")]
	public unsafe static sbyte Invoke([MangledName("digit")][NativeType("unsigned char")] sbyte Digit)
	{
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = Internal_int_to_b36_char_zr4v3p.Invoke((byte)Digit);
			sbyte result = (sbyte)num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
