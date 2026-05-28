using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_shift_multiword_Direction_1_false_unsigned_long_258ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm258EEENS_3cpp5arrayIT1_XT2_EEES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 258ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>")]
	public unsafe static void Invoke([MangledName("agg.result")] Cpp_array_anzbtp* Agg_result, [MangledName("array")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>")] void* Array, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		long num = 0L;
		long num2 = 0L;
		sbyte b = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_6je4un anon_6je4un = default(Anon_6je4un);
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		void* ptr = null;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 64L;
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 16512L;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke(Offset == 0L, Expected: false))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, Array, 2064L, isVolatile: false);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(1L, &b);
				b = 0;
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_start_p0.Invoke(16L, &anon_6je4un);
				*(IntPtr*)(&anon_6je4un) = unchecked((nint)(-6148914691236517206L));
				*(IntPtr*)((byte*)(&anon_6je4un) + 8) = unchecked((nint)(-6148914691236517206L));
				anon_6je4un.field_0 = &anon_izyfb;
				anon_6je4un.field_1 = Array;
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (long)((ulong)Offset / 64uL);
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = (long)((ulong)Offset % 64uL);
				Llvm_assume.Invoke((ulong)num3 < 258uL);
				Llvm_memset_p0_i64.Invoke(Agg_result, 0, 2064L, isVolatile: false);
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = 0L; (ulong)num5 < 258uL; num5++)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = Lambda0_Invoke_srk2wk.Invoke(&anon_6je4un, num5 + num3);
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = Lambda0_Invoke_srk2wk.Invoke(&anon_6je4un, num5 + num3 + 1L);
					Llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = Array_unsigned_long_258ul_Index_cpunpn.Invoke(Agg_result, Lambda_Invoke_cvese8.Invoke(&anon_izyfb, num5));
					if (num4 == 0L)
					{
						*(long*)ptr = num6;
					}
					else
					{
						*(long*)ptr = (num6 >>> (int)num4) | (num7 << (int)(64L - num4));
					}
					Llvm_lifetime_end_p0.Invoke(8L, &ptr);
					Llvm_lifetime_end_p0.Invoke(8L, &num7);
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(16L, &anon_6je4un);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
				Llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
