using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda_Invoke_xph9by
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EmLm5EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned long, 5ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>, unsigned long)::'lambda'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("Lambda_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		return 5 - unchecked((int)Index) - 1;
	}
}
