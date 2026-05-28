using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class GreaterThanOrEquals_r32pss
{
	[MangledName("_ZN19__llvm_libc_20_1_2_geERKNS_6BigIntILm64ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator>=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	[CleanName("GreaterThanOrEquals")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Rhs)
	{
		return Cmp_6gxys8.Invoke(Lhs, Rhs) >= 0;
	}
}
