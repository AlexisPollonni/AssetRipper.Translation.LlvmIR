using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Eval_sinh_or_cosh_false
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17eval_sinh_or_coshILb0EEEDF16_DF16_")]
	[DemangledName("_Float16 __llvm_libc_20_1_2_::eval_sinh_or_cosh<false>(_Float16)")]
	[return: NativeType("_Float16")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("_Float16")] Half X)
	{
		float num = 0f;
		float num2 = 0f;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		int x = 0;
		int x2 = 0;
		float num9 = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		float num10 = 0f;
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		float num11 = 0f;
		float num12 = 0f;
		float num13 = 0f;
		float x3 = 0f;
		Cpp_array_scvvei cpp_array_scvvei = default(Cpp_array_scvvei);
		float num14 = 0f;
		float num15 = 0f;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = (float)X;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = Fputil_nearest_integer.Invoke(num * 46.16624f);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = (int)num2;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = checked(-num3);
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = num3 >>> 5;
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = num4 >>> 5;
			Llvm_lifetime_start_p0.Invoke(4L, &num7);
			num7 = num3 & 0x1F;
			Llvm_lifetime_start_p0.Invoke(4L, &num8);
			num8 = num4 & 0x1F;
			Llvm_lifetime_start_p0.Invoke(4L, &x);
			x = *(int*)Array_unsigned_int_32ul_Index.Invoke(Index: (uint)num7, This: EXP2_MID_5_BITS_12.Pointer) + (num5 << 23);
			Llvm_lifetime_start_p0.Invoke(4L, &x2);
			x2 = *(int*)Array_unsigned_int_32ul_Index.Invoke(Index: (uint)num8, This: EXP2_MID_5_BITS_12.Pointer) + (num6 << 23);
			Llvm_lifetime_start_p0.Invoke(4L, &num9);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs, x);
			float num16 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			num9 = num16;
			Llvm_lifetime_start_p0.Invoke(4L, &num10);
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, x2);
			float num17 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			num10 = num17;
			Llvm_lifetime_start_p0.Invoke(4L, &num11);
			num11 = num9 + num10;
			Llvm_lifetime_start_p0.Invoke(4L, &num12);
			num12 = num9 - num10;
			Llvm_lifetime_start_p0.Invoke(4L, &num13);
			num13 = Fputil_multiply_add_float.Invoke(num2, -0.02166085f, num);
			Llvm_lifetime_start_p0.Invoke(4L, &x3);
			x3 = num13 * num13;
			Llvm_lifetime_start_p0.Invoke(16L, &cpp_array_scvvei);
			sbyte* ptr = (sbyte*)(&cpp_array_scvvei);
			*(float*)ptr = 1f;
			((float*)ptr)[1] = 1f;
			((float*)ptr)[2L] = 0.5000305f;
			((float*)ptr)[3L] = 0.16667074f;
			Llvm_lifetime_start_p0.Invoke(4L, &num14);
			num14 = Fputil_polyeval_float_float.Invoke(x3, *(float*)Array_float_4ul_Index.Invoke(&cpp_array_scvvei, 1L) * 0.5f, *(float*)Array_float_4ul_Index.Invoke(&cpp_array_scvvei, 3L) * 0.5f);
			Llvm_lifetime_start_p0.Invoke(4L, &num15);
			num15 = Fputil_polyeval_float_float.Invoke(x3, *(float*)Array_float_4ul_Index.Invoke(&cpp_array_scvvei, 0L) * 0.5f, *(float*)Array_float_4ul_Index.Invoke(&cpp_array_scvvei, 2L) * 0.5f);
			Half result = Fputil_cast_Float16_float.Invoke(Fputil_multiply_add_float.Invoke(num13, num14 * num12, num15 * num11));
			Llvm_lifetime_end_p0.Invoke(4L, &num15);
			Llvm_lifetime_end_p0.Invoke(4L, &num14);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_array_scvvei);
			Llvm_lifetime_end_p0.Invoke(4L, &x3);
			Llvm_lifetime_end_p0.Invoke(4L, &num13);
			Llvm_lifetime_end_p0.Invoke(4L, &num12);
			Llvm_lifetime_end_p0.Invoke(4L, &num11);
			Llvm_lifetime_end_p0.Invoke(4L, &num10);
			Llvm_lifetime_end_p0.Invoke(4L, &num9);
			Llvm_lifetime_end_p0.Invoke(4L, &x2);
			Llvm_lifetime_end_p0.Invoke(4L, &x);
			Llvm_lifetime_end_p0.Invoke(4L, &num8);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(4L, &num6);
			Llvm_lifetime_end_p0.Invoke(4L, &num5);
			Llvm_lifetime_end_p0.Invoke(4L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
