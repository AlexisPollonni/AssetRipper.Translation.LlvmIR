using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEcvT_ItEEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator unsigned short<unsigned short>() const")]
internal static partial class BigInt_32ul_false_unsigned_int_operator_unsigned_short_unsigned_short_const
{
	public unsafe static short Invoke(BigInt_vtm4cw* @this)
	{
		return cpp_enable_if_cpp_is_integral_v_unsigned_short_cpp_is_same_v_unsigned_short_bool_unsigned_short_type_BigInt_32ul_false_unsigned_int_to_unsigned_short_const.Invoke(@this);
	}
}
