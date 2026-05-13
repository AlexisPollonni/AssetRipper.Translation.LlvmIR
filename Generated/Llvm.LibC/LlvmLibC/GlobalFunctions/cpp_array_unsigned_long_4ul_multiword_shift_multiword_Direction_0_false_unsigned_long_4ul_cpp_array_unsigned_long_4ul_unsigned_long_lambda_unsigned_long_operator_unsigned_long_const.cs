using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EmLm4EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE_clEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned long, 4ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>, unsigned long)::'lambda'(unsigned long)::operator()(unsigned long) const")]
internal static partial class cpp_array_unsigned_long_4ul_multiword_shift_multiword_Direction_0_false_unsigned_long_4ul_cpp_array_unsigned_long_4ul_unsigned_long_lambda_unsigned_long_operator_unsigned_long_const
{
	public unsafe static int Invoke(void* @this, long index)
	{
		return 4 - unchecked((int)index) - 1;
	}
}
