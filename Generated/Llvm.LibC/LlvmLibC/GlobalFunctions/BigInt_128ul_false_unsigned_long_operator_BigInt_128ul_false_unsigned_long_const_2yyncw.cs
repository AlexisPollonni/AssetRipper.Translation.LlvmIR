using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEpLERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator+=(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
[CleanName("BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_BigInt_128ul_false_unsigned_long_const_2yyncw
{
	public unsafe static anon_izyfb7* Invoke(anon_izyfb7* @this, anon_izyfb7* other)
	{
		BigInt_128ul_false_unsigned_long_add_overflow_BigInt_128ul_false_unsigned_long_const.Invoke(@this, other);
		return @this;
	}
}
