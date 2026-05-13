using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE9incrementEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::increment()")]
internal static partial class BigInt_256ul_false_unsigned_long_increment
{
	public unsafe static void Invoke(BigInt_x9dsed* @this)
	{
		cpp_array_rpgxvv cpp_array_rpgxvv2 = default(cpp_array_rpgxvv);
		cpp_array_jgy3xh* val = &@this->val;
		llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv2);
		*unchecked((long*)(&cpp_array_rpgxvv2.Data)) = 1L;
		unsigned_long_multiword_add_with_carry_unsigned_long_4ul_1ul_cpp_array_unsigned_long_4ul_cpp_array_unsigned_long_1ul_const.Invoke(val, &cpp_array_rpgxvv2);
		llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv2);
	}
}
