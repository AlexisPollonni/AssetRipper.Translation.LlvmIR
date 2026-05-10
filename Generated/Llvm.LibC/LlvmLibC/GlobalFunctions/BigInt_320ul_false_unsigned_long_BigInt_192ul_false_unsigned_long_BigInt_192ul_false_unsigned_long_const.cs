using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm320ELb0EmEC2ILm192ELb0EmEERKNS0_IXT_EXT0_ET1_EE")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<320ul, false, unsigned long>::BigInt<192ul, false, unsigned long>(__llvm_libc_20_1_2_::BigInt<192ul, false, unsigned long> const&)")]
internal static partial class BigInt_320ul_false_unsigned_long_BigInt_192ul_false_unsigned_long_BigInt_192ul_false_unsigned_long_const
{
	public unsafe static void Invoke(void* @this, void* other)
	{
		sbyte b = 0;
		long num = 0L;
		unchecked
		{
			llvm_memset_p0_i64.Invoke(&((BigInt_76gxx6*)@this)->val.Data, 0, 40L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				long num2 = *(long*)BigInt_192ul_false_unsigned_long_operator_unsigned_long_const.Invoke(other, num);
				*(long*)cpp_array_unsigned_long_5ul_operator_unsigned_long.Invoke(&((BigInt_76gxx6*)@this)->val, num) = num2;
			}
			BigInt_320ul_false_unsigned_long_extend_unsigned_long_bool.Invoke(@this, num, is_neg: false);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(1L, &b);
		}
	}
}
