using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtE12sub_overflowERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::sub_overflow(__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short> const&)")]
internal static partial class BigInt_16ul_false_unsigned_short_sub_overflow_BigInt_16ul_false_unsigned_short_const
{
	public unsafe static short Invoke(BigInt_ys7s55* @this, BigInt_ys7s55* rhs)
	{
		return unsigned_short_multiword_sub_with_borrow_unsigned_short_1ul_1ul_cpp_array_unsigned_short_1ul_cpp_array_unsigned_short_1ul_const.Invoke(&@this->val, &rhs->val);
	}
}
