using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE13IntegerWriter3absEi")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::IntegerWriter::abs(int)")]
internal static partial class IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_IntegerWriter_abs_int
{
	public unsafe static int Invoke(int value)
	{
		int num = 0;
		num = value;
		if (num >= 0)
		{
			return num;
		}
		if (num == cpp_internal_integer_impl_int_2147483648_2147483647_min.Invoke())
		{
			return cpp_enable_if_sizeof_unsigned_int_sizeof_int_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_int_value_unsigned_int_type_cpp_bit_cast_unsigned_int_int_int_const.Invoke(&num);
		}
		return -num;
	}
}
