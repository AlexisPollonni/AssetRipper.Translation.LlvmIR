using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_quick_mul_hi_unsigned_long_4ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword12quick_mul_hiImLm4EEEvRNS_3cpp5arrayIT_XT0_EEERKS5_S8_")]
	[DemangledName("void __llvm_libc_20_1_2_::multiword::quick_mul_hi<unsigned long, 4ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>&")] cpp_array_jgy3xh* dst, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&")] cpp_array_jgy3xh* lhs, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&")] cpp_array_jgy3xh* rhs)
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
			Accumulator_unsigned_long_Constructor.Invoke(&bigInt_qdkjbh);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < 4uL; num2++)
			{
				long num5 = multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((cpp_array_i3937k*)(&bigInt_qdkjbh), *(long*)array_unsigned_long_4ul_Index_pwcpnu.Invoke(lhs, num2), *(long*)array_unsigned_long_4ul_Index_pwcpnu.Invoke(rhs, 3L - num2));
				num += num5;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			for (num3 = 4L; (ulong)num3 < 7uL; num3++)
			{
				Accumulator_unsigned_long_advance.Invoke(&bigInt_qdkjbh, num);
				num = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				for (num4 = num3 - 4L + 1L; (ulong)num4 < 4uL; num4++)
				{
					long num6 = multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((cpp_array_i3937k*)(&bigInt_qdkjbh), *(long*)array_unsigned_long_4ul_Index_pwcpnu.Invoke(lhs, num4), *(long*)array_unsigned_long_4ul_Index_pwcpnu.Invoke(rhs, num3 - num4));
					num += num6;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				long num7 = Accumulator_unsigned_long_sum.Invoke(&bigInt_qdkjbh);
				*(long*)array_unsigned_long_4ul_Index_6jyt8f.Invoke(dst, num3 - 4L) = num7;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			long num8 = Accumulator_unsigned_long_carry.Invoke(&bigInt_qdkjbh);
			*(long*)array_unsigned_long_4ul_back.Invoke(dst) = num8;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &bigInt_qdkjbh);
		}
	}
}
