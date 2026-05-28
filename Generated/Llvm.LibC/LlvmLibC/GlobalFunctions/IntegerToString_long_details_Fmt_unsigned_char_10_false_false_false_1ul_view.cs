using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_view
{
	[MangledName("_ZNKR19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE4viewEv")]
	[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::view() const &")]
	public unsafe static Struct_kqhe8i Invoke([MangledName("this")] IntegerToString_uuwdyc* This)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		unchecked
		{
			String_view_Constructor.Invoke(&cpp_string_view, (byte*)Array_char_21ul_data_wkczjf.Invoke(&This->Array) + Array_char_21ul_size.Invoke(&This->Array) + -IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(This), IntegerToString_long_details_Fmt_unsigned_char_10_false_false_false_1ul_size.Invoke(This));
			return *(Struct_kqhe8i*)(&cpp_string_view);
		}
	}
}
