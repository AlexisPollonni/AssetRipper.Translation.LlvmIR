using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class LessThan
{
	[MangledName("_ZN19__llvm_libc_20_1_2_ltERKNS_6BigIntILm128ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator<(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	public unsafe static bool Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* rhs)
	{
		return cmp_dc3878.Invoke(lhs, rhs) < 0;
	}
}
