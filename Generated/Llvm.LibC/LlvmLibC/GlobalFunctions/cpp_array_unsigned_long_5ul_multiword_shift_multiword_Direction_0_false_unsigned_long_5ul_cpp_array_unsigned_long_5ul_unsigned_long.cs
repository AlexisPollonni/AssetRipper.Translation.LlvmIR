using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EmLm5EEENS_3cpp5arrayIT1_XT2_EEES6_m")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned long, 5ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>, unsigned long)")]
internal static partial class cpp_array_unsigned_long_5ul_multiword_shift_multiword_Direction_0_false_unsigned_long_5ul_cpp_array_unsigned_long_5ul_unsigned_long
{
	public unsafe static void Invoke([MangledName("agg.result")] cpp_array_v97b5b* agg_result, void* array, long offset)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_6je4un anon_6je4un2 = default(anon_6je4un);
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 64L;
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 320L;
		unchecked
		{
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(offset == 0L, expected: false))
			{
				llvm_memcpy_p0_p0_i64.Invoke(agg_result, array, 40L, isVolatile: false);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = 0;
				llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_start_p0.Invoke(16L, &anon_6je4un2);
				*(IntPtr*)(&anon_6je4un2) = unchecked((nint)(-6148914691236517206L));
				*(IntPtr*)((byte*)(&anon_6je4un2) + 8) = unchecked((nint)(-6148914691236517206L));
				anon_6je4un2.field_0 = &anon_izyfb8;
				anon_6je4un2.field_1 = array;
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (long)((ulong)offset / 64uL);
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = (long)((ulong)offset % 64uL);
				llvm_assume.Invoke((ulong)num3 < 5uL);
				llvm_memset_p0_i64.Invoke(agg_result, 0, 40L, isVolatile: false);
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = 0L; (ulong)num5 < 5uL; num5++)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = cpp_array_unsigned_long_5ul_multiword_shift_multiword_Direction_0_false_unsigned_long_5ul_cpp_array_unsigned_long_5ul_unsigned_long_lambda0_unsigned_long_operator_unsigned_long_const.Invoke(&anon_6je4un2, num5 + num3);
					llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = cpp_array_unsigned_long_5ul_multiword_shift_multiword_Direction_0_false_unsigned_long_5ul_cpp_array_unsigned_long_5ul_unsigned_long_lambda0_unsigned_long_operator_unsigned_long_const.Invoke(&anon_6je4un2, num5 + num3 + 1L);
					llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = cpp_array_unsigned_long_5ul_operator_unsigned_long.Invoke(agg_result, cpp_array_unsigned_long_5ul_multiword_shift_multiword_Direction_0_false_unsigned_long_5ul_cpp_array_unsigned_long_5ul_unsigned_long_lambda_unsigned_long_operator_unsigned_long_const.Invoke(&anon_izyfb8, num5));
					if (num4 == 0L)
					{
						*(long*)ptr = num6;
					}
					else
					{
						*(long*)ptr = (num6 << (int)num4) | (num7 >>> (int)(64L - num4));
					}
					llvm_lifetime_end_p0.Invoke(8L, &ptr);
					llvm_lifetime_end_p0.Invoke(8L, &num7);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(16L, &anon_6je4un2);
				llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
