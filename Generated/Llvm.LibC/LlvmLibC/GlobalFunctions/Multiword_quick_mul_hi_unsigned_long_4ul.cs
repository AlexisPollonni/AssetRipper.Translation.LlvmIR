using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_quick_mul_hi_unsigned_long_4ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword12quick_mul_hiImLm4EEEvRNS_3cpp5arrayIT_XT0_EEERKS5_S8_")]
	[DemangledName("void __llvm_libc_20_1_2_::multiword::quick_mul_hi<unsigned long, 4ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul>&")] Llvm_libc_20_1_2_cpp_array_jgy3xh* Dst, [MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&")] Llvm_libc_20_1_2_cpp_array_jgy3xh* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 4ul> const&")] Llvm_libc_20_1_2_cpp_array_jgy3xh* Rhs)
	{
		Llvm_libc_20_1_2_BigInt_qdkjbh llvm_libc_20_1_2_BigInt_qdkjbh = default(Llvm_libc_20_1_2_BigInt_qdkjbh);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_BigInt_qdkjbh);
			*(long*)ptr = -6148914691236517206L;
			((long*)ptr)[1] = -6148914691236517206L;
			Accumulator_unsigned_long_Constructor.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (ulong)num2 < 4uL; num2++)
			{
				long num5 = Multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)(&llvm_libc_20_1_2_BigInt_qdkjbh), *(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(Lhs, num2), *(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(Rhs, 3L - num2));
				num += num5;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			for (num3 = 4L; (ulong)num3 < 7uL; num3++)
			{
				Accumulator_unsigned_long_advance.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh, num);
				num = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				for (num4 = num3 - 4L + 1L; (ulong)num4 < 4uL; num4++)
				{
					long num6 = Multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)(&llvm_libc_20_1_2_BigInt_qdkjbh), *(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(Lhs, num4), *(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(Rhs, num3 - num4));
					num += num6;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				long num7 = Accumulator_unsigned_long_sum.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh);
				*(long*)Array_unsigned_long_4ul_Index_6jyt8f.Invoke(Dst, num3 - 4L) = num7;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			long num8 = Accumulator_unsigned_long_carry.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh);
			*(long*)Array_unsigned_long_4ul_back.Invoke(Dst) = num8;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
		}
	}
}
