using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_neERKNS_6BigIntILm256ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_627jbj
{
	public unsafe static bool Invoke(BigInt_x9dsed* lhs, BigInt_x9dsed* rhs)
	{
		return unchecked((byte)((operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_nxrzhc.Invoke(lhs, rhs) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
