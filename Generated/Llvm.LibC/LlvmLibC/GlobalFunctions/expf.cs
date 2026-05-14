using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expf
{
	public unsafe static float Invoke(float x)
	{
		float result = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num3 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs5 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		float num4 = 0f;
		double x2 = 0.0;
		int num5 = 0;
		double num6 = 0.0;
		double num7 = 0.0;
		double num8 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(num == -1036599924, expected: false))
			{
				result = llvm_fmuladd_f32.Invoke(0f - x, 2.524355E-29f, 1.4428169E-20f);
			}
			else
			{
				if (!bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)num2 < 1118961664u) ? ((uint)num2 <= 847249408u) : true, expected: false))
				{
					goto IL_03ab;
				}
				if ((ushort)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) <= 101)
				{
					result = 1f + x;
				}
				else if ((uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) >= 3268407733u)
				{
					if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2))
					{
						result = 0f;
					}
					else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2))
					{
						result = x;
					}
					else if (fputil_fenv_is_round_up.Invoke())
					{
						llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
						int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_min_subnormal_Sign.Invoke(anon_izyfb8.val);
						fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
						result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					}
					else
					{
						fputil_set_errno_if_required_int.Invoke(34);
						fputil_raise_except_if_required_int.Invoke(16);
						result = 0f;
					}
				}
				else
				{
					if (!fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_pos_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) || (uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) < 1118961664u)
					{
						goto IL_03ab;
					}
					if ((uint)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) < 2139095040u)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num3);
						num3 = fputil_quick_get_round.Invoke();
						int num9;
						if (num3 == 1024 || num3 == 3072)
						{
							llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
							int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_max_normal_Sign.Invoke(anon_izyfb9.val);
							fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
							result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs4);
							llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
							num9 = 1;
						}
						else
						{
							fputil_set_errno_if_required_int.Invoke(34);
							fputil_raise_except_if_required_int.Invoke(8);
							num9 = 0;
						}
						llvm_lifetime_end_p0.Invoke(4L, &num3);
						switch (num9)
						{
						case 0:
							break;
						default:
							goto IL_0518;
						}
					}
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_3 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb10.val);
					fputil_FPBits_5nkvcs5.FPRepImpl.FPRepSem.field_0.field_0 = field_3;
					result = x + fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs5);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs5);
				}
			}
			goto IL_0518;
		}
		IL_03ab:
		llvm_lifetime_start_p0.Invoke(4L, &num4);
		num4 = fputil_nearest_integer_float.Invoke(x * 128f);
		llvm_lifetime_start_p0.Invoke(8L, &x2);
		x2 = cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(num4, -1f / 128f, x);
		llvm_lifetime_start_p0.Invoke(4L, &num5);
		num5 = unchecked((int)num4);
		num5 += 13312;
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		long num10 = num5 >> 7;
		unchecked
		{
			num6 = ((double*)EXP_M1.Pointer)[num10];
			llvm_lifetime_start_p0.Invoke(8L, &num7);
			long num11 = num5 & 0x7F;
			num7 = ((double*)EXP_M2.Pointer)[num11];
			llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double_double_double.Invoke(x2, 1.0, 0.9999999999997574, 0.5000000000002021, 0.16666679382778612, 0.041666666671038154);
			result = (float)(num6 * num7 * num8);
			llvm_lifetime_end_p0.Invoke(8L, &num8);
			llvm_lifetime_end_p0.Invoke(8L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			goto IL_0518;
		}
		IL_0518:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
