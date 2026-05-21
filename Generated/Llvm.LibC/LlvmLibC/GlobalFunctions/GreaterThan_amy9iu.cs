using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class GreaterThan_amy9iu
{
	[MangledName("_ZN19__llvm_libc_20_1_2_gtERKNS_6BigIntILm16512ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator>(__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&)")]
	[CleanName("GreaterThan")]
	public unsafe static bool Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&")] BigInt_q8g275* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long> const&")] BigInt_q8g275* rhs)
	{
		return cmp_p72kgk.Invoke(lhs, rhs) > 0;
	}
}
