using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Multiword_shift_multiword_Direction_1_false_unsigned_long_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE1ELb0EmLm1EEENS_3cpp5arrayIT1_XT2_EEES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)1, false, unsigned long, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>")]
	public unsafe static long Invoke([MangledName("array.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 1ul>")] long Array, [MangledName("offset")][NativeType("unsigned long")] long Offset)
	{
		Cpp_array_rpgxvv cpp_array_rpgxvv = default(Cpp_array_rpgxvv);
		Cpp_array_rpgxvv cpp_array_rpgxvv2 = default(Cpp_array_rpgxvv);
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
		unchecked
		{
			*(long*)(&cpp_array_rpgxvv2.Data) = Array;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 64L;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 64L;
			if (Details_expects_bool_condition_bool.Invoke(Offset == 0L, Expected: false))
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_rpgxvv, &cpp_array_rpgxvv2, 8L, isVolatile: false);
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
				anon_6je4un.field_1 = &cpp_array_rpgxvv2;
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (long)((ulong)Offset / 64uL);
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = (long)((ulong)Offset % 64uL);
				Llvm_assume.Invoke((ulong)num3 < 1uL);
				Llvm_memset_p0_i64.Invoke(&cpp_array_rpgxvv, 0, 8L, isVolatile: false);
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = 0L; (ulong)num5 < 1uL; num5++)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = Lambda0_Invoke_v2e4in.Invoke(&anon_6je4un, num5 + num3);
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = Lambda0_Invoke_v2e4in.Invoke(&anon_6je4un, num5 + num3 + 1L);
					Llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = Array_unsigned_long_1ul_Index_3erz3i.Invoke(&cpp_array_rpgxvv, Lambda_Invoke_9hkdan.Invoke(&anon_izyfb, num5));
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
			return *(long*)(&cpp_array_rpgxvv.Data);
		}
	}
}
