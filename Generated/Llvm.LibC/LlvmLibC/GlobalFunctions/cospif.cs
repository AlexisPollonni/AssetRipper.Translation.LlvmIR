using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cospif
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		double xd = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num2 = 0.0;
		double num3 = 0.0;
		double num4 = 0.0;
		double x2 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb8.val);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(8L, &xd);
			xd = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num < 950204804u, expected: false))
			{
				result = fputil_multiply_add_float_float_float.Invoke(fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2), -2.9802322E-08f, 1f);
			}
			else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num >= 1258291200u, expected: false))
			{
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num < 1266679808u, expected: false))
				{
					result = InstructionHelper.Select((num & 1) != 0, -1f, 1f);
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num >= 2139095040u, expected: false))
				{
					if (num == 2139095040)
					{
						fputil_set_errno_if_required_int.Invoke(33);
						fputil_raise_except_if_required_int.Invoke(1);
					}
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(anon_izyfb9.val, 0);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					result = 1f;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = double.NaN;
				sincospif_eval_double_double_double_double_double.Invoke(xd, &num2, &num3, &num4, &x2);
				result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(num4 == 0.0 && num3 == 0.0, expected: false)) ? ((float)fputil_multiply_add_double_double_double.Invoke(num4, 0.0 - num2, fputil_multiply_add_double_double_double.Invoke(x2, num3, num3))) : 0f);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &xd);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
