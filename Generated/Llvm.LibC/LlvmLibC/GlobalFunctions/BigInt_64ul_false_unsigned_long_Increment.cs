using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class BigInt_64ul_false_unsigned_long_Increment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEppEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator++()")]
	public unsafe static BigInt_555ggs* Invoke(BigInt_555ggs* @this)
	{
		BigInt_64ul_false_unsigned_long_increment.Invoke(@this);
		return @this;
	}
}
internal static partial class BigInt_64ul_false_unsigned_long_increment
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE9incrementEv")]
	[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::increment()")]
	public unsafe static void Invoke(BigInt_555ggs* @this)
	{
		cpp_array_rpgxvv cpp_array_rpgxvv2 = default(cpp_array_rpgxvv);
		cpp_array_rpgxvv* val = &@this->val;
		llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv2);
		*unchecked((long*)(&cpp_array_rpgxvv2.Data)) = 1L;
		multiword_add_with_carry_unsigned_long_1ul_1ul.Invoke(val, &cpp_array_rpgxvv2);
		llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv2);
	}
}
