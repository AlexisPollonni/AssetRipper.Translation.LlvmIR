using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword19multiply_with_carryImLm2ELm1ELm1EEET_RNS_3cpp5arrayIS2_XT0_EEERKNS4_IS2_XT1_EEERKNS4_IS2_XT2_EEE")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::multiword::multiply_with_carry<unsigned long, 2ul, 1ul, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
internal static partial class unsigned_long_multiword_multiply_with_carry_unsigned_long_2ul_1ul_1ul_cpp_array_unsigned_long_2ul_cpp_array_unsigned_long_1ul_const_cpp_array_unsigned_long_1ul_const
{
	public unsafe static long Invoke(cpp_array_i3937k* dst, cpp_array_rpgxvv* lhs, cpp_array_rpgxvv* rhs)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			multiword_Accumulator_unsigned_long_Accumulator.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 2uL; num++)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = (((ulong)num >= 1uL) ? (num - 1L + 1L) : 0L);
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (((ulong)num >= 1uL) ? 0L : num);
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = num2; (ulong)num5 <= (ulong)num3; num5++)
				{
					long num6 = unsigned_long_multiword_mul_add_with_carry_unsigned_long_2ul_cpp_array_unsigned_long_2ul_unsigned_long_unsigned_long.Invoke((cpp_array_i3937k*)(&bigInt_qdkjbh), *(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long_const.Invoke(lhs, num5), *(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long_const.Invoke(rhs, num - num5));
					num4 += num6;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				long num7 = multiword_Accumulator_unsigned_long_advance_unsigned_long.Invoke(&bigInt_qdkjbh, num4);
				*(long*)cpp_array_unsigned_long_2ul_operator_unsigned_long.Invoke(dst, num) = num7;
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			long result = multiword_Accumulator_unsigned_long_carry_const.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
			return result;
		}
	}
}
