using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm128ELb0EmEcvT_ItEEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long>::operator unsigned short<unsigned short>() const")]
internal static partial class BigInt_128ul_false_unsigned_long_operator_unsigned_short_unsigned_short_const
{
	public unsafe static short Invoke(anon_izyfb7* @this)
	{
		return cpp_enable_if_cpp_is_integral_v_unsigned_short_cpp_is_same_v_unsigned_short_bool_unsigned_short_type_BigInt_128ul_false_unsigned_long_to_unsigned_short_const.Invoke(@this);
	}
}
