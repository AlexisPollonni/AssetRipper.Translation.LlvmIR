using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NotEquals_j3a3qv
{
	[MangledName("_ZN19__llvm_libc_20_1_2_neERKNS_6BigIntILm256ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	[CleanName("NotEquals")]
	public unsafe static bool Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] BigInt_x9dsed* rhs)
	{
		return unchecked((byte)((Equals_k3cteu.Invoke(lhs, rhs) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
