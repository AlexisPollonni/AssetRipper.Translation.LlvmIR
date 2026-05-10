using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6BigIntILm32ELb0EjEmiEOS1_")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>::operator-(__llvm_libc_20_1_2_::BigInt<32ul, false, unsigned int>&&) const")]
internal static partial class BigInt_32ul_false_unsigned_int_operator_BigInt_32ul_false_unsigned_int_const
{
	public unsafe static int Invoke(void* @this, void* other)
	{
		BigInt_fzjdu3 bigInt_fzjdu = default(BigInt_fzjdu3);
		unchecked
		{
			*(int*)(&bigInt_fzjdu) = -1431655766;
			llvm_memcpy_p0_p0_i64.Invoke(&bigInt_fzjdu, @this, 4L, isVolatile: false);
			BigInt_32ul_false_unsigned_int_sub_overflow_BigInt_32ul_false_unsigned_int_const.Invoke(&bigInt_fzjdu, other);
			return *(int*)(&bigInt_fzjdu.val.Data);
		}
	}
}
