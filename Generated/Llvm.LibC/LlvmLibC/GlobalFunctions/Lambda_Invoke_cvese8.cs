using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda_Invoke_cvese8
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm258EEENS_3cpp5arrayIT1_XT2_EEES6_mENKUlmE_clEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 258ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>, unsigned long)::'lambda'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("Lambda_Invoke")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>")]
	public unsafe static int Invoke([MangledName("this")] void* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		return unchecked((int)Index);
	}
}
