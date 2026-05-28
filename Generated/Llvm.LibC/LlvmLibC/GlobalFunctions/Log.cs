using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Log
{
	[MangledName("log")]
	[DemangledName("log")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(Fputil_FPBits_wjhbrm);
		int num3 = 0;
		int num4 = 0;
		double num5 = 0.0;
		double num6 = 0.0;
		double a = 0.0;
		double num7 = 0.0;
		long num8 = 0L;
		double num9 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(Fputil_FPBits_wjhbrm);
		double num10 = 0.0;
		double x = 0.0;
		double num11 = 0.0;
		NumberPair numberPair = default(NumberPair);
		long x2 = 0L;
		double num12 = 0.0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(Fputil_FPBits_wjhbrm);
		NumberPair numberPair2 = default(NumberPair);
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num13 = 0.0;
		double num14 = 0.0;
		double num15 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1023;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb.Val);
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			bool num16 = Details_expects_bool_condition_bool.Invoke(Internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq.FPRepSem.FPStorage.Val, fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.Val), Expected: false);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			if (num16)
			{
				result = 0.0;
			}
			else
			{
				long num17 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
				long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb2.Val);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
				bool num18 = (ulong)num17 < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				int value;
				if (num18)
				{
					value = 1;
				}
				else
				{
					long num19 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb3.Val);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					value = (((ulong)num19 > (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4))) ? 1 : 0);
				}
				bool num20 = Details_expects_bool_condition_bool.Invoke((byte)value != 0, Expected: false);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				if (!num20)
				{
					goto IL_04eb;
				}
				if (X == 0.0)
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Sign_NEG.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb4.Val);
					fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm5);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				}
				else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)) && !FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Sign_POS.Pointer, 1L, isVolatile: false);
					long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb5.Val, 0L);
					fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val5;
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm6);
					Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
				}
				else
				{
					if (!FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
						FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm7, X * 4503599627370496.0);
						Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm7, 8L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
						num2 = checked(num2 - 52);
						num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
						goto IL_04eb;
					}
					result = X;
				}
			}
			goto IL_0a77;
		}
		IL_0a77:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		return result;
		IL_04eb:
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)(num >>> 45);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 & 0x7F;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			long num21 = num4;
			num5 = ((double*)RD.Pointer)[num21];
		}
		num2 += unchecked((int)(num + 35184372088832L >>> 52));
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = num2;
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		double x3 = num6;
		long num22 = num4;
		unchecked
		{
			a = Fputil_multiply_add_double.Invoke(x3, 0.6931471805598903, ((NumberPair*)LOG_R_DD.Pointer)[num22].Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			double x4 = num6;
			long num23 = num4;
			num7 = Fputil_multiply_add_double.Invoke(x4, 5.497923018708371E-14, ((NumberPair*)LOG_R_DD.Pointer)[num23].Lo);
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = (num & 0xFFFFFFFFFFFFFL) | 0x3FF0000000000000L;
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm8, num8);
			double num24 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm8);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			num9 = num24;
			Llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = double.NaN;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = double.NaN;
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = double.NaN;
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&numberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num8 & 0x3FFFE00000000000L;
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			FPBits_double_FPBits_unsigned_long.Invoke(&fputil_FPBits_wjhbrm9, x2);
			double num25 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm9);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
			num12 = num25;
			double x5 = num5;
			double y = num9 - num12;
			long num26 = num4;
			num10 = Fputil_multiply_add_double.Invoke(x5, y, ((double*)CD.Pointer)[num26]);
			Llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(a, num10);
			NumberPair* num27 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num27 = struct_4ydhja2.field_0;
			byte* num28 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num28 = struct_4ydhja3.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			x = num10 * num10;
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(num10, ((double*)LOG_COEFFS_34.Pointer)[1], *(double*)LOG_COEFFS_34.Pointer);
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(num10, ((double*)LOG_COEFFS_34.Pointer)[3L], ((double*)LOG_COEFFS_34.Pointer)[2L]);
			Llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = Fputil_multiply_add_double.Invoke(num10, ((double*)LOG_COEFFS_34.Pointer)[5L], ((double*)LOG_COEFFS_34.Pointer)[4L]);
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = Fputil_polyeval_double_double_double_double.Invoke(x, num7 + numberPair.Lo, a_yc74sk, a_ijazrn, a_889uw);
			num11 = Fputil_multiply_add_double.Invoke(x, 8.881784197001252E-16, 2.5849394142282115E-26);
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = numberPair.Hi + (num13 - num11);
			Llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = numberPair.Hi + (num13 + num11);
			result = ((num14 != num15) ? Anonymous_namespace_log_accurate.Invoke(num2, num4, num10) : num14);
			Llvm_lifetime_end_p0.Invoke(8L, &num15);
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			goto IL_0a77;
		}
	}
}
