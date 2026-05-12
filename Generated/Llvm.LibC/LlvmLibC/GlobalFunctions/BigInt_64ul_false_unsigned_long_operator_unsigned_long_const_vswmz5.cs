using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm64ELb0EmElsEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long>::operator<<(unsigned long) const")]
[CleanName("BigInt_64ul_false_unsigned_long_operator_unsigned_long_const")]
internal static partial class BigInt_64ul_false_unsigned_long_operator_unsigned_long_const_vswmz5
{
	public unsafe static long Invoke(BigInt_nx6qdt* @this, long s)
	{
		BigInt_nx6qdt bigInt_nx6qdt = default(BigInt_nx6qdt);
		cpp_array_rpgxvv cpp_array_rpgxvv2 = default(cpp_array_rpgxvv);
		cpp_array_rpgxvv cpp_array_rpgxvv3 = default(cpp_array_rpgxvv);
		llvm_lifetime_start_p0.Invoke(8L, &cpp_array_rpgxvv2);
		llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_rpgxvv3, &@this->val, 8L, isVolatile: false);
		unchecked
		{
			long data = cpp_array_unsigned_long_1ul_multiword_shift_multiword_Direction_0_false_unsigned_long_1ul_cpp_array_unsigned_long_1ul_unsigned_long.Invoke(*(long*)(&cpp_array_rpgxvv3.Data), s);
			*(long*)(&cpp_array_rpgxvv2.Data) = data;
			BigInt_64ul_false_unsigned_long_BigInt_cpp_array_unsigned_long_1ul_const.Invoke(&bigInt_nx6qdt, &cpp_array_rpgxvv2);
			llvm_lifetime_end_p0.Invoke(8L, &cpp_array_rpgxvv2);
			return *(long*)(&bigInt_nx6qdt.val.Data);
		}
	}
}
