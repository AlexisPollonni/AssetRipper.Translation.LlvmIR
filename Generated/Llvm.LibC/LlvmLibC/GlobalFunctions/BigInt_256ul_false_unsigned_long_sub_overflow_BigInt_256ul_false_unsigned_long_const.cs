using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmE12sub_overflowERKS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::sub_overflow(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
internal static partial class BigInt_256ul_false_unsigned_long_sub_overflow_BigInt_256ul_false_unsigned_long_const
{
	public unsafe static long Invoke(BigInt_x9dsed* @this, BigInt_x9dsed* rhs)
	{
		return unsigned_long_multiword_sub_with_borrow_unsigned_long_4ul_4ul_cpp_array_unsigned_long_4ul_cpp_array_unsigned_long_4ul_const.Invoke(&@this->val, &rhs->val);
	}
}
