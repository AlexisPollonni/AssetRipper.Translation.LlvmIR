using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class acosf
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		cpp_optional_xmxtsi cpp_optional_xmxtsi2 = default(cpp_optional_xmxtsi);
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double y = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double y2 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double y3 = 0.0;
		double num10 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = num >>> 31;
			if (details_expects_bool_condition_bool.Invoke((uint)num2 <= 1056964608u, expected: false))
			{
				if (details_expects_bool_condition_bool.Invoke((uint)num2 < 981467136u, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi2);
					sbyte* ptr = (sbyte*)(&cpp_optional_xmxtsi2);
					*(float*)ptr = float.NaN;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = ExceptValues_float_4ul_lookup.Invoke(x_bits: num, @this: ACOSF_EXCEPTS.Pointer);
					*(long*)(&cpp_optional_xmxtsi2.storage) = storage;
					int num11;
					if (details_expects_bool_condition_bool.Invoke(optional_float_has_value.Invoke(&cpp_optional_xmxtsi2), expected: false))
					{
						result = *(float*)optional_float_value.Invoke(&cpp_optional_xmxtsi2);
						num11 = 1;
					}
					else
					{
						num11 = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi2);
					switch (num11)
					{
					case 0:
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = x;
						result = (float)fputil_multiply_add_double.Invoke(-1.0 / 6.0 * num4, num4 * num4, Math.PI / 2.0 - num4);
						llvm_lifetime_end_p0.Invoke(8L, &num4);
						break;
					}
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = x;
					llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = num5 * num5;
					llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = num5 * num6;
					llvm_lifetime_start_p0.Invoke(8L, &y);
					y = asin_eval_r9zbfk.Invoke(num6);
					result = (float)fputil_multiply_add_double.Invoke(0.0 - num7, y, Math.PI / 2.0 - num5);
					llvm_lifetime_end_p0.Invoke(8L, &y);
					llvm_lifetime_end_p0.Invoke(8L, &num7);
					llvm_lifetime_end_p0.Invoke(8L, &num6);
					llvm_lifetime_end_p0.Invoke(8L, &num5);
				}
			}
			else if (details_expects_bool_condition_bool.Invoke((uint)num2 >= 1065353216u, expected: false))
			{
				if (num2 == 1065353216)
				{
					result = ((num3 == 0) ? 0f : fputil_round_result_slightly_down_float.Invoke((float)Math.PI));
				}
				else
				{
					if ((uint)num2 <= 2139095040u)
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
				}
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb9.val);
				llvm_lifetime_start_p0.Invoke(8L, &y2);
				y2 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = fputil_multiply_add_double.Invoke(-0.5, y2, 0.5);
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = 2.0 * fputil_sqrt_double_double.Invoke(num8);
				llvm_lifetime_start_p0.Invoke(8L, &y3);
				y3 = asin_eval_r9zbfk.Invoke(num8);
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = fputil_multiply_add_double.Invoke(num9 * num8, y3, num9);
				result = (float)((num3 == 0) ? num10 : (Math.PI - num10));
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &y3);
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(8L, &y2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
