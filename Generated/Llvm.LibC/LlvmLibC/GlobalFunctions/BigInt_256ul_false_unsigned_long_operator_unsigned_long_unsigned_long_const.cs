using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEcvT_ImEEv")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::operator unsigned long<unsigned long>() const")]
internal static partial class BigInt_256ul_false_unsigned_long_operator_unsigned_long_unsigned_long_const
{
	public unsafe static long Invoke(BigInt_x9dsed* @this)
	{
		return cpp_enable_if_cpp_is_integral_v_unsigned_long_cpp_is_same_v_unsigned_long_bool_unsigned_long_type_BigInt_256ul_false_unsigned_long_to_unsigned_long_const.Invoke(@this);
	}
}
