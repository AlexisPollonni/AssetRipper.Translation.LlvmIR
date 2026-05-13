using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEppEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator++()")]
internal static partial class BigInt_128ul_false_unsigned_long_operator
{
	public unsafe static anon_izyfb7* Invoke(anon_izyfb7* @this)
	{
		BigInt_128ul_false_unsigned_long_increment.Invoke(@this);
		return @this;
	}
}
