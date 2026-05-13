using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEcvT_ItEEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator unsigned short<unsigned short>() const")]
internal static partial class BigInt_16ul_false_unsigned_short_operator_unsigned_short_unsigned_short_const
{
	public unsafe static short Invoke(BigInt_ys7s55* @this)
	{
		return cpp_enable_if_cpp_is_integral_v_unsigned_short_cpp_is_same_v_unsigned_short_bool_unsigned_short_type_BigInt_16ul_false_unsigned_short_to_unsigned_short_const.Invoke(@this);
	}
}
