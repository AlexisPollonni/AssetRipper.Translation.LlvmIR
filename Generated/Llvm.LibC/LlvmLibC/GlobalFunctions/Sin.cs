using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sin
{
	[MangledName("sin")]
	[DemangledName("sin")]
	public unsafe static double Invoke([MangledName("x")] double X)
	{
		double result = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		short num = 0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair = default(Llvm_libc_20_1_2_NumberPair);
		int num2 = 0;
		Llvm_libc_20_1_2_LargeRangeReduction llvm_libc_20_1_2_LargeRangeReduction = default(Llvm_libc_20_1_2_LargeRangeReduction);
		int num3 = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb4 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb5 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair2 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair3 = default(Llvm_libc_20_1_2_NumberPair);
		double num4 = 0.0;
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair4 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair5 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair6 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair7 = default(Llvm_libc_20_1_2_NumberPair);
		Llvm_libc_20_1_2_NumberPair llvm_libc_20_1_2_NumberPair8 = default(Llvm_libc_20_1_2_NumberPair);
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Anon_izyfb7 anon_izyfb6 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10 = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		int num9;
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
			*(double*)(&llvm_libc_20_1_2_NumberPair) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair);
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = -1431655766;
			Llvm_lifetime_start_p0.Invoke(48L, &llvm_libc_20_1_2_LargeRangeReduction);
			*(int*)(&llvm_libc_20_1_2_LargeRangeReduction) = -1431655766;
			sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_LargeRangeReduction) + 4;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((double*)(&llvm_libc_20_1_2_LargeRangeReduction))[1] = double.NaN;
			((double*)(&llvm_libc_20_1_2_LargeRangeReduction))[2] = double.NaN;
			((double*)(&llvm_libc_20_1_2_LargeRangeReduction))[3] = double.NaN;
			sbyte* ptr2 = (sbyte*)(&llvm_libc_20_1_2_LargeRangeReduction) + 32;
			*(double*)ptr2 = double.NaN;
			((double*)ptr2)[1] = double.NaN;
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_LargeRangeReduction, 0, 48L, isVolatile: false);
			LargeRangeReduction_Constructor.Invoke(&llvm_libc_20_1_2_LargeRangeReduction);
			if (Details_expects_bool_condition_bool.Invoke((ushort)num < 1039, Expected: true))
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)num < 1016, Expected: false))
				{
					if (Details_expects_bool_condition_bool.Invoke((ushort)num < 997, Expected: false))
					{
						if (Details_expects_bool_condition_bool.Invoke(X == 0.0, Expected: false))
						{
							result = X + X;
							goto IL_0cd2;
						}
						if (!Details_expects_bool_condition_bool.Invoke((ushort)num < 4, Expected: false))
						{
							goto IL_0415;
						}
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = Fputil_quick_get_round.Invoke();
						if (num3 != 3072)
						{
							anon_izyfb.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							if (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb.Val, anon_izyfb2.Val) || num3 != 1024)
							{
								anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
								Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb4, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
								if (!Llvm_libc_20_1_2_Equals_fy8fvt.Invoke(anon_izyfb3.Val, anon_izyfb4.Val) || num3 != 2048)
								{
									num9 = 0;
									goto IL_03f3;
								}
							}
						}
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
						FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) - 1L);
						result = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
						num9 = 1;
						goto IL_03f3;
					}
					num2 = 0;
					llvm_libc_20_1_2_NumberPair.Lo = 0.0;
					llvm_libc_20_1_2_NumberPair.Hi = X;
				}
				else
				{
					num2 = Llvm_libc_20_1_2_range_reduction_small.Invoke(X, &llvm_libc_20_1_2_NumberPair);
				}
			}
			else
			{
				if (Details_expects_bool_condition_bool.Invoke((ushort)num > 2046, Expected: false))
				{
					if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) == 0L)
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb5, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(anon_izyfb5.Val, 0L);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val;
					result = X + FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
					goto IL_0cd2;
				}
				num2 = LargeRangeReduction_fast.Invoke(&llvm_libc_20_1_2_LargeRangeReduction, X, &llvm_libc_20_1_2_NumberPair);
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			*(double*)(&llvm_libc_20_1_2_NumberPair2) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair2))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair2);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			*(double*)(&llvm_libc_20_1_2_NumberPair3) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair3))[1] = double.NaN;
			NumberPair_double_Constructor.Invoke(&llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = Generic_sincos_eval.Invoke(&llvm_libc_20_1_2_NumberPair, &llvm_libc_20_1_2_NumberPair2, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			*(double*)(&llvm_libc_20_1_2_NumberPair4) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair4))[1] = double.NaN;
			long num10 = (uint)(num2 & 0xFF);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair4, (byte*)Llvm_libc_20_1_2_SIN_K_PI_OVER_128.Pointer + (nint)num10 * sizeof(Llvm_libc_20_1_2_NumberPair), 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			*(double*)(&llvm_libc_20_1_2_NumberPair5) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair5))[1] = double.NaN;
			long num11 = (uint)((num2 + 64) & 0xFF);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_NumberPair5, (byte*)Llvm_libc_20_1_2_SIN_K_PI_OVER_128.Pointer + (nint)num11 * sizeof(Llvm_libc_20_1_2_NumberPair), 16L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			*(double*)(&llvm_libc_20_1_2_NumberPair6) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair6))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja = Fputil_quick_mult_27ul.Invoke(&llvm_libc_20_1_2_NumberPair3, &llvm_libc_20_1_2_NumberPair4);
			Llvm_libc_20_1_2_NumberPair* num12 = &llvm_libc_20_1_2_NumberPair6;
			Struct_4ydhja struct_4ydhja2 = struct_4ydhja;
			*(double*)num12 = struct_4ydhja2.field_0;
			byte* num13 = (byte*)(&llvm_libc_20_1_2_NumberPair6) + 8u;
			Struct_4ydhja struct_4ydhja3 = struct_4ydhja;
			*(double*)num13 = struct_4ydhja3.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			*(double*)(&llvm_libc_20_1_2_NumberPair7) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair7))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja4 = Fputil_quick_mult_27ul.Invoke(&llvm_libc_20_1_2_NumberPair2, &llvm_libc_20_1_2_NumberPair5);
			Llvm_libc_20_1_2_NumberPair* num14 = &llvm_libc_20_1_2_NumberPair7;
			Struct_4ydhja struct_4ydhja5 = struct_4ydhja4;
			*(double*)num14 = struct_4ydhja5.field_0;
			byte* num15 = (byte*)(&llvm_libc_20_1_2_NumberPair7) + 8u;
			Struct_4ydhja struct_4ydhja6 = struct_4ydhja4;
			*(double*)num15 = struct_4ydhja6.field_1;
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair8);
			*(double*)(&llvm_libc_20_1_2_NumberPair8) = double.NaN;
			((double*)(&llvm_libc_20_1_2_NumberPair8))[1] = double.NaN;
			Struct_4ydhja struct_4ydhja7 = Fputil_exact_add_false.Invoke(llvm_libc_20_1_2_NumberPair6.Hi, llvm_libc_20_1_2_NumberPair7.Hi);
			Llvm_libc_20_1_2_NumberPair* num16 = &llvm_libc_20_1_2_NumberPair8;
			Struct_4ydhja struct_4ydhja8 = struct_4ydhja7;
			*(double*)num16 = struct_4ydhja8.field_0;
			byte* num17 = (byte*)(&llvm_libc_20_1_2_NumberPair8) + 8u;
			Struct_4ydhja struct_4ydhja9 = struct_4ydhja7;
			*(double*)num17 = struct_4ydhja9.field_1;
			double num18 = llvm_libc_20_1_2_NumberPair6.Lo + llvm_libc_20_1_2_NumberPair7.Lo;
			llvm_libc_20_1_2_NumberPair8.Lo += num18;
			Llvm_lifetime_start_p0.Invoke(8L, &num5);
			num5 = llvm_libc_20_1_2_NumberPair8.Lo + num4;
			Llvm_lifetime_start_p0.Invoke(8L, &num6);
			num6 = llvm_libc_20_1_2_NumberPair8.Lo - num4;
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = llvm_libc_20_1_2_NumberPair8.Hi + num5;
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = llvm_libc_20_1_2_NumberPair8.Hi + num6;
			if (Details_expects_bool_condition_bool.Invoke(num7 == num8, Expected: true))
			{
				result = num7;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) = -86;
				sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 1;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd))[1] = -1431655766;
				sbyte* ptr4 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd) + 8;
				*(long*)ptr4 = -6148914691236517206L;
				((long*)ptr4)[1] = -6148914691236517206L;
				DyadicFloat_128ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2) = -86;
				sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2) + 1;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2))[1] = -1431655766;
				sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2) + 8;
				*(long*)ptr6 = -6148914691236517206L;
				((long*)ptr6)[1] = -6148914691236517206L;
				DyadicFloat_128ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3) = -86;
				sbyte* ptr7 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3) + 1;
				*ptr7 = -86;
				ptr7[1] = -86;
				ptr7[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3))[1] = -1431655766;
				sbyte* ptr8 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3) + 8;
				*(long*)ptr8 = -6148914691236517206L;
				((long*)ptr8)[1] = -6148914691236517206L;
				DyadicFloat_128ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
				if (Details_expects_bool_condition_bool.Invoke((ushort)num < 1039, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
					Llvm_libc_20_1_2_range_reduction_small_f128_qk37py.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, X);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4, 24L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5);
					LargeRangeReduction_accurate.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, &llvm_libc_20_1_2_LargeRangeReduction);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5, 24L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd5);
				}
				Generic_sincos_eval.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb6);
				*(sbyte*)(&anon_izyfb6) = -86;
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) = -86;
				sbyte* ptr9 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) + 1;
				*ptr9 = -86;
				ptr9[1] = -86;
				ptr9[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6))[1] = -1431655766;
				sbyte* ptr10 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6) + 8;
				*(long*)ptr10 = -6148914691236517206L;
				((long*)ptr10)[1] = -6148914691236517206L;
				_0_Invoke_9jj3hx.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, &anon_izyfb6, num2);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) = -86;
				sbyte* ptr11 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) + 1;
				*ptr11 = -86;
				ptr11[1] = -86;
				ptr11[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7))[1] = -1431655766;
				sbyte* ptr12 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7) + 8;
				*(long*)ptr12 = -6148914691236517206L;
				((long*)ptr12)[1] = -6148914691236517206L;
				_0_Invoke_9jj3hx.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &anon_izyfb6, num2 + 64);
				Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8) = -86;
				sbyte* ptr13 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8) + 1;
				*ptr13 = -86;
				ptr13[1] = -86;
				ptr13[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8))[1] = -1431655766;
				sbyte* ptr14 = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8) + 8;
				*(long*)ptr14 = -6148914691236517206L;
				((long*)ptr14)[1] = -6148914691236517206L;
				Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
				Fputil_quick_mul_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
				Fputil_quick_add_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd9, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd10);
				result = DyadicFloat_128ul_Double_double_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd8);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd7);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd6);
				Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb6);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd3);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd2);
				Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair8);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair7);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair6);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair5);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair4);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair3);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair2);
			goto IL_0cd2;
		}
		IL_03f3:
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		switch (num9)
		{
		case 0:
			break;
		default:
			goto IL_0cd2;
		}
		goto IL_0415;
		IL_0cd2:
		Llvm_lifetime_end_p0.Invoke(48L, &llvm_libc_20_1_2_LargeRangeReduction);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_NumberPair);
		Llvm_lifetime_end_p0.Invoke(2L, &num);
		Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		return result;
		IL_0415:
		result = Fputil_multiply_add_double.Invoke(X, -5.551115123125783E-17, X);
		goto IL_0cd2;
	}
}
