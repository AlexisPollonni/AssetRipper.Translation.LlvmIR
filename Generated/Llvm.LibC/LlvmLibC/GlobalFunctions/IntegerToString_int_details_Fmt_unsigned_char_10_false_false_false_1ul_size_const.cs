using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_15IntegerToStringIiNS_7details3FmtILh10ELb0ELb0ELb0ELm1EEEE4sizeEv")]
[DemangledName("__llvm_libc_20_1_2_::IntegerToString<int, __llvm_libc_20_1_2_::details::Fmt<(unsigned char)10, false, false, false, 1ul>>::size() const")]
internal static partial class IntegerToString_int_details_Fmt_unsigned_char_10_false_false_false_1ul_size_const
{
	public unsafe static long Invoke(IntegerToString_bz5c8a* @this)
	{
		return @this->written;
	}
}
