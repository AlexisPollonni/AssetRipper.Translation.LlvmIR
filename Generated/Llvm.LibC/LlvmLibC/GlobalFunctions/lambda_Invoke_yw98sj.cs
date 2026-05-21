using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_yw98sj
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EjLm1EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned int, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>, unsigned long)::'lambda'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("lambda_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned long")] long index)
	{
		return unchecked((int)index);
	}
}
