using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword12quick_mul_hiImLm1EEEvRNS_3cpp5arrayIT_XT0_EEERKS5_S8_")]
[DemangledName("void __llvm_libc_20_1_2_::multiword::quick_mul_hi<unsigned long, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
internal static partial class void_multiword_quick_mul_hi_unsigned_long_1ul_cpp_array_unsigned_long_1ul_cpp_array_unsigned_long_1ul_const_cpp_array_unsigned_long_1ul_const
{
	public unsafe static void Invoke(cpp_array_rpgxvv* dst, cpp_array_rpgxvv* lhs, cpp_array_rpgxvv* rhs)
	{
		BigInt_qdkjbh bigInt_qdkjbh = default(BigInt_qdkjbh);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		llvm_lifetime_start_p0.Invoke(16L, &bigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&bigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			multiword_Accumulator_unsigned_long_Accumulator.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < 1uL; num2++)
			{
				long num5 = unsigned_long_multiword_mul_add_with_carry_unsigned_long_2ul_cpp_array_unsigned_long_2ul_unsigned_long_unsigned_long.Invoke((cpp_array_i3937k*)(&bigInt_qdkjbh), *(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long_const.Invoke(lhs, num2), *(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long_const.Invoke(rhs, -num2));
				num += num5;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			for (num3 = 1L; (ulong)num3 < 1uL; num3++)
			{
				multiword_Accumulator_unsigned_long_advance_unsigned_long.Invoke(&bigInt_qdkjbh, num);
				num = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				for (num4 = num3 - 1L + 1L; (ulong)num4 < 1uL; num4++)
				{
					long num6 = unsigned_long_multiword_mul_add_with_carry_unsigned_long_2ul_cpp_array_unsigned_long_2ul_unsigned_long_unsigned_long.Invoke((cpp_array_i3937k*)(&bigInt_qdkjbh), *(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long_const.Invoke(lhs, num4), *(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long_const.Invoke(rhs, num3 - num4));
					num += num6;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				long num7 = multiword_Accumulator_unsigned_long_sum_const.Invoke(&bigInt_qdkjbh);
				*(long*)cpp_array_unsigned_long_1ul_operator_unsigned_long.Invoke(dst, num3 - 1L) = num7;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			long num8 = multiword_Accumulator_unsigned_long_carry_const.Invoke(&bigInt_qdkjbh);
			*(long*)cpp_array_unsigned_long_1ul_back.Invoke(dst) = num8;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
		}
	}
}
