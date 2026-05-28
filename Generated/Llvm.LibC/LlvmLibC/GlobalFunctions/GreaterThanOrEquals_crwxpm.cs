using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class GreaterThanOrEquals_crwxpm
{
	[MangledName("_ZN19__llvm_libc_20_1_2_geERKNS_6BigIntILm128ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator>=(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	[CleanName("GreaterThanOrEquals")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] Anon_izyfb7* Rhs)
	{
		return Cmp_dc3878.Invoke(Lhs, Rhs) >= 0;
	}
}
