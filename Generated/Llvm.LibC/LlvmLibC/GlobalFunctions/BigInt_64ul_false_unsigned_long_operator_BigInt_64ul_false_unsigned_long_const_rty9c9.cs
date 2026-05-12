using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEpLERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator+=(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
[CleanName("BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const")]
internal static partial class BigInt_64ul_false_unsigned_long_operator_BigInt_64ul_false_unsigned_long_const_rty9c9
{
	public unsafe static BigInt_nx6qdt* Invoke(BigInt_nx6qdt* @this, BigInt_nx6qdt* other)
	{
		BigInt_64ul_false_unsigned_long_add_overflow_BigInt_64ul_false_unsigned_long_const.Invoke(@this, other);
		return @this;
	}
}
