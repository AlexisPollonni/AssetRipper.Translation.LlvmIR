using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_15IntegerToStringIlNS_7details3FmtILh10ELb0ELb1ELb0ELm2EEEE4sizeEv")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<long, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, true, false, 2ul>>::size() const")]
internal static partial class IntegerToString_long_details_Fmt_unsigned_char_10_false_true_false_2ul_size_const
{
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((IntegerToString_uuwdyc*)@this)->written;
	}
}
