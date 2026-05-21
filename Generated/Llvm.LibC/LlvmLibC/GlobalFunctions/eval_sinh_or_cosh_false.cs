using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class eval_sinh_or_cosh_false
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17eval_sinh_or_coshILb0EEEDF16_DF16_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::eval_sinh_or_cosh<false>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([NativeType("_Float16")] Half x)
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
			num2 = fputil_nearest_integer.Invoke(num * 46.16624f);
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
			x2 = *(int*)array_unsigned_int_32ul_Index.Invoke(Index: (uint)num7, @this: EXP2_MID_5_BITS_12.Pointer) + (num5 << 23);
			llvm_lifetime_start_p0.Invoke(4L, &x3);
			x3 = *(int*)array_unsigned_int_32ul_Index.Invoke(Index: (uint)num8, @this: EXP2_MID_5_BITS_12.Pointer) + (num6 << 23);
			llvm_lifetime_start_p0.Invoke(4L, &num9);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x2);
			float num16 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			num9 = num16;
			llvm_lifetime_start_p0.Invoke(4L, &num10);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs3, x3);
			float num17 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			num10 = num17;
			llvm_lifetime_start_p0.Invoke(4L, &num11);
			num11 = num9 + num10;
			llvm_lifetime_start_p0.Invoke(4L, &num12);
			num12 = num9 - num10;
			llvm_lifetime_start_p0.Invoke(4L, &num13);
			num13 = fputil_multiply_add_float.Invoke(num2, -0.02166085f, num);
			llvm_lifetime_start_p0.Invoke(4L, &x4);
			x4 = num13 * num13;
			llvm_lifetime_start_p0.Invoke(16L, &cpp_array_scvvei2);
			sbyte* ptr = (sbyte*)(&cpp_array_scvvei2);
			*(float*)ptr = 1f;
			((float*)ptr)[1] = 1f;
			((float*)ptr)[2L] = 0.5000305f;
			((float*)ptr)[3L] = 0.16667074f;
			llvm_lifetime_start_p0.Invoke(4L, &num14);
			num14 = fputil_polyeval_float_float.Invoke(x4, *(float*)array_float_4ul_Index.Invoke(&cpp_array_scvvei2, 1L) * 0.5f, *(float*)array_float_4ul_Index.Invoke(&cpp_array_scvvei2, 3L) * 0.5f);
			llvm_lifetime_start_p0.Invoke(4L, &num15);
			num15 = fputil_polyeval_float_float.Invoke(x4, *(float*)array_float_4ul_Index.Invoke(&cpp_array_scvvei2, 0L) * 0.5f, *(float*)array_float_4ul_Index.Invoke(&cpp_array_scvvei2, 2L) * 0.5f);
			Half result = fputil_cast_Float16_float.Invoke(fputil_multiply_add_float.Invoke(num13, num14 * num12, num15 * num11));
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
