using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEppEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator++()")]
internal static partial class BigInt_64ul_false_unsigned_long_operator
{
	public unsafe static void* Invoke(void* @this)
	{
		BigInt_64ul_false_unsigned_long_increment.Invoke(@this);
		return @this;
	}
}
