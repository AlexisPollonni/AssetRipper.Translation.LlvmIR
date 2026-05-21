using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Erff
{
	[MangledName("erff")]
	[DemangledName("erff")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
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
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		double num9 = 0.0;
		double z = 0.0;
		double y = 0.0;
		double z2 = 0.0;
		double y2 = 0.0;
		double x = 0.0;
		double z3 = 0.0;
		double y3 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		float result;
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			if (Details_expects_bool_condition_bool.Invoke((uint)num2 >= 1082130432u, Expected: false))
			{
				Llvm_lifetime_start_p0.Invoke(8L, &inlineArray2_Single);
				*(float*)(&inlineArray2_Single) = 1f;
				((float*)(&inlineArray2_Single))[1] = -1f;
				Llvm_lifetime_start_p0.Invoke(8L, &inlineArray2_Single2);
				*(float*)(&inlineArray2_Single2) = -2.9802322E-08f;
				((float*)(&inlineArray2_Single2))[1] = 2.9802322E-08f;
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)), 1, 0);
				result = ((!Details_expects_bool_condition_bool.Invoke((uint)num2 >= 2139095040u, Expected: false)) ? (Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single, (nint)num3 * (nint)sizeof(float))) + Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single2, (nint)num3 * (nint)sizeof(float)))) : (((uint)num2 <= 2139095040u) ? Unsafe.As<InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_Single, (nint)num3 * (nint)sizeof(float))) : X));
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &inlineArray2_Single2);
				Llvm_lifetime_end_p0.Invoke(8L, &inlineArray2_Single);
				goto IL_0648;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = -2137366140;
			if (!Details_expects_bool_condition_bool.Invoke((num2 & -2137366140) == 0, Expected: false))
			{
				goto IL_02e6;
			}
			if (Details_expects_bool_condition_bool.Invoke(num2 == 1063621161, Expected: false))
			{
				result = ((!(X < 0f)) ? Fputil_round_result_slightly_up_float.Invoke(0.79527783f) : Fputil_round_result_slightly_down_float.Invoke(-0.79527783f));
			}
			else if (Details_expects_bool_condition_bool.Invoke(num2 == 1074011754, Expected: false))
			{
				result = ((!(X < 0f)) ? Fputil_round_result_slightly_up_float.Invoke(0.9964934f) : Fputil_round_result_slightly_down_float.Invoke(-0.9964934f));
			}
			else
			{
				if (num2 != 0)
				{
					goto IL_02e6;
				}
				result = X;
			}
			goto IL_0636;
		}
		IL_02e6:
		Llvm_lifetime_start_p0.Invoke(8L, &num5);
		num5 = X;
		Llvm_lifetime_start_p0.Invoke(8L, &num6);
		num6 = num5 * num5;
		Llvm_lifetime_start_p0.Invoke(4L, &num7);
		num7 = 25165824;
		Llvm_lifetime_start_p0.Invoke(4L, &num8);
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
		unchecked
		{
			FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, num2 + 25165824);
			int num10 = (int)FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			num8 = num10;
			Llvm_lifetime_start_p0.Invoke(8L, &num9);
			num9 = num6 * num6;
			Llvm_lifetime_start_p0.Invoke(8L, &z);
			double x2 = num6;
			long num11 = num8;
			double y4 = ((double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num11 * sizeof(InlineArray8_Double)))[1];
			long num12 = num8;
			z = Fputil_multiply_add_double.Invoke(x2, y4, *(double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num12 * sizeof(InlineArray8_Double)));
			Llvm_lifetime_start_p0.Invoke(8L, &y);
			double x3 = num6;
			long num13 = num8;
			double y5 = ((double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num13 * sizeof(InlineArray8_Double)))[3L];
			long num14 = num8;
			y = Fputil_multiply_add_double.Invoke(x3, y5, ((double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num14 * sizeof(InlineArray8_Double)))[2L]);
			Llvm_lifetime_start_p0.Invoke(8L, &z2);
			double x4 = num6;
			long num15 = num8;
			double y6 = ((double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num15 * sizeof(InlineArray8_Double)))[5L];
			long num16 = num8;
			z2 = Fputil_multiply_add_double.Invoke(x4, y6, ((double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num16 * sizeof(InlineArray8_Double)))[4L]);
			Llvm_lifetime_start_p0.Invoke(8L, &y2);
			double x5 = num6;
			long num17 = num8;
			double y7 = ((double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num17 * sizeof(InlineArray8_Double)))[7L];
			long num18 = num8;
			y2 = Fputil_multiply_add_double.Invoke(x5, y7, ((double*)((byte*)Llvm_libc_20_1_2_COEFFS.Pointer + (nint)num18 * sizeof(InlineArray8_Double)))[6L]);
			Llvm_lifetime_start_p0.Invoke(8L, &x);
			x = num9 * num9;
			Llvm_lifetime_start_p0.Invoke(8L, &z3);
			z3 = Fputil_multiply_add_double.Invoke(num9, y, z);
			Llvm_lifetime_start_p0.Invoke(8L, &y3);
			y3 = Fputil_multiply_add_double.Invoke(num9, y2, z2);
			result = (float)(num5 * Fputil_multiply_add_double.Invoke(x, y3, z3));
			Llvm_lifetime_end_p0.Invoke(8L, &y3);
			Llvm_lifetime_end_p0.Invoke(8L, &z3);
			Llvm_lifetime_end_p0.Invoke(8L, &x);
			Llvm_lifetime_end_p0.Invoke(8L, &y2);
			Llvm_lifetime_end_p0.Invoke(8L, &z2);
			Llvm_lifetime_end_p0.Invoke(8L, &y);
			Llvm_lifetime_end_p0.Invoke(8L, &z);
			Llvm_lifetime_end_p0.Invoke(8L, &num9);
			Llvm_lifetime_end_p0.Invoke(4L, &num8);
			Llvm_lifetime_end_p0.Invoke(4L, &num7);
			Llvm_lifetime_end_p0.Invoke(8L, &num6);
			Llvm_lifetime_end_p0.Invoke(8L, &num5);
			goto IL_0636;
		}
		IL_0636:
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		goto IL_0648;
		IL_0648:
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		return result;
	}
}
