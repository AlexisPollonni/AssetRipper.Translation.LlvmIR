using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroINS_6BigIntILm32ELb0EjEEEENS0_9enable_ifIX12is_big_int_vIT_EEiE4typeERKS5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<is_big_int_v<__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>>(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&)")]
internal static partial class cpp_enable_if_is_big_int_v_BigInt_32ul_false_unsigned_int_int_type_cpp_countl_zero_BigInt_32ul_false_unsigned_int_BigInt_32ul_false_unsigned_int_const
{
	public unsafe static int Invoke(void* value)
	{
		return int_multiword_countl_zero_unsigned_int_1ul_cpp_array_unsigned_int_1ul_const.Invoke(&unchecked((BigInt_fzjdu3*)value)->val);
	}
}
