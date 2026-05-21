using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class multiword_shift_multiword_Direction_0_false_unsigned_short_1ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9multiword5shiftILNS0_9DirectionE0ELb0EtLm1EEENS_3cpp5arrayIT1_XT2_EEES6_m")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul> __llvm_libc_20_1_2_::multiword::shift<(__llvm_libc_20_1_2_::multiword::Direction)0, false, unsigned short, 1ul>(__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>, unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>")]
	public unsafe static short Invoke([MangledName("array.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned short, 1ul>")] short array, [NativeType("unsigned long")] long offset)
	{
		cpp_array_knh6hw cpp_array_knh6hw2 = default(cpp_array_knh6hw);
		cpp_array_knh6hw cpp_array_knh6hw3 = default(cpp_array_knh6hw);
		long num = 0L;
		long num2 = 0L;
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_6je4un anon_6je4un2 = default(anon_6je4un);
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		short num6 = 0;
		short num7 = 0;
		void* ptr = null;
		unchecked
		{
			*(short*)(&cpp_array_knh6hw3.Data) = array;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 16L;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = 16L;
			if (details_expects_bool_condition_bool.Invoke(offset == 0L, expected: false))
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_array_knh6hw2, &cpp_array_knh6hw3, 2L, isVolatile: false);
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
				anon_6je4un2.field_1 = &cpp_array_knh6hw3;
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = (long)((ulong)offset / 16uL);
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = (long)((ulong)offset % 16uL);
				llvm_assume.Invoke((ulong)num3 < 1uL);
				llvm_memset_p0_i64.Invoke(&cpp_array_knh6hw2, 0, 2L, isVolatile: false);
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				for (num5 = 0L; (ulong)num5 < 1uL; num5++)
				{
					llvm_lifetime_start_p0.Invoke(2L, &num6);
					num6 = lambda0_Invoke_2axa5k.Invoke(&anon_6je4un2, num5 + num3);
					llvm_lifetime_start_p0.Invoke(2L, &num7);
					num7 = lambda0_Invoke_2axa5k.Invoke(&anon_6je4un2, num5 + num3 + 1L);
					llvm_lifetime_start_p0.Invoke(8L, &ptr);
					ptr = (void*)12297829382473034410uL;
					ptr = array_unsigned_short_1ul_Index_yq9pn3.Invoke(&cpp_array_knh6hw2, lambda_Invoke_x5ppib.Invoke(&anon_izyfb8, num5));
					if (num4 == 0L)
					{
						*(short*)ptr = num6;
					}
					else
					{
						*(short*)ptr = (short)(((ushort)num6 << (int)num4) | ((ushort)num7 >> (int)(16L - num4)));
					}
					llvm_lifetime_end_p0.Invoke(8L, &ptr);
					llvm_lifetime_end_p0.Invoke(2L, &num7);
					llvm_lifetime_end_p0.Invoke(2L, &num6);
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
			return *(short*)(&cpp_array_knh6hw2.Data);
		}
	}
}
