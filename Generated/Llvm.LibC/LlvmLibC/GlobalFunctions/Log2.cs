using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Log2
{
	[MangledName("log2")]
	[DemangledName("log2")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num = 0L;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num3 = 0;
		int num4 = 0;
		double num5 = 0.0;
		double a = 0.0;
		long num6 = 0L;
		double num7 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double num8 = 0.0;
		double num9 = 0.0;
		double num10 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		long x = 0L;
		double num11 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm9 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num12 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		double num13 = 0.0;
		double num14 = 0.0;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double result;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1023;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			bool num15 = Details_expects_bool_condition_bool.Invoke(Internal_Equals_r4buia.Invoke(llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq.FPRepSem.FPStorage.Val, llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.Val), Expected: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			if (num15)
			{
				result = 0.0;
			}
			else
			{
				long num16 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb2.Val);
				llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
				bool num17 = (ulong)num16 < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				int value;
				if (num17)
				{
					value = -1;
				}
				else
				{
					long num18 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb3.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					value = (((ulong)num18 > (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4))) ? 1 : 0);
				}
				bool num19 = Details_expects_bool_condition_bool.Invoke((byte)value != 0, Expected: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				if (!num19)
				{
					goto IL_04e5;
				}
				if (X == 0.0)
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb4.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
				}
				else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) && !FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb5.Val, 0L);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val5;
					result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
				}
				else
				{
					if (!FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
						FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, X * 4503599627370496.0);
						Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7, 8L, isVolatile: false);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
						num2 = checked(num2 - 52);
						num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
						goto IL_04e5;
					}
					result = X;
				}
			}
			goto IL_0b09;
		}
		IL_0b09:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		return result;
		IL_04e5:
		Llvm_lifetime_start_p0.Invoke(4L, &num3);
		unchecked
		{
			num3 = (int)(num >>> 45);
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = num3 & 0x7F;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			long num20 = num4;
			num5 = ((double*)Llvm_libc_20_1_2_RD.Pointer)[num20];
		}
		num2 += unchecked((int)(num + 35184372088832L >>> 52));
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = num2;
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = (num & 0xFFFFFFFFFFFFFL) | 0x3FF0000000000000L;
		Llvm_lifetime_start_p0.Invoke(8L, &num7);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
		FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8, num6);
		double num21 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
		num7 = num21;
		Llvm_lifetime_start_p0.Invoke(8L, &num8);
		num8 = double.NaN;
		Llvm_lifetime_start_p0.Invoke(8L, &num9);
		num9 = double.NaN;
		Llvm_lifetime_start_p0.Invoke(8L, &num10);
		num10 = double.NaN;
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num6 & 0x3FFFE00000000000L;
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9, x);
			double num22 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
			num11 = num22;
			double x2 = num5;
			double y = num7 - num11;
			long num23 = num4;
			num8 = Fputil_multiply_add_double.Invoke(x2, y, ((double*)Llvm_libc_20_1_2_CD.Pointer)[num23]);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			long num24 = num4;
			Struct_4ydhja struct_4ydhja = Fputil_exact_add_true.Invoke(((Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_LOG_R1.Pointer)[num24].Hi, num8);
			Llvm_libc_20_1_2_NumberPair* num25 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num25 = struct_4ydhja2.field_0;
			byte* num26 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num26 = struct_4ydhja3.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair2, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			num9 = num8 * num8;
			num10 = num9 * 1.7763568394002505E-15;
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(num8, ((double*)Llvm_libc_20_1_2_LOG_COEFFS.Pointer)[1], *(double*)Llvm_libc_20_1_2_LOG_COEFFS.Pointer);
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(num8, ((double*)Llvm_libc_20_1_2_LOG_COEFFS.Pointer)[3L], ((double*)Llvm_libc_20_1_2_LOG_COEFFS.Pointer)[2L]);
			Llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = Fputil_multiply_add_double.Invoke(num8, ((double*)Llvm_libc_20_1_2_LOG_COEFFS.Pointer)[5L], ((double*)Llvm_libc_20_1_2_LOG_COEFFS.Pointer)[4L]);
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			double x3 = num9;
			long num27 = num4;
			num12 = Fputil_polyeval_double_double_double_double.Invoke(x3, ((Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_LOG_R1.Pointer)[num27].Lo, a_yc74sk, a_ijazrn, a_889uw);
			llvm_libc_20_1_2_NumberPair.Lo += num12;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult_27ul.Invoke(&llvm_libc_20_1_2_NumberPair, Llvm_libc_20_1_2_anonymous_namespace_LOG2_E.Pointer);
			Llvm_libc_20_1_2_NumberPair* num28 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num28 = struct_4ydhja5.field_0;
			byte* num29 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num29 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_exact_add_true.Invoke(a, llvm_libc_20_1_2_NumberPair3.Hi);
			Llvm_libc_20_1_2_NumberPair* num30 = &llvm_libc_20_1_2_NumberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num30 = struct_4ydhja8.field_0;
			byte* num31 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num31 = struct_4ydhja9.field_1;
			double lo = llvm_libc_20_1_2_NumberPair3.Lo;
			llvm_libc_20_1_2_NumberPair4.Lo += lo;
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo - num10);
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = llvm_libc_20_1_2_NumberPair4.Hi + (llvm_libc_20_1_2_NumberPair4.Lo + num10);
			result = ((num13 != num14) ? Anonymous_namespace_log2_accurate.Invoke(num2, num4, num8) : num13);
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			goto IL_0b09;
		}
	}
}
