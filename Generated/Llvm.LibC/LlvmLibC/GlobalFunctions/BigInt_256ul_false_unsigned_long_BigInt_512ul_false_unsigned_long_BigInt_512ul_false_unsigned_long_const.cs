using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm256ELb0EmEC2ILm512ELb0EmEERKNS0_IXT_EXT0_ET1_EE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long>::BigInt<512ul, false, unsigned long>(__llvm_libc_20_1_2_::BigInt<512ul, false, unsigned long> const&)")]
internal static partial class BigInt_256ul_false_unsigned_long_BigInt_512ul_false_unsigned_long_BigInt_512ul_false_unsigned_long_const
{
	public unsafe static void Invoke(BigInt_x9dsed* @this, BigInt_fjg8pd* other)
	{
		sbyte b = 0;
		long num = 0L;
		llvm_memset_p0_i64.Invoke(&@this->val.Data, 0, 32L, isVolatile: false);
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		unchecked
		{
			for (num = 0L; (ulong)num < 4uL; num++)
			{
				long num2 = *(long*)BigInt_512ul_false_unsigned_long_operator_unsigned_long_const.Invoke(other, num);
				*(long*)cpp_array_unsigned_long_4ul_operator_unsigned_long.Invoke(&@this->val, num) = num2;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
