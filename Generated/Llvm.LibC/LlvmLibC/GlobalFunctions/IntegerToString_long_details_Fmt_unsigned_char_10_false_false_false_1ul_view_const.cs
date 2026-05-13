using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNKR19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE4viewEv")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::view() const &")]
internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view_const
{
	public unsafe static Struct_kqhe8i Invoke(IntegerToString_uuwdyc* @this)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		unchecked
		{
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, (byte*)cpp_array_char_21ul_data_const.Invoke(&@this->array) + cpp_array_char_21ul_size_const.Invoke(&@this->array) + -IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(@this), IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const.Invoke(@this));
			return *(Struct_kqhe8i*)(&cpp_string_view2);
		}
	}
}
