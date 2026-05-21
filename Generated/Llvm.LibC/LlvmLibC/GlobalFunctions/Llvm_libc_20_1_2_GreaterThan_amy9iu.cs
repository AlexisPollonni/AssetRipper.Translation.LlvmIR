using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_GreaterThan_amy9iu
{
	[MangledName("_ZN19__llvm_libc_20_1_2_gtERKNS_6BigIntILm16512ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator>(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&)")]
	[CleanName("Llvm_libc_20_1_2_GreaterThan")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_q8g275* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_q8g275* Rhs)
	{
		return Llvm_libc_20_1_2_cmp_p72kgk.Invoke(Lhs, Rhs) > 0;
	}
}
