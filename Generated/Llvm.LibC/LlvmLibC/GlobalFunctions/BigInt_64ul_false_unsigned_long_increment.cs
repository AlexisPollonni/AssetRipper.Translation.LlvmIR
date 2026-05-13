using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm64ELb0EmE9incrementEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::increment()")]
internal static partial class BigInt_64ul_false_unsigned_long_increment
{
	public unsafe static void Invoke(BigInt_nx6qdt* @this)
	{
		cpp_array_rpgxvv cpp_array_rpgxvv2 = default(cpp_array_rpgxvv);
		cpp_array_rpgxvv* val = &@this->val;
		llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv2);
		*unchecked((long*)(&cpp_array_rpgxvv2.Data)) = 1L;
		unsigned_long_multiword_add_with_carry_unsigned_long_1ul_1ul_cpp_array_unsigned_long_1ul_cpp_array_unsigned_long_1ul_const.Invoke(val, &cpp_array_rpgxvv2);
		llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv2);
	}
}
