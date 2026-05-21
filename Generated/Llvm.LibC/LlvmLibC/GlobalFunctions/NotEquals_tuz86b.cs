using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NotEquals_tuz86b
{
	[MangledName("_ZN19__llvm_libc_20_1_2_neERKNS_6BigIntILm128ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	[CleanName("NotEquals")]
	public unsafe static bool Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* rhs)
	{
		return unchecked((byte)((Equals_s36iku.Invoke(lhs, rhs) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
