using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Pow
{
	[MangledName("pow")]
	[DemangledName("pow")]
	public unsafe static double Invoke([MangledName("x")] double X, [MangledName("y")] double Y)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		sbyte b = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		sbyte b2 = 0;
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm4 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		double num6 = 0.0;
		long num7 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm5 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm6 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm7 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb7 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm8 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb8 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm9 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb9 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm10 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb10 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm11 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb11 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm12 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb12 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm13 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb13 = default(Anon_izyfb7);
		sbyte b3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm14 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb14 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm15 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb15 = default(Anon_izyfb7);
		sbyte b4 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm16 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb16 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm17 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb17 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm18 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb18 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm19 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm20 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb19 = default(Anon_izyfb7);
		int num8 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm21 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		InlineArray7_Double inlineArray7_Double = default(InlineArray7_Double);
		double num9 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		double num10 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm22 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		double num11 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double num12 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double b5 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		double num13 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair5 = default(Llvm_libc_20_1_2_NumberPair);
		double num14 = 0.0;
		double num15 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm23 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm24 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb20 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm25 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb21 = default(Anon_izyfb7);
		double num16 = 0.0;
		double num17 = 0.0;
		double num18 = 0.0;
		int num19 = 0;
		int num20 = 0;
		long num21 = 0L;
		long num22 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm26 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long num23 = 0L;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm27 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		long x = 0L;
		long x2 = 0L;
		double num24 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm28 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double z = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm29 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double x3 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double y = 0.0;
		double num25 = 0.0;
		double num26 = Y;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double result;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, num26);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
			b = (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
			b2 = (Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			long val = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4) = -6148914691236517206L;
			long val2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.Val = val2;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm4));
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = 0L;
			bool num27 = num2 == 0L;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
			int value;
			if (num27)
			{
				value = 1;
			}
			else if ((ulong)num5 > 4888456257178775634uL)
			{
				value = 1;
			}
			else
			{
				long num28 = num3;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				long val3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb5.Val);
				llvm_libc_20_1_2_fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.Val = val3;
				if (num28 == FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm5)))
				{
					value = 1;
				}
				else
				{
					long num29 = num3;
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb6, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb6.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					if ((ulong)num29 >= (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm6)))
					{
						value = 1;
					}
					else
					{
						long num30 = num3;
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb7, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						long val5 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb7.Val);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.Val = val5;
						value = (((ulong)num30 < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm7))) ? 1 : 0);
					}
				}
			}
			bool num31 = Details_expects_bool_condition_bool.Invoke((byte)value != 0, Expected: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm7);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm6);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm5);
			if (!num31)
			{
				goto IL_0fb4;
			}
			if (num26 == 0.0)
			{
				result = 1.0;
			}
			else
			{
				long num32 = num5;
				if (num32 != 4602678819172646912L)
				{
					if (num32 != 4607182418800017408L)
					{
						if (num32 == 4611686018427387904L)
						{
							result = (((b2 & 1) != 1) ? (X * X) : (1.0 / (X * X)));
						}
						else
						{
							if ((ulong)num5 > 4888456257178775634uL)
							{
								if ((ulong)num5 >= 9218868437227405312uL)
								{
									if (num2 != 0L)
									{
										long num33 = num3;
										Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
										Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
										long val6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb9.Val);
										llvm_libc_20_1_2_fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.Val = val6;
										result = ((num33 != FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm9))) ? num26 : 1.0);
										Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm9);
									}
									else if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)))
									{
										result = X;
									}
									else if (num4 == 4607182418800017408L)
									{
										result = 1.0;
									}
									else if (X == 0.0 && (b2 & 1) == 1)
									{
										Fputil_set_errno_if_required.Invoke(33);
										Fputil_raise_except_if_required.Invoke(4);
										Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
										Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
										long val7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb10.Val);
										llvm_libc_20_1_2_fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.Val = val7;
										result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
										Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm10);
									}
									else
									{
										long num34 = num4;
										Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
										Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
										long val8 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb11.Val);
										llvm_libc_20_1_2_fputil_FPBits_wjhbrm11.FPRepImpl.FPRepSem.FPStorage.Val = val8;
										bool condition = (ulong)num34 < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm11)) == ((b2 & 1) == 1);
										Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
										Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
										long val9 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb12.Val);
										llvm_libc_20_1_2_fputil_FPBits_wjhbrm12.FPRepImpl.FPRepSem.FPStorage.Val = val9;
										result = InstructionHelper.Select(condition, FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm12), 0.0);
										Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm12);
										Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm11);
									}
									goto IL_1cc0;
								}
								num26 = InstructionHelper.Select((b2 & 1) == 1, -1.2676506002282294E+30, 1.2676506002282294E+30);
							}
							long num35 = num3;
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm13);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							long val10 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_one.Invoke(anon_izyfb13.Val);
							llvm_libc_20_1_2_fputil_FPBits_wjhbrm13.FPRepImpl.FPRepSem.FPStorage.Val = val10;
							bool num36 = num35 == FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm13));
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm13);
							if (num36)
							{
								result = 1.0;
							}
							else if (X == 0.0)
							{
								Llvm_lifetime_start_p0.Invoke(1L, &b3);
								b3 = (((b & 1) == 1 && Anonymous_namespace_is_odd_integer.Invoke(num26)) ? ((sbyte)1) : ((sbyte)0));
								if ((b2 & 1) == 1)
								{
									Fputil_set_errno_if_required.Invoke(33);
									Fputil_raise_except_if_required.Invoke(4);
									Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm14);
									Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, ((b3 & 1) != 1) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
									long val11 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb14.Val);
									llvm_libc_20_1_2_fputil_FPBits_wjhbrm14.FPRepImpl.FPRepSem.FPStorage.Val = val11;
									result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm14);
									Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm14);
								}
								else
								{
									result = InstructionHelper.Select((b3 & 1) == 1, -0.0, 0.0);
								}
								Llvm_lifetime_end_p0.Invoke(1L, &b3);
							}
							else
							{
								long num37 = num4;
								Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm15);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
								long val12 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb15.Val);
								llvm_libc_20_1_2_fputil_FPBits_wjhbrm15.FPRepImpl.FPRepSem.FPStorage.Val = val12;
								bool num38 = num37 == FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm15));
								Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm15);
								if (num38)
								{
									Llvm_lifetime_start_p0.Invoke(1L, &b4);
									b4 = (((b & 1) == 1 && Anonymous_namespace_is_odd_integer.Invoke(num26)) ? ((sbyte)1) : ((sbyte)0));
									if ((b2 & 1) == 1)
									{
										result = InstructionHelper.Select((b4 & 1) == 1, -0.0, 0.0);
									}
									else
									{
										Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm16);
										Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, ((b4 & 1) != 1) ? Llvm_libc_20_1_2_Sign_POS.Pointer : Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
										long val13 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb16.Val);
										llvm_libc_20_1_2_fputil_FPBits_wjhbrm16.FPRepImpl.FPRepSem.FPStorage.Val = val13;
										result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm16);
										Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm16);
									}
									Llvm_lifetime_end_p0.Invoke(1L, &b4);
								}
								else
								{
									long num39 = num4;
									Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm17);
									Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
									long val14 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb17.Val);
									llvm_libc_20_1_2_fputil_FPBits_wjhbrm17.FPRepImpl.FPRepSem.FPStorage.Val = val14;
									bool num40 = (ulong)num39 > (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm17));
									Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm17);
									if (!num40)
									{
										long num41 = num4;
										Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm18);
										Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
										long val15 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal.Invoke(anon_izyfb18.Val);
										llvm_libc_20_1_2_fputil_FPBits_wjhbrm18.FPRepImpl.FPRepSem.FPStorage.Val = val15;
										bool num42 = (ulong)num41 < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm18));
										Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm18);
										if (num42)
										{
											num6 -= 64.0;
											Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm19);
											FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm19, X * 1.8446744073709552E+19);
											num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm19));
											Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm19);
										}
										if ((b & 1) == 1)
										{
											if (!Anonymous_namespace_is_integer.Invoke(num26))
											{
												Fputil_set_errno_if_required.Invoke(33);
												Fputil_raise_except_if_required.Invoke(1);
												Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm20);
												Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
												long val16 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb19.Val, 0L);
												llvm_libc_20_1_2_fputil_FPBits_wjhbrm20.FPRepImpl.FPRepSem.FPStorage.Val = val16;
												result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm20);
												Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm20);
												goto IL_1cc0;
											}
											if (Anonymous_namespace_is_odd_integer.Invoke(num26))
											{
												num7 = long.MinValue;
											}
										}
										goto IL_0fb4;
									}
									result = X;
								}
							}
						}
					}
					else
					{
						result = (((b2 & 1) != 1) ? X : (1.0 / X));
					}
				}
				else
				{
					bool num43 = X == 0.0;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
					int value2;
					if (num43)
					{
						value2 = 1;
					}
					else
					{
						long num44 = num3;
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
						long val17 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb8.Val);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.Val = val17;
						value2 = ((num44 == FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm8))) ? 1 : 0);
					}
					bool num45 = Details_expects_bool_condition_bool.Invoke((byte)value2 != 0, Expected: false);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm8);
					result = ((!num45) ? (((b2 & 1) != 1) ? Fputil_sqrt_double_double.Invoke(X) : (1.0 / Fputil_sqrt_double_double.Invoke(X))) : (((b2 & 1) != 1) ? (X * X) : (1.0 / (X * X))));
				}
			}
			goto IL_1cc0;
		}
		IL_0fb4:
		Llvm_lifetime_start_p0.Invoke(4L, &num8);
		unchecked
		{
			num8 = (int)(num >>> 45);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm21);
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm21) = -6148914691236517206L;
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm21, num | 0x3FF0000000000000L);
			Llvm_lifetime_start_p0.Invoke(56L, &inlineArray7_Double);
			*(double*)(&inlineArray7_Double) = 1.4426950408889634;
			((double*)(&inlineArray7_Double))[1] = -0.7213475204444791;
			((double*)(&inlineArray7_Double))[2L] = 0.48089834696702144;
			((double*)(&inlineArray7_Double))[3L] = -0.3606737610616915;
			((double*)(&inlineArray7_Double))[4L] = 0.2885388964872653;
			((double*)(&inlineArray7_Double))[5L] = -0.24040302957987383;
			((double*)(&inlineArray7_Double))[6L] = 0.20130817536293322;
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = double.NaN;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_start_p0.Invoke(8L, &num10);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm22);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm22, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm21)) & 0x3FFFE00000000000L);
			double num46 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm22);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm22);
			num10 = num46;
			long num47 = (uint)num8;
			double x4 = ((double*)Llvm_libc_20_1_2_RD.Pointer)[num47];
			double y2 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm21) - num10;
			long num48 = (uint)num8;
			num9 = Fputil_multiply_add_double.Invoke(x4, y2, ((double*)Llvm_libc_20_1_2_CD.Pointer)[num48]);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Struct_4ydhja struct_4ydhja = Fputil_exact_mult_28ul.Invoke(num9, *(double*)(&inlineArray7_Double));
			Llvm_libc_20_1_2_NumberPair* num49 = &llvm_libc_20_1_2_NumberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num49 = struct_4ydhja2.field_0;
			byte* num50 = (byte*)(&llvm_libc_20_1_2_NumberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num50 = struct_4ydhja3.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair2, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = num9 * num9;
			Llvm_lifetime_start_p0.Invoke(8L, &a);
			a = Fputil_multiply_add_double.Invoke(num9, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = Fputil_multiply_add_double.Invoke(num9, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)3 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = Fputil_multiply_add_double.Invoke(num9, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)6 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)5 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = Fputil_polyeval_double_double_double.Invoke(num11, a, a_yc74sk, a_ijazrn);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			double num51 = num6;
			long num52 = (uint)num8;
			Struct_4ydhja struct_4ydhja4 = Fputil_exact_add_true.Invoke(num51 + ((Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_LOG2_R_DD.Pointer)[num52].Hi, llvm_libc_20_1_2_NumberPair.Hi);
			Llvm_libc_20_1_2_NumberPair* num53 = &llvm_libc_20_1_2_NumberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num53 = struct_4ydhja5.field_0;
			byte* num54 = (byte*)(&llvm_libc_20_1_2_NumberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num54 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &b5);
			double x5 = num11;
			double y3 = num12;
			double lo = llvm_libc_20_1_2_NumberPair.Lo;
			long num55 = (uint)num8;
			b5 = Fputil_multiply_add_double.Invoke(x5, y3, lo + ((Llvm_libc_20_1_2_NumberPair*)Llvm_libc_20_1_2_anonymous_namespace_LOG2_R_DD.Pointer)[num55].Lo);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_exact_add_true.Invoke(llvm_libc_20_1_2_NumberPair3.Hi, b5);
			Llvm_libc_20_1_2_NumberPair* num56 = &llvm_libc_20_1_2_NumberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num56 = struct_4ydhja8.field_0;
			byte* num57 = (byte*)(&llvm_libc_20_1_2_NumberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num57 = struct_4ydhja9.field_1;
			double lo2 = llvm_libc_20_1_2_NumberPair3.Lo;
			llvm_libc_20_1_2_NumberPair4.Lo += lo2;
			Llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = num26 * 64.0;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			*(double*)(&llvm_libc_20_1_2_NumberPair5) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair5))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = Fputil_exact_mult_27ul.Invoke(num13, llvm_libc_20_1_2_NumberPair4.Hi);
			Llvm_libc_20_1_2_NumberPair* num58 = &llvm_libc_20_1_2_NumberPair5;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num58 = struct_4ydhja11.field_0;
			byte* num59 = (byte*)(&llvm_libc_20_1_2_NumberPair5) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num59 = struct_4ydhja12.field_1;
			llvm_libc_20_1_2_NumberPair5.Lo = Fputil_multiply_add_double.Invoke(num13, llvm_libc_20_1_2_NumberPair4.Lo, llvm_libc_20_1_2_NumberPair5.Lo);
			Llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = 1.0;
			Llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = 32768.0;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm23);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm24);
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm24, llvm_libc_20_1_2_NumberPair5.Hi);
			long val18 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm24));
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm23.FPRepImpl.FPRepSem.FPStorage.Val = val18;
			bool num60 = Details_expects_bool_condition_bool.Invoke(!(FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm23) < 32768.0), Expected: false);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm24);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm23);
			if (num60)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm25);
				FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm25, llvm_libc_20_1_2_NumberPair5.Hi);
				anon_izyfb20.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm25);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				bool num61 = Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb20.Val, anon_izyfb21.Val);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm25);
				if (num61)
				{
					num14 = 1.3407807929942597E+154;
					llvm_libc_20_1_2_NumberPair5.Hi -= 32768.0;
					if (llvm_libc_20_1_2_NumberPair5.Hi > 32832.0)
					{
						llvm_libc_20_1_2_NumberPair5.Hi = 32832.0;
					}
				}
				else
				{
					num14 = 7.458340731200207E-155;
					llvm_libc_20_1_2_NumberPair5.Hi += 32768.0;
					if (llvm_libc_20_1_2_NumberPair5.Hi < -36096.0)
					{
						llvm_libc_20_1_2_NumberPair5.Hi = -36096.0;
					}
				}
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num16);
			num16 = Fputil_nearest_integer.Invoke(llvm_libc_20_1_2_NumberPair5.Hi);
			Llvm_lifetime_start_p0.Invoke(8L, &num17);
			num17 = llvm_libc_20_1_2_NumberPair5.Hi - num16;
			Llvm_lifetime_start_p0.Invoke(8L, &num18);
			num18 = num17 + llvm_libc_20_1_2_NumberPair5.Lo;
			Llvm_lifetime_start_p0.Invoke(4L, &num19);
			num19 = (int)num16;
			Llvm_lifetime_start_p0.Invoke(4L, &num20);
			num20 = num19 & 0x3F;
			Llvm_lifetime_start_p0.Invoke(8L, &num21);
			num21 = (long)(num19 >> 6) << 52;
			Llvm_lifetime_start_p0.Invoke(8L, &num22);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm26);
			long num62 = (uint)num20;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm26, ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num62].Hi);
			long num63 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm26));
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm26);
			num22 = num63;
			Llvm_lifetime_start_p0.Invoke(8L, &num23);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm27);
			long num64 = (uint)num20;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm27, ((Llvm_libc_20_1_2_fputil_TripleDouble*)Llvm_libc_20_1_2_EXP2_MID1.Pointer)[num64].Mid);
			long num65 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm27));
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm27);
			num23 = num65;
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = checked(num21 + num22) + num7;
			Llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = ((num20 == 0) ? num7 : (checked(num21 + num23) + num7));
			Llvm_lifetime_start_p0.Invoke(8L, &num24);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm28);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm28, x);
			double num66 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm28);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm28);
			num24 = num66;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm29);
			FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm29, x2);
			double num67 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm29);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm29);
			z = num67;
			Llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
			Llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
			*(double*)(&inlineArray6_Double) = 1.0;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = 0.010830424696249145;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 5.864904955050041E-05;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = 2.1173137155942948E-07;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 5.732859533818817E-10;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = 1.241771242191526E-12;
			Llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = num18 * num18;
			Llvm_lifetime_start_p0.Invoke(8L, &a2);
			a2 = Fputil_multiply_add_double.Invoke(num18, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
			a_yc74sk2 = Fputil_multiply_add_double.Invoke(num18, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			y = Fputil_polyeval_double_double_double.Invoke(x3, a2, a_yc74sk2, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))));
			Llvm_lifetime_start_p0.Invoke(8L, &num25);
			num25 = Fputil_multiply_add_double.Invoke(num24 * num18, y, z);
			num25 += num24;
			result = num25 * num14;
			Llvm_lifetime_end_p0.Invoke(8L, &num25);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
			Llvm_lifetime_end_p0.Invoke(8L, &a2);
			Llvm_lifetime_end_p0.Invoke(8L, &x3);
			Llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num24);
			Llvm_lifetime_end_p0.Invoke(8L, &x2);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &num23);
			Llvm_lifetime_end_p0.Invoke(8L, &num22);
			Llvm_lifetime_end_p0.Invoke(8L, &num21);
			Llvm_lifetime_end_p0.Invoke(4L, &num20);
			Llvm_lifetime_end_p0.Invoke(4L, &num19);
			Llvm_lifetime_end_p0.Invoke(8L, &num18);
			Llvm_lifetime_end_p0.Invoke(8L, &num17);
			Llvm_lifetime_end_p0.Invoke(8L, &num16);
			Llvm_lifetime_end_p0.Invoke(8L, &num15);
			Llvm_lifetime_end_p0.Invoke(8L, &num14);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			Llvm_lifetime_end_p0.Invoke(8L, &num13);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Llvm_lifetime_end_p0.Invoke(8L, &b5);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(8L, &num12);
			Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			Llvm_lifetime_end_p0.Invoke(8L, &a);
			Llvm_lifetime_end_p0.Invoke(8L, &num11);
			Llvm_lifetime_end_p0.Invoke(8L, &num10);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(56L, &inlineArray7_Double);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm21);
			Llvm_lifetime_end_p0.Invoke(4L, &num8);
			goto IL_1cc0;
		}
		IL_1cc0:
		Llvm_lifetime_end_p0.Invoke(8L, &num7);
		Llvm_lifetime_end_p0.Invoke(8L, &num6);
		Llvm_lifetime_end_p0.Invoke(8L, &num5);
		Llvm_lifetime_end_p0.Invoke(8L, &num4);
		Llvm_lifetime_end_p0.Invoke(8L, &num3);
		Llvm_lifetime_end_p0.Invoke(8L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm4);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(1L, &b);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		return result;
	}
}
