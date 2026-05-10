using System;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_17eval_sinh_or_coshILb1EEEDF16_DF16_")]
[DemangledName("_Float16 __llvm_libc_20_1_2_::eval_sinh_or_cosh<true>(_Float16)")]
internal static partial class Float16_eval_sinh_or_cosh_true_Float16
{
	public unsafe static Half Invoke(Half x)
	{
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int x2 = 0;
		int x3 = 0;
		float num9 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		float num10 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		float num11 = 0f;
		float num12 = 0f;
		float num13 = 0f;
		float x4 = 0f;
		cpp_array_scvvei cpp_array_scvvei2 = default(cpp_array_scvvei);
		float num14 = 0f;
		float num15 = 0f;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (float)x;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = fputil_nearest_integer_float.Invoke(num * 46.16624f);
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)num2;
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(-num3);
			llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 >>> 5;
			llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = num4 >>> 5;
			llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = num3 & 0x1F;
			llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = num4 & 0x1F;
			llvm_lifetime_start_p0.Invoke(4L, &x2);
			x2 = *(int*)cpp_array_unsigned_int_32ul_operator_unsigned_long_const.Invoke(Index: (uint)num7, @this: EXP2_MID_5_BITS_5.Pointer) + (num5 << 23);
			llvm_lifetime_start_p0.Invoke(4L, &x3);
			x3 = *(int*)cpp_array_unsigned_int_32ul_operator_unsigned_long_const.Invoke(Index: (uint)num8, @this: EXP2_MID_5_BITS_5.Pointer) + (num6 << 23);
			llvm_lifetime_start_p0.Invoke(4L, &num9);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x2);
			float num16 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			num9 = num16;
			llvm_lifetime_start_p0.Invoke(4L, &num10);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs3, x3);
			float num17 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			num10 = num17;
			llvm_lifetime_start_p0.Invoke(4L, &num11);
			num11 = num9 + num10;
			llvm_lifetime_start_p0.Invoke(4L, &num12);
			num12 = num9 - num10;
			llvm_lifetime_start_p0.Invoke(4L, &num13);
			num13 = cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(num2, -0.02166085f, num);
			llvm_lifetime_start_p0.Invoke(4L, &x4);
			x4 = num13 * num13;
			llvm_lifetime_start_p0.Invoke(16L, &cpp_array_scvvei2);
			sbyte* ptr = (sbyte*)(&cpp_array_scvvei2);
			*(float*)ptr = 1f;
			((float*)ptr)[1] = 1f;
			((float*)ptr)[2L] = 0.5000305f;
			((float*)ptr)[3L] = 0.16667074f;
			llvm_lifetime_start_p0.Invoke(4L, &num14);
			num14 = cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float.Invoke(x4, *(float*)cpp_array_float_4ul_operator_unsigned_long_const.Invoke(&cpp_array_scvvei2, 1L) * 0.5f, *(float*)cpp_array_float_4ul_operator_unsigned_long_const.Invoke(&cpp_array_scvvei2, 3L) * 0.5f);
			llvm_lifetime_start_p0.Invoke(4L, &num15);
			num15 = cpp_enable_if_sizeof_float_8ul_float_type_fputil_polyeval_float_float_float_float_float.Invoke(x4, *(float*)cpp_array_float_4ul_operator_unsigned_long_const.Invoke(&cpp_array_scvvei2, 0L) * 0.5f, *(float*)cpp_array_float_4ul_operator_unsigned_long_const.Invoke(&cpp_array_scvvei2, 2L) * 0.5f);
			Half result = cpp_enable_if_cpp_is_floating_point_v_Float16_cpp_is_floating_point_v_float_Float16_type_fputil_cast_Float16_float_float.Invoke(cpp_enable_if_sizeof_float_8ul_float_type_fputil_multiply_add_float_float_float_float.Invoke(num13, num14 * num11, num15 * num12));
			llvm_lifetime_end_p0.Invoke(4L, &num15);
			llvm_lifetime_end_p0.Invoke(4L, &num14);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_array_scvvei2);
			llvm_lifetime_end_p0.Invoke(4L, &x4);
			llvm_lifetime_end_p0.Invoke(4L, &num13);
			llvm_lifetime_end_p0.Invoke(4L, &num12);
			llvm_lifetime_end_p0.Invoke(4L, &num11);
			llvm_lifetime_end_p0.Invoke(4L, &num10);
			llvm_lifetime_end_p0.Invoke(4L, &num9);
			llvm_lifetime_end_p0.Invoke(4L, &x3);
			llvm_lifetime_end_p0.Invoke(4L, &x2);
			llvm_lifetime_end_p0.Invoke(4L, &num8);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(4L, &num6);
			llvm_lifetime_end_p0.Invoke(4L, &num5);
			llvm_lifetime_end_p0.Invoke(4L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
