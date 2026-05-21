using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_view
{
	[MangledName("_ZNKR19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEE4viewEv")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::view() const &")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("this")] void* This)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		unchecked
		{
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (byte*)Array_char_21ul_data_wkczjf.Invoke(&((Llvm_libc_20_1_2_IntegerToString_uuwdyc*)This)->Array) + Array_char_21ul_size.Invoke(&((Llvm_libc_20_1_2_IntegerToString_uuwdyc*)This)->Array) + -IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_size.Invoke(This), IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_size.Invoke(This));
			return *(Struct_kqhe8i*)(&llvm_libc_20_1_2_cpp_string_view);
		}
	}
}
