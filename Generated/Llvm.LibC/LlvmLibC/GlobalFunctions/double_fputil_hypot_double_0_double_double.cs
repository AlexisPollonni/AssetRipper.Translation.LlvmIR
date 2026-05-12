using System;
using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5hypotIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
[DemangledName("double __llvm_libc_20_1_2_::fputil::hypot<double, 0>(double, double)")]
internal static partial class double_fputil_hypot_double_0_double_double
{
	public unsafe static double Invoke(double x, double y)
	{
		double result = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		short num = 0;
		short num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		Int128 x2 = default(Int128);
		Int128 @int = default(Int128);
		sbyte b2 = 0;
		long num6 = 0L;
		long num7 = 0L;
		int num8 = 0;
		short num9 = 0;
		Int128 int2 = default(Int128);
		int num10 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		long num11 = 0L;
		long num12 = 0L;
		long num13 = 0L;
		long num14 = 0L;
		long num15 = 0L;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int num16 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm12 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm13 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, x);
			long val = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm5, y);
			long val2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) >= (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4))) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
			*(long*)(&fputil_FPBits_wjhbrm6) = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm6, Unsafe.AsPointer(ref (b & 1) != 1 ? ref fputil_FPBits_wjhbrm4 : ref fputil_FPBits_wjhbrm2), 8L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			*(long*)(&fputil_FPBits_wjhbrm7) = -6148914691236517206L;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm7, Unsafe.AsPointer(ref (b & 1) != 1 ? ref fputil_FPBits_wjhbrm2 : ref fputil_FPBits_wjhbrm4), 8L, isVolatile: false);
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6)), expected: false))
			{
				if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
				{
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb8.val, 0L);
					fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val3;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm8);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
				}
				else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) || fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
				{
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb9.val);
					fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val4;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm9);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
				}
				else
				{
					result = ((!fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? y : x);
				}
				goto IL_0e23;
			}
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6));
			llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7));
		}
		if (unchecked((ushort)num) - unchecked((ushort)num2) >= 54 || x == 0.0 || y == 0.0)
		{
			result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2) + fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
			goto IL_0e01;
		}
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		unchecked
		{
			num3 = (ushort)num;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6));
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7));
			llvm_lifetime_start_p0.Invoke(16L, &x2);
			x2 = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = -86;
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = 9007199254740992L;
			num4 <<= 1;
			num5 <<= 1;
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = -6148914691236517206L;
			llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = -1431655766;
			if ((ushort)num != 0)
			{
				num7 = 9007199254740992L;
				num4 |= 0x20000000000000L;
				num8 = 53;
			}
			else
			{
				num7 = unsigned_long_fputil_internal_find_leading_one_unsigned_long_unsigned_long_int.Invoke(num4, &num8);
				num = 1;
			}
			if ((ushort)num2 != 0)
			{
				num5 |= 0x20000000000000L;
			}
			else
			{
				num2 = 1;
			}
			x2 = NumericHelper.Multiply((Int128)(UInt128)(ulong)num4, (Int128)(UInt128)(ulong)num4);
			@int = NumericHelper.Multiply((Int128)(UInt128)(ulong)num5, (Int128)(UInt128)(ulong)num5);
			llvm_lifetime_start_p0.Invoke(2L, &num9);
			num9 = (short)checked(2 * (unchecked((ushort)num) - unchecked((ushort)num2)));
			b2 = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(ushort)num9, x: 1L), 1L)), 0L) ? ((sbyte)1) : ((sbyte)0));
			@int = NumericHelper.ShiftRightLogical(@int, (Int128)(UInt128)(uint)(ushort)num9);
			llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = NumericHelper.Add(x2, @int);
			if (NumericHelper.IntCmpUge(int2, NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)checked(2 * num8 + 2), x: 1L)))
			{
				if (num7 == 9007199254740992L)
				{
					b2 = (sbyte)(byte)(((b2 & 1) != 1) ? (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(int2, 3L), 0L) ? 1 : 0) : (-1));
					int2 = NumericHelper.ShiftRightLogical(int2, 2L);
					num3++;
					if ((ulong)num3 >= 2047uL)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = fputil_quick_get_round.Invoke();
						int num17;
						if (num10 == 0 || num10 == 2048)
						{
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
							long val5 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb10.val);
							fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.val = val5;
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm10);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
							num17 = 1;
						}
						else
						{
							num17 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num10);
						switch (num17)
						{
						case 0:
						{
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							long val6 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal_Sign.Invoke(anon_izyfb11.val);
							fputil_FPBits_wjhbrm11.FPRepImpl.FPRepSem.FPStorage.val = val6;
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm11);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
							break;
						}
						}
						goto IL_0d4f;
					}
				}
				else
				{
					num7 <<= 1;
					num8 = checked(num8 + 1);
				}
			}
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = num7;
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = (long)NumericHelper.ShiftRightLogical(int2, (Int128)(UInt128)(uint)num8) - num7;
			llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = (long)int2 & (num7 - 1L);
			llvm_lifetime_start_p0.Invoke(8L, &num14);
			for (num14 = num7 >>> 1; num14 != 0L; num14 >>>= 1)
			{
				num12 = (num12 << 1) + InstructionHelper.Select((num13 & num14) != 0L, 1, 0);
				llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = (num11 << 1) + num14;
				if ((ulong)num12 >= (ulong)num15)
				{
					num12 -= num15;
					num11 += num14;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num15);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num14);
			llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (((num11 & 1L) != 0L) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(1L, &b4);
			b4 = (((num11 & 2L) != 0L) ? ((sbyte)1) : ((sbyte)0));
			if ((ulong)num11 >= 9007199254740992uL)
			{
				num11 -= 9007199254740992L;
				if (num3 == 0L)
				{
					num3 = 1L;
				}
			}
			num11 >>>= 1;
			llvm_lifetime_start_p0.Invoke(4L, &num16);
			num16 = fputil_quick_get_round.Invoke();
			switch (num16)
			{
			case 0:
				if ((b3 & 1) == 1 && ((b4 & 1) == 1 || (b2 & 1) == 1 || num12 != 0L))
				{
					num11++;
				}
				break;
			case 2048:
				if ((b3 & 1) == 1 || (b2 & 1) == 1 || num12 != 0L)
				{
					num11++;
				}
				break;
			}
			if ((ulong)num11 >= 4503599627370496uL)
			{
				num11 -= 4503599627370496L;
				num3++;
				if ((ulong)num3 >= 2047uL)
				{
					if (num16 == 0 || num16 == 2048)
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
						long val7 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb12.val);
						fputil_FPBits_wjhbrm12.FPRepImpl.FPRepSem.FPStorage.val = val7;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm12);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
						long val8 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal_Sign.Invoke(anon_izyfb13.val);
						fputil_FPBits_wjhbrm13.FPRepImpl.FPRepSem.FPStorage.val = val8;
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm13);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
					}
					goto IL_0ced;
				}
			}
			num11 |= num3 << 52;
			if ((b3 & 1) != 1 && (b2 & 1) != 1 && num12 == 0L)
			{
				fputil_clear_except_if_required_int.Invoke(32);
			}
			result = cpp_enable_if_sizeof_double_sizeof_unsigned_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_unsigned_long_value_double_type_cpp_bit_cast_double_unsigned_long_unsigned_long_const.Invoke(&num11);
			goto IL_0ced;
		}
		IL_0e01:
		llvm_lifetime_end_p0.Invoke(2L, &num2);
		llvm_lifetime_end_p0.Invoke(2L, &num);
		goto IL_0e23;
		IL_0d4f:
		llvm_lifetime_end_p0.Invoke(16L, &int2);
		llvm_lifetime_end_p0.Invoke(2L, &num9);
		llvm_lifetime_end_p0.Invoke(4L, &num8);
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(16L, &@int);
		llvm_lifetime_end_p0.Invoke(16L, &x2);
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		goto IL_0e01;
		IL_0ced:
		llvm_lifetime_end_p0.Invoke(4L, &num16);
		llvm_lifetime_end_p0.Invoke(1L, &b4);
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(8L, &num13);
		llvm_lifetime_end_p0.Invoke(8L, &num12);
		llvm_lifetime_end_p0.Invoke(8L, &num11);
		goto IL_0d4f;
		IL_0e23:
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
	}
}
