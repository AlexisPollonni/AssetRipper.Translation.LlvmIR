using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm4EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 4ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
internal static partial class cpp_array_unsigned_long_4ul_multiword_shift_multiword_Direction_1_false_unsigned_long_4ul_cpp_array_unsigned_long_4ul_unsigned_long_lambda0_unsigned_long_operator_unsigned_long_const
{
	public unsafe static long Invoke(void* @this, long index)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = cpp_array_unsigned_long_4ul_multiword_shift_multiword_Direction_1_false_unsigned_long_4ul_cpp_array_unsigned_long_4ul_unsigned_long_lambda_unsigned_long_operator_unsigned_long_const.Invoke(((anon_6je4un*)@this)->field_0, index);
			long result = ((num >= 0) ? ((num < 4) ? (*(long*)cpp_array_unsigned_long_4ul_operator_unsigned_long.Invoke((cpp_array_jgy3xh*)((anon_6je4un*)@this)->field_1, num)) : 0) : 0);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
