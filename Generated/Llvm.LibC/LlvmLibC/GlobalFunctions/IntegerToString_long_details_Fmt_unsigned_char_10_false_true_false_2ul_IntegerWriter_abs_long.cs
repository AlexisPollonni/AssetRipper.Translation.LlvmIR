using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEE13IntegerWriter3absEl")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::IntegerWriter::abs(long)")]
internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_IntegerWriter_abs_long
{
	public unsafe static long Invoke(long value)
	{
		long num = 0L;
		num = value;
		if (num >= 0L)
		{
			return num;
		}
		if (num == cpp_internal_integer_impl_long_9223372036854775808l_9223372036854775807l_min.Invoke())
		{
			return cpp_enable_if_sizeof_unsigned_long_sizeof_long_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_long_value_unsigned_long_type_cpp_bit_cast_unsigned_long_long_long_const.Invoke(&num);
		}
		return -num;
	}
}
