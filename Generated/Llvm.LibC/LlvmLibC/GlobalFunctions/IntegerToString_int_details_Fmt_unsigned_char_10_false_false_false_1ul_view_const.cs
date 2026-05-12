using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNKR19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE4viewEv")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::view() const &")]
internal static partial class IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const
{
	public unsafe static Struct_kqhe8i Invoke(IntegerToString_exzmu4* @this)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, (byte*)cpp_array_char_11ul_data_const.Invoke(&@this->array) + cpp_array_char_11ul_size_const.Invoke(&@this->array) + -IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(@this), IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(@this));
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
