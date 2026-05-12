using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroINS_6BigIntILm256ELb0EmEEEENS0_9enable_ifIX12is_big_int_vIT_EEiE4typeERKS5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_big_int_v<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>>(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
internal static partial class cpp_enable_if_is_big_int_v_BigInt_256ul_false_unsigned_long_int_type_cpp_countl_zero_BigInt_256ul_false_unsigned_long_BigInt_256ul_false_unsigned_long_const
{
	public unsafe static int Invoke(BigInt_x9dsed* value)
	{
		return int_multiword_countl_zero_unsigned_long_4ul_cpp_array_unsigned_long_4ul_const.Invoke(&value->val);
	}
}
