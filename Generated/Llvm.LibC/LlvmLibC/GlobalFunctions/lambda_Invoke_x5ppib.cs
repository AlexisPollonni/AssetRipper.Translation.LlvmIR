using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_x5ppib
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EtLm1EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned short, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>, unsigned long)::'lambda'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("lambda_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>")]
	public unsafe static int Invoke(void* @this, [NativeType("unsigned long")] long index)
	{
		return 1 - unchecked((int)index) - 1;
	}
}
