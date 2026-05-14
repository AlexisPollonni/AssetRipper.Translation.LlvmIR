using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cbrtf
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double x2 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		long num6 = 0L;
		int num7 = 0;
		double num8 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		double num9 = 0.0;
		double num10 = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x3 = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		double x4 = 0.0;
		long num11 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		long x5 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)) >>> 31 << 11;
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((x != 0f) ? ((uint)num >= 2139095040u) : true, expected: false))
			{
				result = x + x;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = x;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x2);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = (ushort)fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = (int)((uint)num3 / 3u + 682) | num2;
				llvm_lifetime_start_p0.Invoke(4L, &num5);
				num5 = (int)((uint)num3 % 3u);
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = (int)(num6 >>> 48);
				num6 |= 0x3FF0000000000000L;
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, num6);
				double num12 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				num8 = num12;
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = num8 - 1.0;
				llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = num9 * num9;
				llvm_lifetime_start_p0.Invoke(8L, &z);
				double x6 = num9;
				long num13 = (uint)num7;
				z = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x6, *(double*)((byte*)anonymous_namespace_COEFFS.Pointer + (nint)num13 * sizeof(InlineArray7_Double)), 1.0);
				llvm_lifetime_start_p0.Invoke(8L, &y);
				double x7 = num9;
				long num14 = (uint)num7;
				double y4 = ((double*)((byte*)anonymous_namespace_COEFFS.Pointer + (nint)num14 * sizeof(InlineArray7_Double)))[2L];
				long num15 = (uint)num7;
				y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x7, y4, ((double*)((byte*)anonymous_namespace_COEFFS.Pointer + (nint)num15 * sizeof(InlineArray7_Double)))[1]);
				llvm_lifetime_start_p0.Invoke(8L, &z2);
				double x8 = num9;
				long num16 = (uint)num7;
				double y5 = ((double*)((byte*)anonymous_namespace_COEFFS.Pointer + (nint)num16 * sizeof(InlineArray7_Double)))[4L];
				long num17 = (uint)num7;
				z2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x8, y5, ((double*)((byte*)anonymous_namespace_COEFFS.Pointer + (nint)num17 * sizeof(InlineArray7_Double)))[3L]);
				llvm_lifetime_start_p0.Invoke(8L, &y2);
				double x9 = num9;
				long num18 = (uint)num7;
				double y6 = ((double*)((byte*)anonymous_namespace_COEFFS.Pointer + (nint)num18 * sizeof(InlineArray7_Double)))[6L];
				long num19 = (uint)num7;
				y2 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x9, y6, ((double*)((byte*)anonymous_namespace_COEFFS.Pointer + (nint)num19 * sizeof(InlineArray7_Double)))[5L]);
				llvm_lifetime_start_p0.Invoke(8L, &x3);
				x3 = num10 * num10;
				llvm_lifetime_start_p0.Invoke(8L, &z3);
				z3 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num10, y, z);
				llvm_lifetime_start_p0.Invoke(8L, &y3);
				y3 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(num10, y2, z2);
				llvm_lifetime_start_p0.Invoke(8L, &x4);
				double num20 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_multiply_add_double_double_double_double.Invoke(x3, y3, z3);
				long num21 = (uint)num5;
				x4 = num20 * ((double*)anonymous_namespace_CBRT2.Pointer)[num21];
				llvm_lifetime_start_p0.Invoke(8L, &num11);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm4, x4);
				long num22 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4));
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				num11 = num22;
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ulong)((num11 + 8L) & 0xFFFFFFFFFFFL) <= 16uL, expected: false))
				{
					num11 = (((ulong)(num11 & 0xFFFFFFFFFFFL) > 8uL) ? ((num11 & -32L) + 32L) : (num11 & -32L));
					fputil_clear_except_if_required_int.Invoke(32);
				}
				llvm_lifetime_start_p0.Invoke(8L, &x5);
				x5 = num11 | (long)((ulong)(uint)num4 << 52);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm5, x5);
				result = (float)fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
				llvm_lifetime_end_p0.Invoke(8L, &x5);
				llvm_lifetime_end_p0.Invoke(8L, &num11);
				llvm_lifetime_end_p0.Invoke(8L, &x4);
				llvm_lifetime_end_p0.Invoke(8L, &y3);
				llvm_lifetime_end_p0.Invoke(8L, &z3);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &y2);
				llvm_lifetime_end_p0.Invoke(8L, &z2);
				llvm_lifetime_end_p0.Invoke(8L, &y);
				llvm_lifetime_end_p0.Invoke(8L, &z);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(4L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(4L, &num5);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &x2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
