using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EjLm1EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE0_clEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned int, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>, unsigned long)::'lambda0'(unsigned long)::operator()(unsigned long) const")]
internal static partial class cpp_array_unsigned_int_1ul_multiword_shift_multiword_Direction_0_false_unsigned_int_1ul_cpp_array_unsigned_int_1ul_unsigned_long_lambda0_unsigned_long_operator_unsigned_long_const
{
	public unsafe static int Invoke(void* @this, long index)
	{
		int num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = cpp_array_unsigned_int_1ul_multiword_shift_multiword_Direction_0_false_unsigned_int_1ul_cpp_array_unsigned_int_1ul_unsigned_long_lambda_unsigned_long_operator_unsigned_long_const.Invoke(((anon_6je4un*)@this)->field_0, index);
			int result = ((num >= 0) ? ((num < 1) ? (*(int*)cpp_array_unsigned_int_1ul_operator_unsigned_long.Invoke((cpp_array_2v7m9i*)((anon_6je4un*)@this)->field_1, num)) : 0) : 0);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
