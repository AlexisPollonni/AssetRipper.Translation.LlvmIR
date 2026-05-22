using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_hypot_double_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil5hypotIdTnNS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT_EEiE4typeELi0EEES4_S4_S4_")]
	[DemangledName("double __llvm_libc_20_1_2_::fputil::hypot<double, 0>(double, double)")]
	[return: NativeType("double")]
	public unsafe static double Invoke([MangledName("x")][NativeType("double")] double X, [MangledName("y")][NativeType("double")] double Y)
	{
		double result = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		sbyte b = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		short num = 0;
		short num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		Int128 x = default(Int128);
		Int128 @int = default(Int128);
		sbyte b2 = 0;
		long num6 = 0L;
		long num7 = 0L;
		int num8 = 0;
		short num9 = 0;
		Int128 int2 = default(Int128);
		int num10 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm9 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm10 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		long num11 = 0L;
		long num12 = 0L;
		long num13 = 0L;
		long num14 = 0L;
		long num15 = 0L;
		sbyte b3 = 0;
		sbyte b4 = 0;
		int num16 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm11 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm12 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, X);
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4, Y);
			long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4));
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) >= (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3))) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5) = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5, Unsafe.AsPointer(ref (b & 1) != 1 ? ref llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 : ref llvm_libc_20_1_2_fputil_FPBits_wjhbrm), 8L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6) = -6148914691236517206L;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6, Unsafe.AsPointer(ref (b & 1) != 1 ? ref llvm_libc_20_1_2_fputil_FPBits_wjhbrm : ref llvm_libc_20_1_2_fputil_FPBits_wjhbrm3), 8L, isVolatile: false);
			if (Details_expects_bool_condition_bool.Invoke(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5)), Expected: false))
			{
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_signaling_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)))
				{
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb.Val, 0L);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
				}
				else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
				}
				else
				{
					result = ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm))) ? Y : X);
				}
				goto IL_0e23;
			}
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5));
			Llvm_lifetime_start_p0.Invoke(2L, &num2);
			num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6));
		}
		if (unchecked((ushort)num) - unchecked((ushort)num2) >= 54 || X == 0.0 || Y == 0.0)
		{
			result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) + FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			goto IL_0e01;
		}
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		unchecked
		{
			num3 = (ushort)num;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5));
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6));
			Llvm_lifetime_start_p0.Invoke(16L, &x);
			x = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = -86;
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = 9007199254740992L;
			num4 <<= 1;
			num5 <<= 1;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = -6148914691236517206L;
			Llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = -1431655766;
			if ((ushort)num != 0)
			{
				num7 = 9007199254740992L;
				num4 |= 0x20000000000000L;
				num8 = 53;
			}
			else
			{
				num7 = Internal_find_leading_one_unsigned_long.Invoke(num4, &num8);
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
			x = NumericHelper.Multiply((Int128)(UInt128)(ulong)num4, (Int128)(UInt128)(ulong)num4);
			@int = NumericHelper.Multiply((Int128)(UInt128)(ulong)num5, (Int128)(UInt128)(ulong)num5);
			Llvm_lifetime_start_p0.Invoke(2L, &num9);
			num9 = (short)checked(2 * (unchecked((ushort)num) - unchecked((ushort)num2)));
			b2 = (NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(@int, NumericHelper.Subtract(NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)(ushort)num9, x: 1L), 1L)), 0L) ? ((sbyte)1) : ((sbyte)0));
			@int = NumericHelper.ShiftRightLogical(@int, (Int128)(UInt128)(uint)(ushort)num9);
			Llvm_lifetime_start_p0.Invoke(16L, &int2);
			int2 = NumericHelper.Add(x, @int);
			if (NumericHelper.IntCmpUge(int2, NumericHelper.ShiftLeft(y: (Int128)(UInt128)(uint)checked(2 * num8 + 2), x: 1L)))
			{
				if (num7 == 9007199254740992L)
				{
					b2 = (((b2 & 1) == 1 || NumericHelper.IntCmpNe(NumericHelper.BitwiseAnd(int2, 3L), 0L)) ? ((sbyte)1) : ((sbyte)0));
					int2 = NumericHelper.ShiftRightLogical(int2, 2L);
					num3++;
					if ((ulong)num3 >= 2047uL)
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num10);
						num10 = Fputil_quick_get_round.Invoke();
						int num17;
						if (num10 == 0 || num10 == 2048)
						{
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb3.Val);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.Val = val5;
							result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
							num17 = 1;
						}
						else
						{
							num17 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(4L, &num10);
						switch (num17)
						{
						case 0:
						{
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							long val6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb4.Val);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.Val = val6;
							result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
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
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = num7;
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = (long)NumericHelper.ShiftRightLogical(int2, (Int128)(UInt128)(uint)num8) - num7;
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = (long)int2 & (num7 - 1L);
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			for (num14 = num7 >>> 1; num14 != 0L; num14 >>>= 1)
			{
				num12 = (num12 << 1) + InstructionHelper.Select((num13 & num14) != 0L, 1, 0);
				Llvm_lifetime_start_p0.Invoke(8L, &num15);
				num15 = (num11 << 1) + num14;
				if ((ulong)num12 >= (ulong)num15)
				{
					num12 -= num15;
					num11 += num14;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num15);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (((num11 & 1L) != 0L) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(1L, &b4);
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
			Llvm_lifetime_start_p0.Invoke(4L, &num16);
			num16 = Fputil_quick_get_round.Invoke();
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
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						long val7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb5.Val);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm11.FPRepImpl.FPRepSem.FPStorage.Val = val7;
						result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						long val8 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb6.Val);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm12.FPRepImpl.FPRepSem.FPStorage.Val = val8;
						result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
					}
					goto IL_0ced;
				}
			}
			num11 |= num3 << 52;
			if ((b3 & 1) != 1 && (b2 & 1) != 1 && num12 == 0L)
			{
				Fputil_clear_except_if_required.Invoke(32);
			}
			result = Cpp_bit_cast_double_unsigned_long.Invoke(&num11);
			goto IL_0ced;
		}
		IL_0e01:
		Llvm_lifetime_end_p0.Invoke(2L, &num2);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		goto IL_0e23;
		IL_0d4f:
		Llvm_lifetime_end_p0.Invoke(16L, &int2);
		Llvm_lifetime_end_p0.Invoke(2L, &num9);
		Llvm_lifetime_end_p0.Invoke(4L, &num8);
		Llvm_lifetime_end_p0.Invoke(8L, &num7);
		Llvm_lifetime_end_p0.Invoke(8L, &num6);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(16L, &@int);
		Llvm_lifetime_end_p0.Invoke(16L, &x);
		Llvm_lifetime_end_p0.Invoke(8L, &num5);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		goto IL_0e01;
		IL_0ced:
		Llvm_lifetime_end_p0.Invoke(4L, &num16);
		Llvm_lifetime_end_p0.Invoke(1L, &b4);
		Llvm_lifetime_end_p0.Invoke(1L, &b3);
		Llvm_lifetime_end_p0.Invoke(8L, &num13);
		Llvm_lifetime_end_p0.Invoke(8L, &num12);
		Llvm_lifetime_end_p0.Invoke(8L, &num11);
		goto IL_0d4f;
		IL_0e23:
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		return result;
	}
}
