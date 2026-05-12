using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class pow
{
	public unsafe static double Invoke(double x, double y)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		sbyte b2 = 0;
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		double num6 = 0.0;
		long num7 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb14 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm9 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb15 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm10 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb16 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm11 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb17 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm12 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb18 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm13 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb19 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm14 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb20 = default(anon_izyfb7);
		sbyte b3 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm15 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb21 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm16 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb22 = default(anon_izyfb7);
		sbyte b4 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm17 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb23 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm18 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb24 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm19 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb25 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm20 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm21 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb26 = default(anon_izyfb7);
		int num8 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm22 = default(fputil_FPBits_wjhbrm);
		InlineArray7_Double inlineArray7_Double = default(InlineArray7_Double);
		double num9 = 0.0;
		NumberPair numberPair = default(NumberPair);
		NumberPair numberPair2 = default(NumberPair);
		double num10 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double num11 = 0.0;
		NumberPair numberPair3 = default(NumberPair);
		double b5 = 0.0;
		NumberPair numberPair4 = default(NumberPair);
		double num12 = 0.0;
		NumberPair numberPair5 = default(NumberPair);
		double num13 = 0.0;
		double num14 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm23 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm24 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb27 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm25 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb28 = default(anon_izyfb7);
		double num15 = 0.0;
		double num16 = 0.0;
		double num17 = 0.0;
		int num18 = 0;
		int num19 = 0;
		long num20 = 0L;
		long num21 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm26 = default(fputil_FPBits_wjhbrm);
		long num22 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm27 = default(fputil_FPBits_wjhbrm);
		long x2 = 0L;
		long x3 = 0L;
		double num23 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm28 = default(fputil_FPBits_wjhbrm);
		double z = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm29 = default(fputil_FPBits_wjhbrm);
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double x4 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double y2 = 0.0;
		double num24 = 0.0;
		double num25 = y;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		double result;
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, num25);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_NEG.Pointer, 1L, isVolatile: false);
			b = (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb8.val, anon_izyfb9.val) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_NEG.Pointer, 1L, isVolatile: false);
			b2 = (operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb10.val, anon_izyfb11.val) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
			*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
			long val = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
			*(long*)(&fputil_FPBits_wjhbrm5) = -6148914691236517206L;
			long val2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val2;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm5));
			llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = 0L;
			bool num26 = num2 == 0L;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			int value;
			if (num26)
			{
				value = -1;
			}
			else if ((ulong)num5 > 4888456257178775634uL)
			{
				value = -1;
			}
			else
			{
				long num27 = num3;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
				long val3 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb12.val);
				fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val3;
				if (num27 == fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm6)))
				{
					value = -1;
				}
				else
				{
					long num28 = num3;
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
					long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb13.val);
					fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val4;
					if ((ulong)num28 >= (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm7)))
					{
						value = -1;
					}
					else
					{
						long num29 = num3;
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb14, Sign_POS.Pointer, 1L, isVolatile: false);
						long val5 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal_Sign.Invoke(anon_izyfb14.val);
						fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val5;
						value = (((ulong)num29 < (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm8))) ? 1 : 0);
					}
				}
			}
			bool num30 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((byte)value != 0, expected: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
			if (!num30)
			{
				goto IL_0fa1;
			}
			if (num25 == 0.0)
			{
				result = 1.0;
			}
			else
			{
				long num31 = num5;
				if (num31 != 4602678819172646912L)
				{
					if (num31 != 4607182418800017408L)
					{
						if (num31 == 4611686018427387904L)
						{
							result = (((b2 & 1) != 1) ? (x * x) : (1.0 / (x * x)));
						}
						else
						{
							if ((ulong)num5 > 4888456257178775634uL)
							{
								if ((ulong)num5 >= 9218868437227405312uL)
								{
									if (num2 != 0L)
									{
										long num32 = num3;
										llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
										llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb16, Sign_POS.Pointer, 1L, isVolatile: false);
										long val6 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb16.val);
										fputil_FPBits_wjhbrm10.FPRepImpl.FPRepSem.FPStorage.val = val6;
										result = ((num32 != fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm10))) ? num25 : 1.0);
										llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm10);
									}
									else if (fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan_const.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm4)))
									{
										result = x;
									}
									else if (num4 == 4607182418800017408L)
									{
										result = 1.0;
									}
									else if (x == 0.0 && (b2 & 1) == 1)
									{
										fputil_set_errno_if_required_int.Invoke(33);
										fputil_raise_except_if_required_int.Invoke(4);
										llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
										llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb17, Sign_POS.Pointer, 1L, isVolatile: false);
										long val7 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb17.val);
										fputil_FPBits_wjhbrm11.FPRepImpl.FPRepSem.FPStorage.val = val7;
										result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm11);
										llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm11);
									}
									else
									{
										long num33 = num4;
										llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
										llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb18, Sign_POS.Pointer, 1L, isVolatile: false);
										long val8 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb18.val);
										fputil_FPBits_wjhbrm12.FPRepImpl.FPRepSem.FPStorage.val = val8;
										bool condition = (ulong)num33 < (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm12)) == ((b2 & 1) == 1);
										llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
										llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb19, Sign_POS.Pointer, 1L, isVolatile: false);
										long val9 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb19.val);
										fputil_FPBits_wjhbrm13.FPRepImpl.FPRepSem.FPStorage.val = val9;
										result = InstructionHelper.Select(condition, fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm13), 0.0);
										llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm13);
										llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm12);
									}
									goto IL_1c37;
								}
								num25 = InstructionHelper.Select((b2 & 1) == 1, -1.2676506002282294E+30, 1.2676506002282294E+30);
							}
							long num34 = num3;
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm14);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb20, Sign_POS.Pointer, 1L, isVolatile: false);
							long val10 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_one_Sign.Invoke(anon_izyfb20.val);
							fputil_FPBits_wjhbrm14.FPRepImpl.FPRepSem.FPStorage.val = val10;
							bool num35 = num34 == fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm14));
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm14);
							if (num35)
							{
								result = 1.0;
							}
							else if (x == 0.0)
							{
								llvm_lifetime_start_p0.Invoke(1L, &b3);
								b3 = (((b & 1) == 1 && anonymous_namespace_is_odd_integer_double.Invoke(num25)) ? ((sbyte)1) : ((sbyte)0));
								if ((b2 & 1) == 1)
								{
									fputil_set_errno_if_required_int.Invoke(33);
									fputil_raise_except_if_required_int.Invoke(4);
									llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm15);
									llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb21, ((b3 & 1) != 1) ? Sign_POS.Pointer : Sign_NEG.Pointer, 1L, isVolatile: false);
									long val11 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb21.val);
									fputil_FPBits_wjhbrm15.FPRepImpl.FPRepSem.FPStorage.val = val11;
									result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm15);
									llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm15);
								}
								else
								{
									result = InstructionHelper.Select((b3 & 1) == 1, -0.0, 0.0);
								}
								llvm_lifetime_end_p0.Invoke(1L, &b3);
							}
							else
							{
								long num36 = num4;
								llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm16);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb22, Sign_POS.Pointer, 1L, isVolatile: false);
								long val12 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb22.val);
								fputil_FPBits_wjhbrm16.FPRepImpl.FPRepSem.FPStorage.val = val12;
								bool num37 = num36 == fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm16));
								llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm16);
								if (num37)
								{
									llvm_lifetime_start_p0.Invoke(1L, &b4);
									b4 = (((b & 1) == 1 && anonymous_namespace_is_odd_integer_double.Invoke(num25)) ? ((sbyte)1) : ((sbyte)0));
									if ((b2 & 1) == 1)
									{
										result = InstructionHelper.Select((b4 & 1) == 1, -0.0, 0.0);
									}
									else
									{
										llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm17);
										llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb23, ((b4 & 1) != 1) ? Sign_POS.Pointer : Sign_NEG.Pointer, 1L, isVolatile: false);
										long val13 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb23.val);
										fputil_FPBits_wjhbrm17.FPRepImpl.FPRepSem.FPStorage.val = val13;
										result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm17);
										llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm17);
									}
									llvm_lifetime_end_p0.Invoke(1L, &b4);
								}
								else
								{
									long num38 = num4;
									llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm18);
									llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb24, Sign_POS.Pointer, 1L, isVolatile: false);
									long val14 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb24.val);
									fputil_FPBits_wjhbrm18.FPRepImpl.FPRepSem.FPStorage.val = val14;
									bool num39 = (ulong)num38 > (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm18));
									llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm18);
									if (!num39)
									{
										long num40 = num4;
										llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm19);
										llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb25, Sign_POS.Pointer, 1L, isVolatile: false);
										long val15 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_min_normal_Sign.Invoke(anon_izyfb25.val);
										fputil_FPBits_wjhbrm19.FPRepImpl.FPRepSem.FPStorage.val = val15;
										bool num41 = (ulong)num40 < (ulong)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm19));
										llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm19);
										if (num41)
										{
											num6 -= 64.0;
											llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm20);
											fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm20, x * 1.8446744073709552E+19);
											num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm20));
											llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm20);
										}
										if ((b & 1) == 1)
										{
											if (!anonymous_namespace_is_integer_double.Invoke(num25))
											{
												fputil_set_errno_if_required_int.Invoke(33);
												fputil_raise_except_if_required_int.Invoke(1);
												llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm21);
												llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb26, Sign_POS.Pointer, 1L, isVolatile: false);
												long val16 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb26.val, 0L);
												fputil_FPBits_wjhbrm21.FPRepImpl.FPRepSem.FPStorage.val = val16;
												result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm21);
												llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm21);
												goto IL_1c37;
											}
											if (anonymous_namespace_is_odd_integer_double.Invoke(num25))
											{
												num7 = long.MinValue;
											}
										}
										goto IL_0fa1;
									}
									result = x;
								}
							}
						}
					}
					else
					{
						result = (((b2 & 1) != 1) ? x : (1.0 / x));
					}
				}
				else
				{
					bool num42 = x == 0.0;
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					int value2;
					if (num42)
					{
						value2 = -1;
					}
					else
					{
						long num43 = num3;
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb15, Sign_NEG.Pointer, 1L, isVolatile: false);
						long val17 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb15.val);
						fputil_FPBits_wjhbrm9.FPRepImpl.FPRepSem.FPStorage.val = val17;
						value2 = ((num43 == fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm9))) ? 1 : 0);
					}
					bool num44 = bool_details_expects_bool_condition_bool_bool_bool.Invoke((byte)value2 != 0, expected: false);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm9);
					result = ((!num44) ? (((b2 & 1) != 1) ? cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_double_sizeof_double_sizeof_double_double_type_fputil_sqrt_double_double_double.Invoke(x) : (1.0 / cpp_enable_if_cpp_is_floating_point_v_double_cpp_is_floating_point_v_double_sizeof_double_sizeof_double_double_type_fputil_sqrt_double_double_double.Invoke(x))) : (((b2 & 1) != 1) ? (x * x) : (1.0 / (x * x))));
				}
			}
			goto IL_1c37;
		}
		IL_0fa1:
		llvm_lifetime_start_p0.Invoke(4L, &num8);
		unchecked
		{
			num8 = (int)(num >>> 45);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm22);
			*(long*)(&fputil_FPBits_wjhbrm22) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm22, num | 0x3FF0000000000000L);
			llvm_lifetime_start_p0.Invoke(56L, &inlineArray7_Double);
			*(double*)(&inlineArray7_Double) = 1.4426950408889634;
			((double*)(&inlineArray7_Double))[1] = -0.7213475204444791;
			((double*)(&inlineArray7_Double))[2L] = 0.48089834696702144;
			((double*)(&inlineArray7_Double))[3L] = -0.3606737610616915;
			((double*)(&inlineArray7_Double))[4L] = 0.2885388964872653;
			((double*)(&inlineArray7_Double))[5L] = -0.24040302957987383;
			((double*)(&inlineArray7_Double))[6L] = 0.20130817536293322;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = double.NaN;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair);
			*(double*)(&numberPair) = double.NaN;
			((double*)(&numberPair))[1] = double.NaN;
			NumberPair_double_NumberPair.Invoke(&numberPair);
			long num45 = (uint)num8;
			num9 = fputil_multiply_add_double_double_double.Invoke(((double*)RD.Pointer)[num45], fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm22), -1.0);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair2);
			Struct_4ydhja struct_4ydhja = NumberPair_double_fputil_exact_mult_27ul_double_double.Invoke(*(double*)(&inlineArray7_Double), num9);
			NumberPair* num46 = &numberPair2;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num46 = struct_4ydhja2.field_0;
			byte* num47 = (byte*)(&numberPair2) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num47 = struct_4ydhja3.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&numberPair, &numberPair2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair2);
			llvm_lifetime_start_p0.Invoke(8L, &num10);
			num10 = num9 * num9;
			llvm_lifetime_start_p0.Invoke(8L, &a);
			a = fputil_multiply_add_double_double_double.Invoke(num9, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num9, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)3 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num9, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)6 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)5 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &num11);
			num11 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(num10, a, a_yc74sk, a_ijazrn);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair3);
			*(double*)(&numberPair3) = double.NaN;
			((double*)(&numberPair3))[1] = double.NaN;
			double num48 = num6;
			long num49 = (uint)num8;
			Struct_4ydhja struct_4ydhja4 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(num48 + ((NumberPair*)anonymous_namespace_LOG2_R_DD.Pointer)[num49].hi, numberPair.hi);
			NumberPair* num50 = &numberPair3;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num50 = struct_4ydhja5.field_0;
			byte* num51 = (byte*)(&numberPair3) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num51 = struct_4ydhja6.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &b5);
			double x5 = num10;
			double y3 = num11;
			double lo = numberPair.lo;
			long num52 = (uint)num8;
			b5 = fputil_multiply_add_double_double_double.Invoke(x5, y3, lo + ((NumberPair*)anonymous_namespace_LOG2_R_DD.Pointer)[num52].lo);
			llvm_lifetime_start_p0.Invoke(16L, &numberPair4);
			*(double*)(&numberPair4) = double.NaN;
			((double*)(&numberPair4))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = NumberPair_double_fputil_exact_add_true_double_double.Invoke(numberPair3.hi, b5);
			NumberPair* num53 = &numberPair4;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num53 = struct_4ydhja8.field_0;
			byte* num54 = (byte*)(&numberPair4) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num54 = struct_4ydhja9.field_1;
			double lo2 = numberPair3.lo;
			numberPair4.lo += lo2;
			llvm_lifetime_start_p0.Invoke(8L, &num12);
			num12 = num25 * 64.0;
			llvm_lifetime_start_p0.Invoke(16L, &numberPair5);
			*(double*)(&numberPair5) = double.NaN;
			((double*)(&numberPair5))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja10 = NumberPair_double_fputil_exact_mult_27ul_double_double.Invoke(num12, numberPair4.hi);
			NumberPair* num55 = &numberPair5;
			Struct_4ydhja struct_4ydhja11 = struct_4ydhja10;
			*(double*)num55 = struct_4ydhja11.field_0;
			byte* num56 = (byte*)(&numberPair5) + 8u;
			Struct_4ydhja struct_4ydhja12 = struct_4ydhja10;
			*(double*)num56 = struct_4ydhja12.field_1;
			numberPair5.lo = fputil_multiply_add_double_double_double.Invoke(num12, numberPair4.lo, numberPair5.lo);
			llvm_lifetime_start_p0.Invoke(8L, &num13);
			num13 = 1.0;
			llvm_lifetime_start_p0.Invoke(8L, &num14);
			num14 = 32768.0;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm23);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm24);
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm24, numberPair5.hi);
			long val18 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_abs_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm24));
			fputil_FPBits_wjhbrm23.FPRepImpl.FPRepSem.FPStorage.val = val18;
			bool num57 = bool_details_expects_bool_condition_bool_bool_bool.Invoke(!(fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm23) < 32768.0), expected: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm24);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm23);
			if (num57)
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm25);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm25, numberPair5.hi);
				anon_izyfb27.val = fputil_internal_FPStorage_fputil_FPType_2_sign_const.Invoke(&fputil_FPBits_wjhbrm25);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb28, Sign_POS.Pointer, 1L, isVolatile: false);
				bool num58 = operator_Sign_Sign_fy8fvt.Invoke(anon_izyfb27.val, anon_izyfb28.val);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm25);
				if (num58)
				{
					num13 = 1.3407807929942597E+154;
					numberPair5.hi -= 32768.0;
					if (numberPair5.hi > 32832.0)
					{
						numberPair5.hi = 32832.0;
					}
				}
				else
				{
					num13 = 7.458340731200207E-155;
					numberPair5.hi += 32768.0;
					if (numberPair5.hi < -36096.0)
					{
						numberPair5.hi = -36096.0;
					}
				}
			}
			llvm_lifetime_start_p0.Invoke(8L, &num15);
			num15 = fputil_nearest_integer_double.Invoke(numberPair5.hi);
			llvm_lifetime_start_p0.Invoke(8L, &num16);
			num16 = numberPair5.hi - num15;
			llvm_lifetime_start_p0.Invoke(8L, &num17);
			num17 = num16 + numberPair5.lo;
			llvm_lifetime_start_p0.Invoke(4L, &num18);
			num18 = (int)num15;
			llvm_lifetime_start_p0.Invoke(4L, &num19);
			num19 = num18 & 0x3F;
			llvm_lifetime_start_p0.Invoke(8L, &num20);
			num20 = (long)(num18 >> 6) << 52;
			llvm_lifetime_start_p0.Invoke(8L, &num21);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm26);
			long num59 = (uint)num19;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm26, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num59].hi);
			long num60 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm26));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm26);
			num21 = num60;
			llvm_lifetime_start_p0.Invoke(8L, &num22);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm27);
			long num61 = (uint)num19;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm27, ((fputil_TripleDouble*)EXP2_MID1.Pointer)[num61].mid);
			long num62 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm27));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm27);
			num22 = num62;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = checked(num20 + num21) + num7;
			llvm_lifetime_start_p0.Invoke(8L, &x3);
			x3 = ((num19 == 0) ? num7 : (checked(num20 + num22) + num7));
			llvm_lifetime_start_p0.Invoke(8L, &num23);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm28);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm28, x2);
			double num63 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm28);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm28);
			num23 = num63;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm29);
			fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm29, x3);
			double num64 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm29);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm29);
			z = num64;
			llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
			llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
			*(double*)(&inlineArray6_Double) = 1.0;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = 0.010830424696249145;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = 5.864904955050041E-05;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = 2.1173137155942948E-07;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = 5.732859533818817E-10;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = 1.241771242191526E-12;
			llvm_lifetime_start_p0.Invoke(8L, &x4);
			x4 = num17 * num17;
			llvm_lifetime_start_p0.Invoke(8L, &a2);
			a2 = fputil_multiply_add_double_double_double.Invoke(num17, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
			a_yc74sk2 = fputil_multiply_add_double_double_double.Invoke(num17, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &y2);
			y2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x4, a2, a_yc74sk2, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &num24);
			num24 = fputil_multiply_add_double_double_double.Invoke(num23 * num17, y2, z);
			num24 += num23;
			result = num24 * num13;
			llvm_lifetime_end_p0.Invoke(8L, &num24);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
			llvm_lifetime_end_p0.Invoke(8L, &a2);
			llvm_lifetime_end_p0.Invoke(8L, &x4);
			llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num23);
			llvm_lifetime_end_p0.Invoke(8L, &x3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &num22);
			llvm_lifetime_end_p0.Invoke(8L, &num21);
			llvm_lifetime_end_p0.Invoke(8L, &num20);
			llvm_lifetime_end_p0.Invoke(4L, &num19);
			llvm_lifetime_end_p0.Invoke(4L, &num18);
			llvm_lifetime_end_p0.Invoke(8L, &num17);
			llvm_lifetime_end_p0.Invoke(8L, &num16);
			llvm_lifetime_end_p0.Invoke(8L, &num15);
			llvm_lifetime_end_p0.Invoke(8L, &num14);
			llvm_lifetime_end_p0.Invoke(8L, &num13);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair5);
			llvm_lifetime_end_p0.Invoke(8L, &num12);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair4);
			llvm_lifetime_end_p0.Invoke(8L, &b5);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair3);
			llvm_lifetime_end_p0.Invoke(8L, &num11);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &a);
			llvm_lifetime_end_p0.Invoke(8L, &num10);
			llvm_lifetime_end_p0.Invoke(16L, &numberPair);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(56L, &inlineArray7_Double);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm22);
			llvm_lifetime_end_p0.Invoke(4L, &num8);
			goto IL_1c37;
		}
		IL_1c37:
		llvm_lifetime_end_p0.Invoke(8L, &num7);
		llvm_lifetime_end_p0.Invoke(8L, &num6);
		llvm_lifetime_end_p0.Invoke(8L, &num5);
		llvm_lifetime_end_p0.Invoke(8L, &num4);
		llvm_lifetime_end_p0.Invoke(8L, &num3);
		llvm_lifetime_end_p0.Invoke(8L, &num2);
		llvm_lifetime_end_p0.Invoke(8L, &num);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
		llvm_lifetime_end_p0.Invoke(1L, &b2);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
		llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		return result;
	}
}
