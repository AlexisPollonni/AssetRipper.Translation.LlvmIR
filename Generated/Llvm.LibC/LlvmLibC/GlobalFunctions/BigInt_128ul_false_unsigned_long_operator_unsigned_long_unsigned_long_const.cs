using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEcvT_ImEEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator unsigned long<unsigned long>() const")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_unsigned_long_unsigned_long_const
{
	public unsafe static long Invoke(void* @this)
	{
		return cpp_enable_if_cpp_is_integral_v_unsigned_long_cpp_is_same_v_unsigned_long_bool_unsigned_long_type_BigInt_128ul_false_unsigned_long_to_unsigned_long_const.Invoke(@this);
	}
}
