using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class GreaterThanOrEquals_wawrhf
{
	[MangledName("_ZN19__llvm_libc_20_1_2_geERKNS_6BigIntILm256ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator>=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	[CleanName("GreaterThanOrEquals")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* Rhs)
	{
		return Cmp_m6db9g.Invoke(Lhs, Rhs) >= 0;
	}
}
