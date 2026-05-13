using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmEcvT_IjEEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator unsigned int<unsigned int>() const")]
internal static partial class BigInt_64ul_false_unsigned_long_operator_unsigned_int_unsigned_int_const
{
	public unsafe static int Invoke(BigInt_nx6qdt* @this)
	{
		return cpp_enable_if_cpp_is_integral_v_unsigned_int_cpp_is_same_v_unsigned_int_bool_unsigned_int_type_BigInt_64ul_false_unsigned_long_to_unsigned_int_const.Invoke(@this);
	}
}
