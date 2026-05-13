using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EtLm1EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned short, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
internal static partial class cpp_array_unsigned_short_1ul_multiword_shift_multiword_Direction_1_false_unsigned_short_1ul_cpp_array_unsigned_short_1ul_unsigned_long_lambda0_unsigned_long_operator_unsigned_long_const
{
	public unsafe static short Invoke(void* @this, long index)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = cpp_array_unsigned_short_1ul_multiword_shift_multiword_Direction_1_false_unsigned_short_1ul_cpp_array_unsigned_short_1ul_unsigned_long_lambda_unsigned_long_operator_unsigned_long_const.Invoke(((anon_6je4un*)@this)->field_0, index);
			short result = (short)((num >= 0) ? ((num < 1) ? (*(short*)cpp_array_unsigned_short_1ul_operator_unsigned_long.Invoke((cpp_array_knh6hw*)((anon_6je4un*)@this)->field_1, num)) : 0) : 0);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
