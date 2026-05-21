using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cosf
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		double num2 = 0.0;
		cpp_optional_xmxtsi cpp_optional_xmxtsi2 = default(cpp_optional_xmxtsi);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num3 = 0.0;
		double num4 = 0.0;
		double x2 = 0.0;
		double x3 = 0.0;
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
			if (details_expects_bool_condition_bool.Invoke((uint)num < 964689920u, expected: false))
			{
				result = (float)fputil_multiply_add_double.Invoke(num2, -2.980232238769531E-08, 1.0);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_xmxtsi2);
				sbyte* ptr = (sbyte*)(&cpp_optional_xmxtsi2);
				*(float*)ptr = float.NaN;
				ptr[4] = -86;
				sbyte* ptr2 = ptr + 5;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				long storage = ExceptValues_float_6ul_lookup.Invoke(x_bits: num, @this: COSF_EXCEPTS.Pointer);
				*(long*)(&cpp_optional_xmxtsi2.storage) = storage;
				int num5;
				if (details_expects_bool_condition_bool.Invoke(optional_float_has_value.Invoke(&cpp_optional_xmxtsi2), expected: false))
				{
					result = *(float*)optional_float_value.Invoke(&cpp_optional_xmxtsi2);
					num5 = 1;
				}
				else
				{
					num5 = 0;
				}
				llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_xmxtsi2);
				switch (num5)
				{
				case 0:
					if (details_expects_bool_condition_bool.Invoke((uint)num >= 2139095040u, expected: false))
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
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = double.NaN;
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = double.NaN;
						llvm_lifetime_start_p0.Invoke(8L, &x2);
						x2 = double.NaN;
						llvm_lifetime_start_p0.Invoke(8L, &x3);
						x3 = double.NaN;
						sincosf_eval.Invoke(num2, num, &num3, &num4, &x2, &x3);
						result = (float)fputil_multiply_add_double.Invoke(x2, 0.0 - num3, fputil_multiply_add_double.Invoke(x3, num4, num4));
						llvm_lifetime_end_p0.Invoke(8L, &x3);
						llvm_lifetime_end_p0.Invoke(8L, &x2);
						llvm_lifetime_end_p0.Invoke(8L, &num4);
						llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					break;
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
