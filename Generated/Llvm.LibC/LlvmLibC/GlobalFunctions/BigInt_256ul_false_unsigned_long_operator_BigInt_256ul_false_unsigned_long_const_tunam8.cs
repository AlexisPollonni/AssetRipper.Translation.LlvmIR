using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEpLERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator+=(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
[CleanName("BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const")]
internal static partial class BigInt_256ul_false_unsigned_long_operator_BigInt_256ul_false_unsigned_long_const_tunam8
{
	public unsafe static BigInt_x9dsed* Invoke(BigInt_x9dsed* @this, BigInt_x9dsed* other)
	{
		BigInt_256ul_false_unsigned_long_add_overflow_BigInt_256ul_false_unsigned_long_const.Invoke(@this, other);
		return @this;
	}
}
