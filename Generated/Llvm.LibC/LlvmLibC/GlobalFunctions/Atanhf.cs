using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Atanhf
{
	[MangledName("atanhf")]
	[DemangledName("atanhf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		double num2 = 0.0;
		double x = 0.0;
		double y = 0.0;
		double num3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			anon_izyfb.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num4 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			num = num4;
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num >= 1065353216u, Expected: false))
			{
				if (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&fputil_FPBits_5nkvcs))
				{
					result = X;
				}
				else if (num == 1065353216)
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &anon_izyfb, 1L, isVolatile: false);
					int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb2.Val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb3.Val, 0);
					fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num <= 1036779520u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num <= 847249408u, Expected: false))
				{
					result = (float)((!Details_expects_bool_condition_bool.Invoke(num == 0, Expected: false)) ? Llvm_fmuladd_f64.Invoke(1.0 / 3.0 * (double)X * (double)X, X, X) : ((double)X));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = X;
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num2 * num2;
					Llvm_lifetime_start_p0.Invoke(8L, &y);
					y = Fputil_polyeval_double_double_double_double_double_double.Invoke(x, 0.0, 1.0 / 3.0, 0.2, 1.0 / 7.0, 1.0 / 9.0, 1.0 / 11.0);
					result = (float)Fputil_multiply_add_double.Invoke(num2, y, num2);
					Llvm_lifetime_end_p0.Invoke(8L, &y);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = X;
				result = (float)(0.5 * Log_eval_c36zya.Invoke((num3 + 1.0) / (num3 - 1.0)));
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
