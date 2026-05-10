using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16512ELb0EmE6extendEmb")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16512ul, false, unsigned long>::extend(unsigned long, bool)")]
internal static partial class BigInt_16512ul_false_unsigned_long_extend_unsigned_long_bool
{
	public unsafe static void Invoke(void* @this, long index, bool is_neg)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = (is_neg ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = InstructionHelper.Select((b & 1) == 1, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke(), cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_min.Invoke());
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = index; (ulong)num2 < 258uL; num2++)
			{
				long num3 = num;
				*(long*)cpp_array_unsigned_long_258ul_operator_unsigned_long.Invoke(&((BigInt_k36xhe*)@this)->val, num2) = num3;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
