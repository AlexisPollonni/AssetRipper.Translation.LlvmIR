using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_shift_multiword_Direction_1_false_unsigned_long_5ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm5EEENS_3cpp5arrayIT1_XT2_EEES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 5ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] cpp_array_msasyg* agg_result, [NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 5ul>")] void* array, [NativeType("unsigned long")] long offset)
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
			if (details_expects_bool_condition_bool.Invoke(offset == 0L, expected: false))
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
					num6 = lambda0_Invoke_3hws57.Invoke(&anon_6je4un2, num5 + num3);
					llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = lambda0_Invoke_3hws57.Invoke(&anon_6je4un2, num5 + num3 + 1L);
					llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = array_unsigned_long_5ul_Index_wu6ki8.Invoke(agg_result, lambda_Invoke_yubd88.Invoke(&anon_izyfb8, num5));
					if (num4 == 0L)
					{
						*(long*)ptr = num6;
					}
					else
					{
						*(long*)ptr = (num6 >>> (int)num4) | (num7 << (int)(64L - num4));
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
