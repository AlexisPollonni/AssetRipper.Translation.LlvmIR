using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_quick_mul_hi_unsigned_long_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword12quick_mul_hiImLm1EEEvRNS_3cpp5arrayIT_XT0_EEERKS5_S8_")]
	[DemangledName("void __llvm_libc_20_1_2_::multiword::quick_mul_hi<unsigned long, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&, __llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>&")] Llvm_libc_20_1_2_cpp_array_rpgxvv* Dst, [MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_rpgxvv* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> const&")] Llvm_libc_20_1_2_cpp_array_rpgxvv* Rhs)
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
			for (num2 = 0L; (ulong)num2 < 1uL; num2++)
			{
				long num5 = Multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)(&llvm_libc_20_1_2_BigInt_qdkjbh), *(long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(Lhs, num2), *(long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(Rhs, -num2));
				num += num5;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			for (num3 = 1L; (ulong)num3 < 1uL; num3++)
			{
				Accumulator_unsigned_long_advance.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh, num);
				num = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				for (num4 = num3 - 1L + 1L; (ulong)num4 < 1uL; num4++)
				{
					long num6 = Multiword_mul_add_with_carry_unsigned_long_2ul.Invoke((Llvm_libc_20_1_2_cpp_array_i3937k*)(&llvm_libc_20_1_2_BigInt_qdkjbh), *(long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(Lhs, num4), *(long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(Rhs, num3 - num4));
					num += num6;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				long num7 = Accumulator_unsigned_long_sum.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh);
				*(long*)Array_unsigned_long_1ul_Index_3erz3i.Invoke(Dst, num3 - 1L) = num7;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			long num8 = Accumulator_unsigned_long_carry.Invoke(&llvm_libc_20_1_2_BigInt_qdkjbh);
			*(long*)Array_unsigned_long_1ul_back.Invoke(Dst) = num8;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_BigInt_qdkjbh);
		}
	}
}
