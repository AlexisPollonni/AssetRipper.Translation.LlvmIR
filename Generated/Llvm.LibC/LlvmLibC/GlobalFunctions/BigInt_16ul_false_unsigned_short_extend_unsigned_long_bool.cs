using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6BigIntILm16ELb0EtE6extendEmb")]
[DemangledName("__llvm_libc_20_1_2_::BigInt<16ul, false, unsigned short>::extend(unsigned long, bool)")]
internal static partial class BigInt_16ul_false_unsigned_short_extend_unsigned_long_bool
{
	public unsafe static void Invoke(BigInt_ys7s55* @this, long index, bool is_neg)
	{
		short num = 0;
		long num2 = 0L;
		sbyte b = (is_neg ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(2L, &num);
		num = InstructionHelper.Select((b & 1) == 1, cpp_internal_integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_max.Invoke(), cpp_internal_integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_min.Invoke());
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			for (num2 = index; (ulong)num2 < 1uL; num2++)
			{
				short num3 = num;
				*(short*)cpp_array_unsigned_short_1ul_operator_unsigned_long.Invoke(&@this->val, num2) = num3;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
		}
	}
}
