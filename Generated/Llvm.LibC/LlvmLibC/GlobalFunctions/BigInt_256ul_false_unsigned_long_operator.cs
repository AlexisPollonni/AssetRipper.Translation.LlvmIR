using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEppEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator++()")]
internal static partial class BigInt_256ul_false_unsigned_long_operator
{
	public unsafe static BigInt_x9dsed* Invoke(BigInt_x9dsed* @this)
	{
		BigInt_256ul_false_unsigned_long_increment.Invoke(@this);
		return @this;
	}
}
