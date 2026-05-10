using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_neERKNS_6BigIntILm64ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator!=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_sx97vk
{
	public unsafe static bool Invoke(void* lhs, void* rhs)
	{
		return unchecked((byte)((operator_BigInt_64ul_false_unsigned_long_const_BigInt_64ul_false_unsigned_long_const_sbn2kk.Invoke(lhs, rhs) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
