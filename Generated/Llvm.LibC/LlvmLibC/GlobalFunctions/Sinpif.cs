using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sinpif
{
	[MangledName("sinpif")]
	[DemangledName("sinpif")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		double num4 = 0.0;
		double x = 0.0;
		double num5 = 0.0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double num6 = 0.0;
		double y = 0.0;
		double num7 = 0.0;
		double x2 = 0.0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = X;
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num2 <= 1031798784u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num2 < 869073367u, Expected: false))
				{
					if (Details_expects_bool_condition_bool.Invoke(num2 == 0, Expected: false))
					{
						result = X;
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = num3 * Math.PI;
						result = (float)num4;
						Llvm_lifetime_end_p0.Invoke(8L, &num4);
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num3 * num3;
					Llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = Fputil_polyeval_double_double_double_double_double.Invoke(x, Math.PI, -5.167712780049429, 2.55016403919051, -0.5992641661056299, 0.0820605914557699);
					result = (float)(num3 * num5);
					Llvm_lifetime_end_p0.Invoke(8L, &num5);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num2 >= 1258291200u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num2 >= 2139095040u, Expected: false))
				{
					if (num2 == 2139095040)
					{
						Fputil_set_errno_if_required.Invoke(33);
						Fputil_raise_except_if_required.Invoke(1);
					}
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = X + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb2.Val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				y = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = double.NaN;
				Sincospif_eval.Invoke(num3, &num6, &y, &num7, &x2);
				if (Details_expects_bool_condition_bool.Invoke(num7 == 0.0 && num6 == 0.0, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					anon_izyfb3.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_zero.Invoke(anon_izyfb3.Val);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
				else
				{
					result = (float)Fputil_multiply_add_double.Invoke(num7, y, Fputil_multiply_add_double.Invoke(x2, num6, num6));
				}
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
