using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm16ELb0EtEixEm")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::operator[](unsigned long) const")]
[CleanName("BigInt_16ul_false_unsigned_short_operator_unsigned_long_const")]
internal static partial class BigInt_16ul_false_unsigned_short_operator_unsigned_long_const_z52e5b
{
	public unsafe static void* Invoke(BigInt_ys7s55* @this, long i)
	{
		return cpp_array_unsigned_short_1ul_operator_unsigned_long_const.Invoke(&@this->val, i);
	}
}
