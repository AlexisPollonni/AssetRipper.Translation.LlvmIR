using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EmLm5EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE_clEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned long, 5ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>, unsigned long)::'lambda'(unsigned long)::operator()(unsigned long) const")]
internal static partial class cpp_array_unsigned_long_5ul_multiword_shift_multiword_Direction_0_false_unsigned_long_5ul_cpp_array_unsigned_long_5ul_unsigned_long_lambda_unsigned_long_operator_unsigned_long_const
{
	public unsafe static int Invoke(void* @this, long index)
	{
		return 5 - unchecked((int)index) - 1;
	}
}
