using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Sinf
{
	[MangledName("sinf")]
	[DemangledName("sinf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		double x = 0.0;
		double num4 = 0.0;
		float num5 = 0f;
		int num6 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		double num7 = 0.0;
		double y = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = X;
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num2 <= 1044975579u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num2 < 971544425u, Expected: false))
				{
					result = ((!Details_expects_bool_condition_bool.Invoke(num2 == 0, Expected: false)) ? ((float)Fputil_multiply_add_double.Invoke(num3, -2.980232238769531E-08, num3)) : X);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num3 * num3;
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = Fputil_polyeval_double_double_double_double_double.Invoke(x, 1.0, -0.1666666666666627, 0.008333333332344492, -0.00019841262154916348, 2.7533705626961157E-06);
					result = (float)(num3 * num4);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke(num2 == 1176082840, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = -0.34761325f;
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = Fputil_quick_get_round.Invoke();
				if ((num6 == 1024 && FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))) || (num6 == 2048 && FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))))
				{
					num5 = -0.34761328f;
				}
				result = ((!FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs))) ? num5 : (0f - num5));
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				Llvm_lifetime_end_p0.Invoke(4L, &num5);
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num2 >= 2139095040u, Expected: false))
			{
				if (num2 == 2139095040)
				{
					Fputil_set_errno_if_required.Invoke(33);
					Fputil_raise_except_if_required.Invoke(1);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb.Val, 0);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = X + FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &y);
				y = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = double.NaN;
				Llvm_libc_20_1_2_sincosf_eval.Invoke(num3, num2, &num7, &y, &x2, &x3);
				result = (float)Fputil_multiply_add_double.Invoke(x2, y, Fputil_multiply_add_double.Invoke(x3, num7, num7));
				Llvm_lifetime_end_p0.Invoke(8L, &x3);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(8L, &y);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
