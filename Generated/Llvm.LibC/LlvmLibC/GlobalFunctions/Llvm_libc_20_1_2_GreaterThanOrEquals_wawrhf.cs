using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_GreaterThanOrEquals_wawrhf
{
	[MangledName("_ZN19__llvm_libc_20_1_2_geERKNS_6BigIntILm256ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator>=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	[CleanName("Llvm_libc_20_1_2_GreaterThanOrEquals")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_x9dsed* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_x9dsed* Rhs)
	{
		return Llvm_libc_20_1_2_cmp_m6db9g.Invoke(Lhs, Rhs) >= 0;
	}
}
