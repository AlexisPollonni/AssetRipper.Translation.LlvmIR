using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class tanhf
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		int num2 = 0;
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double num3 = 0.0;
		double num4 = 0.0;
		double x2 = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double y = 0.0;
		InlineArray2_InlineArray2_Single inlineArray2_InlineArray2_Single = default(InlineArray2_InlineArray2_Single);
		double num5 = 0.0;
		double num6 = 0.0;
		int num7 = 0;
		long num8 = 0L;
		long x3 = 0L;
		double num9 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		double num10 = 0.0;
		InlineArray4_Double inlineArray4_Double = default(InlineArray4_Double);
		double x4 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double a_ijazrn2 = 0.0;
		double num11 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			int field_ = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs_const.Invoke(&fputil_FPBits_5nkvcs2);
			fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num12 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke(&fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			num = num12;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = InstructionHelper.Select(fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg_const.Invoke(&fputil_FPBits_5nkvcs2), 1, 0);
			float result;
			if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(((uint)num < 1097859072u) ? ((uint)num <= 1033895936u) : true, expected: false))
			{
				if ((uint)num <= 1033895936u)
				{
					if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((uint)num <= 847249408u, expected: false))
					{
						result = ((num == 0) ? x : ((float)llvm_fmuladd_f64.Invoke(0.0 - 1.0 / 3.0 * (double)x * (double)x, x, x)));
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
						llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
						*(double*)(&inlineArray5_Double) = -1.0 / 3.0;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = 2.0 / 15.0;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = -17.0 / 315.0;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = 0.021869488536155203;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = -0.008863235529902197;
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = x;
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = num3 * num3;
						llvm_lifetime_start_p0.Invoke(8L, &x2);
						x2 = num4 * num4;
						llvm_lifetime_start_p0.Invoke(8L, &a);
						a = num4 * *(double*)(&inlineArray5_Double);
						llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
						a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num4, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
						llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
						a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num4, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
						llvm_lifetime_start_p0.Invoke(8L, &y);
						y = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x2, a, a_yc74sk, a_ijazrn);
						result = (float)fputil_multiply_add_double_double_double.Invoke(num3, y, num3);
						llvm_lifetime_end_p0.Invoke(8L, &y);
						llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
						llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
						llvm_lifetime_end_p0.Invoke(8L, &a);
						llvm_lifetime_end_p0.Invoke(8L, &x2);
						llvm_lifetime_end_p0.Invoke(8L, &num4);
						llvm_lifetime_end_p0.Invoke(8L, &num3);
						llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
					}
				}
				else if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan_const.Invoke(&fputil_FPBits_5nkvcs2), expected: false))
				{
					result = x + 1f;
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_InlineArray2_Single);
					InlineArray2_Single* ptr = (InlineArray2_Single*)(&inlineArray2_InlineArray2_Single);
					*(float*)ptr = 1f;
					((float*)ptr)[1] = -2.9802322E-08f;
					InlineArray2_Single* ptr2 = (InlineArray2_Single*)(&inlineArray2_InlineArray2_Single) + 1;
					*(float*)ptr2 = -1f;
					((float*)ptr2)[1] = 2.9802322E-08f;
					result = ((!bool_details_expects_bool_condition_bool_bool_bool.Invoke(fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf_const.Invoke(&fputil_FPBits_5nkvcs2), expected: false)) ? (Unsafe.As<InlineArray2_InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_Single, (nint)num2 * (nint)sizeof(InlineArray2_Single))) + Unsafe.As<InlineArray2_InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_Single, (nint)num2 * (nint)sizeof(InlineArray2_Single)), sizeof(float)))) : Unsafe.As<InlineArray2_InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_Single, (nint)num2 * (nint)sizeof(InlineArray2_Single))));
					llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_InlineArray2_Single);
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = x;
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = double.NaN;
				llvm_lifetime_start_p0.Invoke(4L, &num7);
				num7 = -1431655766;
				num6 = fputil_nearest_integer_double.Invoke(num5 * 92.33248261689366);
				checked
				{
					num7 = -unchecked((int)num6);
					llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = unchecked((long)(num7 >> 5)) << 52;
					llvm_lifetime_start_p0.Invoke(8L, &x3);
					long num13 = num7 & 0x1F;
					x3 = unchecked((long*)ExpBase_EXP_2_MID.Pointer)[num13] + num8;
					llvm_lifetime_start_p0.Invoke(8L, &num9);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					fputil_FPBits_double_FPBits_unsigned_long_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, x3);
					double num14 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
					num9 = num14;
					llvm_lifetime_start_p0.Invoke(8L, &num10);
					num10 = fputil_multiply_add_double_double_double.Invoke(num6, -2.572804622327669E-14, fputil_multiply_add_double_double_double.Invoke(num6, -0.010830424696223417, num5));
					llvm_lifetime_start_p0.Invoke(32L, &inlineArray4_Double);
				}
				*(double*)(&inlineArray4_Double) = 1.9999999999761133;
				((double*)(&inlineArray4_Double))[1] = 1.3333333333401585;
				((double*)(&inlineArray4_Double))[2L] = 0.6666699249419907;
				((double*)(&inlineArray4_Double))[3L] = 0.2666670390291849;
				llvm_lifetime_start_p0.Invoke(8L, &x4);
				x4 = num10 * num10;
				llvm_lifetime_start_p0.Invoke(8L, &a2);
				a2 = fputil_multiply_add_double_double_double.Invoke(num10, 2.0, 1.0);
				llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
				a_yc74sk2 = fputil_multiply_add_double_double_double.Invoke(num10, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, sizeof(double))), *(double*)(&inlineArray4_Double));
				llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
				a_ijazrn2 = fputil_multiply_add_double_double_double.Invoke(num10, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)2 * sizeof(double))));
				llvm_lifetime_start_p0.Invoke(8L, &num11);
				num11 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double.Invoke(x4, a2, a_yc74sk2, a_ijazrn2);
				result = (float)((num11 - num9) / (num11 + num9));
				llvm_lifetime_end_p0.Invoke(8L, &num11);
				llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
				llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
				llvm_lifetime_end_p0.Invoke(8L, &a2);
				llvm_lifetime_end_p0.Invoke(8L, &x4);
				llvm_lifetime_end_p0.Invoke(32L, &inlineArray4_Double);
				llvm_lifetime_end_p0.Invoke(8L, &num10);
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_end_p0.Invoke(8L, &x3);
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(4L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
