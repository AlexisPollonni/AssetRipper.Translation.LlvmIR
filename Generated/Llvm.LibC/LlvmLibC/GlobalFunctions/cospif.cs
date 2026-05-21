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
		double num2 = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num3 = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		double x2 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb8.val);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
			float result;
			if (details_expects_bool_condition_bool.Invoke((uint)num < 950204804u, expected: false))
			{
				result = (float)fputil_multiply_add_double.Invoke(num2, -2.980232238769531E-08, 1.0);
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)num >= 1258291200u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((uint)num < 1266679808u, expected: false))
				{
					result = InstructionHelper.Select((num & 1) != 0, -1f, 1f);
				}
				else if (details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, expected: false))
				{
					if (num == 2139095040)
					{
						fputil_set_errno_if_required.Invoke(33);
						fputil_raise_except_if_required.Invoke(1);
					}
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb9.val, 0);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = x + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				}
				else
				{
					result = 1f;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = double.NaN;
				sincospif_eval.Invoke(num2, &num3, &num4, &num5, &x2);
				result = ((!details_expects_bool_condition_bool.Invoke(num5 == 0.0 && num4 == 0.0, expected: false)) ? ((float)fputil_multiply_add_double.Invoke(num5, 0.0 - num3, fputil_multiply_add_double.Invoke(x2, num4, num4))) : 0f);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
