using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class erff
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		InlineArray2_Single inlineArray2_Single = default(InlineArray2_Single);
		InlineArray2_Single inlineArray2_Single2 = default(InlineArray2_Single);
		int num3 = 0;
		int num4 = 0;
		double num5 = 0.0;
		double num6 = 0.0;
		int num7 = 0;
		int num8 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		double num9 = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x2 = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		float result;
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (details_expects_bool_condition_bool.Invoke((uint)num2 >= 1082130432u, expected: false))
			{
				llvm_lifetime_start_p0.Invoke(8L, &inlineArray2_Single);
				*(float*)(&inlineArray2_Single) = 1f;
				((float*)(&inlineArray2_Single))[1] = -1f;
				llvm_lifetime_start_p0.Invoke(8L, &inlineArray2_Single2);
				*(float*)(&inlineArray2_Single2) = -2.9802322E-08f;
				((float*)(&inlineArray2_Single2))[1] = 2.9802322E-08f;
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2)), 1, 0);
				result = ((!details_expects_bool_condition_bool.Invoke((uint)num2 >= 2139095040u, expected: false)) ? (Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single, (nint)num3 * (nint)sizeof(float))) + Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single2, (nint)num3 * (nint)sizeof(float)))) : (((uint)num2 <= 2139095040u) ? Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single, (nint)num3 * (nint)sizeof(float))) : x));
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &inlineArray2_Single2);
				llvm_lifetime_end_p0.Invoke(8L, &inlineArray2_Single);
				goto IL_0648;
			}
			llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = -2137366140;
			if (!details_expects_bool_condition_bool.Invoke((num2 & -2137366140) == 0, expected: false))
			{
				goto IL_02e6;
			}
			if (details_expects_bool_condition_bool.Invoke(num2 == 1063621161, expected: false))
			{
				result = ((!(x < 0f)) ? fputil_round_result_slightly_up_float.Invoke(0.79527783f) : fputil_round_result_slightly_down_float.Invoke(-0.79527783f));
			}
			else if (details_expects_bool_condition_bool.Invoke(num2 == 1074011754, expected: false))
			{
				result = ((!(x < 0f)) ? fputil_round_result_slightly_up_float.Invoke(0.9964934f) : fputil_round_result_slightly_down_float.Invoke(-0.9964934f));
			}
			else
			{
				if (num2 != 0)
				{
					goto IL_02e6;
				}
				result = x;
			}
			goto IL_0636;
		}
		IL_02e6:
		llvm_lifetime_start_p0.Invoke(8L, &num5);
		num5 = x;
		llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = num5 * num5;
		llvm_lifetime_start_p0.Invoke(4L, &num7);
		num7 = 25165824;
		llvm_lifetime_start_p0.Invoke(4L, &num8);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
		unchecked
		{
			FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs3, num2 + 25165824);
			int num10 = (int)FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			num8 = num10;
			llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = num6 * num6;
			llvm_lifetime_start_p0.Invoke(8L, &z);
			double x3 = num6;
			long num11 = num8;
			double y4 = ((double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num11 * sizeof(InlineArray8_Double)))[1];
			long num12 = num8;
			z = fputil_multiply_add_double.Invoke(x3, y4, *(double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num12 * sizeof(InlineArray8_Double)));
			llvm_lifetime_start_p0.Invoke(8L, &y);
			double x4 = num6;
			long num13 = num8;
			double y5 = ((double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num13 * sizeof(InlineArray8_Double)))[3L];
			long num14 = num8;
			y = fputil_multiply_add_double.Invoke(x4, y5, ((double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num14 * sizeof(InlineArray8_Double)))[2L]);
			llvm_lifetime_start_p0.Invoke(8L, &z2);
			double x5 = num6;
			long num15 = num8;
			double y6 = ((double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num15 * sizeof(InlineArray8_Double)))[5L];
			long num16 = num8;
			z2 = fputil_multiply_add_double.Invoke(x5, y6, ((double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num16 * sizeof(InlineArray8_Double)))[4L]);
			llvm_lifetime_start_p0.Invoke(8L, &y2);
			double x6 = num6;
			long num17 = num8;
			double y7 = ((double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num17 * sizeof(InlineArray8_Double)))[7L];
			long num18 = num8;
			y2 = fputil_multiply_add_double.Invoke(x6, y7, ((double*)((byte*)COEFFS_jd9ei8.Pointer + (nint)num18 * sizeof(InlineArray8_Double)))[6L]);
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num9 * num9;
			llvm_lifetime_start_p0.Invoke(8L, &z3);
			z3 = fputil_multiply_add_double.Invoke(num9, y, z);
			llvm_lifetime_start_p0.Invoke(8L, &y3);
			y3 = fputil_multiply_add_double.Invoke(num9, y2, z2);
			result = (float)(num5 * fputil_multiply_add_double.Invoke(x2, y3, z3));
			llvm_lifetime_end_p0.Invoke(8L, &y3);
			llvm_lifetime_end_p0.Invoke(8L, &z3);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(8L, &y2);
			llvm_lifetime_end_p0.Invoke(8L, &z2);
			llvm_lifetime_end_p0.Invoke(8L, &y);
			llvm_lifetime_end_p0.Invoke(8L, &z);
			llvm_lifetime_end_p0.Invoke(8L, &num9);
			llvm_lifetime_end_p0.Invoke(4L, &num8);
			llvm_lifetime_end_p0.Invoke(4L, &num7);
			llvm_lifetime_end_p0.Invoke(8L, &num6);
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			goto IL_0636;
		}
		IL_0636:
		llvm_lifetime_end_p0.Invoke(4L, &num4);
		goto IL_0648;
		IL_0648:
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		return result;
	}
}
