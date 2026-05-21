using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tanf
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		int num = 0;
		double num2 = 0.0;
		double x2 = 0.0;
		double num3 = 0.0;
		float num4 = 0f;
		float num5 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		cpp_optional_xmxtsi cpp_optional_xmxtsi2 = default(cpp_optional_xmxtsi);
		double xd = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double x3 = 0.0;
		double x4 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = ((FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) >>> 31 != 0) ? ((sbyte)1) : ((sbyte)0));
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) & 0x7FFFFFFF;
			if (details_expects_bool_condition_bool.Invoke((uint)num <= 1036586971u, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = x;
				if (details_expects_bool_condition_bool.Invoke((uint)num < 964689920u, expected: false))
				{
					result = ((!details_expects_bool_condition_bool.Invoke(num == 0, expected: false)) ? ((float)fputil_multiply_add_double.Invoke(num2, 2.980232238769531E-08, num2)) : x);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num2 * num2;
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = fputil_polyeval_double_double_double_double_double.Invoke(x2, 1.0, 0.33333333332780246, 0.1333333388397673, 0.05396654162717383, 0.022079624737833755);
					result = (float)(num2 * num3);
					llvm_lifetime_end_p0.Invoke(8L, &num3);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			else if (details_expects_bool_condition_bool.Invoke(num == 1066016610, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = InstructionHelper.Select((b & 1) == 1, -1f, 1f);
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = 1.8670952f;
				num5 = fputil_multiply_add_float.Invoke(num4, num5, num4 * 6.3329935E-08f);
				result = num5;
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
			}
			else
			{
				if (details_expects_bool_condition_bool.Invoke((uint)num > 1297535828u, expected: false))
				{
					if (details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, expected: false))
					{
						if (num == 2139095040)
						{
							fputil_set_errno_if_required.Invoke(33);
							fputil_raise_except_if_required.Invoke(1);
						}
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb8.val, 0);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = x + FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						goto IL_0524;
					}
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi2);
					sbyte* ptr = (sbyte*)(&cpp_optional_xmxtsi2);
					*(float*)ptr = float.NaN;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = ExceptValues_float_6ul_lookup_odd.Invoke(x_abs: num, sign: (b & 1) == 1, @this: TANF_EXCEPTS.Pointer);
					*(long*)(&cpp_optional_xmxtsi2.storage) = storage;
					int num8;
					if (details_expects_bool_condition_bool.Invoke(optional_float_has_value.Invoke(&cpp_optional_xmxtsi2), expected: false))
					{
						result = *(float*)optional_float_value.Invoke(&cpp_optional_xmxtsi2);
						num8 = 1;
					}
					else
					{
						num8 = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi2);
					switch (num8)
					{
					case 0:
						break;
					default:
						goto IL_0524;
					}
				}
				llvm_lifetime_start_p0.Invoke(8L, &xd);
				xd = x;
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = double.NaN;
				llvm_lifetime_start_p0.Invoke(8L, &x4);
				x4 = double.NaN;
				sincosf_eval.Invoke(xd, num, &num6, &num7, &x3, &x4);
				result = (float)(fputil_multiply_add_double.Invoke(x3, num7, fputil_multiply_add_double.Invoke(x4, num6, num6)) / fputil_multiply_add_double.Invoke(x3, 0.0 - num6, fputil_multiply_add_double.Invoke(x4, num7, num7)));
				llvm_lifetime_end_p0.Invoke(8L, &x4);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &xd);
			}
			goto IL_0524;
		}
		IL_0524:
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(1L, &b);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
