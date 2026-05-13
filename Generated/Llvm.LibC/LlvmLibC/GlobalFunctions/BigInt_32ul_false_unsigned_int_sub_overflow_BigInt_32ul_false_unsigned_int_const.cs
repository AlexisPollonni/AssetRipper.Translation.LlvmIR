using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm32ELb0EjE12sub_overflowERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::sub_overflow(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int> const&)")]
internal static partial class BigInt_32ul_false_unsigned_int_sub_overflow_BigInt_32ul_false_unsigned_int_const
{
	public unsafe static int Invoke(BigInt_fzjdu3* @this, BigInt_fzjdu3* rhs)
	{
		return unsigned_int_multiword_sub_with_borrow_unsigned_int_1ul_1ul_cpp_array_unsigned_int_1ul_cpp_array_unsigned_int_1ul_const.Invoke(&@this->val, &rhs->val);
	}
}
