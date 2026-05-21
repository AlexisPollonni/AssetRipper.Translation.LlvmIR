using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sinhf
{
	[MangledName("sinhf")]
	[DemangledName("sinhf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		double num2 = 0.0;
		double x = 0.0;
		double y = 0.0;
		int num3 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs4 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs5 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float result;
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			num = num4;
			if (Details_expects_bool_condition_bool.Invoke(((uint)num < 1119092736u) ? ((uint)num <= 1033895936u) : true, Expected: false))
			{
				if ((uint)num <= 1033895936u)
				{
					if (Details_expects_bool_condition_bool.Invoke(num == 974292479, Expected: false) && Fputil_fenv_is_round_to_nearest.Invoke())
					{
						result = X;
					}
					else if (Details_expects_bool_condition_bool.Invoke((uint)num <= 847249408u, Expected: false))
					{
						result = (float)((!Details_expects_bool_condition_bool.Invoke(num == 0, Expected: false)) ? Llvm_fmuladd_f64.Invoke(0.25 * (double)X * (double)X, X, X) : ((double)X));
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num2);
						num2 = X;
						Llvm_lifetime_start_p0.Invoke(8L, &x);
						x = num2 * num2;
						Llvm_lifetime_start_p0.Invoke(8L, &y);
						y = Fputil_polyeval_double_double_double_double.Invoke(x, 0.0, 0.16666666666678162, 0.00833333321902746, 0.00019844500753408458);
						result = (float)Fputil_multiply_add_double.Invoke(num2, y, num2);
						Llvm_lifetime_end_p0.Invoke(8L, &y);
						Llvm_lifetime_end_p0.Invoke(8L, &x);
						Llvm_lifetime_end_p0.Invoke(8L, &num2);
					}
				}
				else if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
				{
					result = X + 1f;
				}
				else
				{
					if (!FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))
					{
						Llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = Fputil_quick_get_round.Invoke();
						if (FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)))
						{
							if (!Details_expects_bool_condition_bool.Invoke((num3 != 2048) ? (num3 == 3072) : true, Expected: false))
							{
								goto IL_03bd;
							}
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb.Val);
							llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
							result = 0f - FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
						}
						else
						{
							if (!Details_expects_bool_condition_bool.Invoke((num3 != 1024) ? (num3 == 3072) : true, Expected: false))
							{
								goto IL_03bd;
							}
							Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
							Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
							int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal.Invoke(anon_izyfb2.Val);
							llvm_libc_20_1_2_fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
							result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
							Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs4);
						}
						goto IL_0430;
					}
					result = X;
				}
			}
			else
			{
				result = (float)Llvm_libc_20_1_2_exp_pm_eval_true.Invoke(X);
			}
			goto IL_044d;
		}
		IL_0430:
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		goto IL_044d;
		IL_044d:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
		IL_03bd:
		Fputil_set_errno_if_required.Invoke(34);
		Fputil_raise_except_if_required.Invoke(8);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
		anon_izyfb3.Val = FPStorage_fputil_FPType_1_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int field_4 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb3.Val);
		llvm_libc_20_1_2_fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_4;
		result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs5);
		goto IL_0430;
	}
}
