using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Acosf
{
	[MangledName("acosf")]
	[DemangledName("acosf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		float result = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		Cpp_optional_xmxtsi cpp_optional_xmxtsi = default(Cpp_optional_xmxtsi);
		double num4 = 0.0;
		double num5 = 0.0;
		double num6 = 0.0;
		double num7 = 0.0;
		double y = 0.0;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		double y2 = 0.0;
		double num8 = 0.0;
		double num9 = 0.0;
		double y3 = 0.0;
		double num10 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs)) & 0x7FFFFFFF;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = num >>> 31;
			if (Details_expects_bool_condition_bool.Invoke((uint)num2 <= 1056964608u, Expected: false))
			{
				if (Details_expects_bool_condition_bool.Invoke((uint)num2 < 981467136u, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi);
					sbyte* ptr = (sbyte*)(&cpp_optional_xmxtsi);
					*(float*)ptr = float.NaN;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = ExceptValues_float_4ul_lookup.Invoke(X_bits: num, This: ACOSF_EXCEPTS.Pointer);
					*(long*)(&cpp_optional_xmxtsi.Storage) = storage;
					int num11;
					if (Details_expects_bool_condition_bool.Invoke(Optional_float_has_value.Invoke(&cpp_optional_xmxtsi), Expected: false))
					{
						result = *(float*)Optional_float_value.Invoke(&cpp_optional_xmxtsi);
						num11 = 1;
					}
					else
					{
						num11 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi);
					switch (num11)
					{
					case 0:
						Llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = X;
						result = (float)Fputil_multiply_add_double.Invoke(-1.0 / 6.0 * num4, num4 * num4, Math.PI / 2.0 - num4);
						Llvm_lifetime_end_p0.Invoke(8L, &num4);
						break;
					}
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = X;
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = num5 * num5;
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = num5 * num6;
					Llvm_lifetime_start_p0.Invoke(8L, &y);
					y = Asin_eval_r9zbfk.Invoke(num6);
					result = (float)Fputil_multiply_add_double.Invoke(0.0 - num7, y, Math.PI / 2.0 - num5);
					Llvm_lifetime_end_p0.Invoke(8L, &y);
					Llvm_lifetime_end_p0.Invoke(8L, &num7);
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
					Llvm_lifetime_end_p0.Invoke(8L, &num5);
				}
			}
			else if (Details_expects_bool_condition_bool.Invoke((uint)num2 >= 1065353216u, Expected: false))
			{
				if (num2 == 1065353216)
				{
					result = ((num3 == 0) ? 0f : Fputil_round_result_slightly_down_float.Invoke((float)Math.PI));
				}
				else
				{
					if ((uint)num2 <= 2139095040u)
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
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs, anon_izyfb2.Val);
				Llvm_lifetime_start_p0.Invoke(8L, &y2);
				y2 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = Fputil_multiply_add_double.Invoke(-0.5, y2, 0.5);
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = 2.0 * Fputil_sqrt_double_double.Invoke(num8);
				Llvm_lifetime_start_p0.Invoke(8L, &y3);
				y3 = Asin_eval_r9zbfk.Invoke(num8);
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = Fputil_multiply_add_double.Invoke(num9 * num8, y3, num9);
				result = (float)((num3 == 0) ? num10 : (Math.PI - num10));
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &y3);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &y2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
