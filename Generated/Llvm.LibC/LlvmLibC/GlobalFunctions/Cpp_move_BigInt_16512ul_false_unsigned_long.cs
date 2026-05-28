using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_BigInt_16512ul_false_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRNS_6BigIntILm16512ELb0EmEEEEONS0_16remove_referenceIT_E4typeEOS6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&>::type&& __llvm_libc_20_1_2_::cpp::move<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&>(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&>::type&&")]
	public unsafe static BigInt_q8g275* Invoke([MangledName("t")][NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>&")] BigInt_q8g275* T)
	{
		return T;
	}
}
