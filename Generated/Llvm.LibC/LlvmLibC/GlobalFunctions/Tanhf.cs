using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Tanhf
{
	[MangledName("tanhf")]
	[DemangledName("tanhf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num2 = 0;
		InlineArray5_Double inlineArray5_Double = default(InlineArray5_Double);
		double num3 = 0.0;
		double num4 = 0.0;
		double x = 0.0;
		double a = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double y = 0.0;
		InlineArray2_InlineArray2_Single inlineArray2_InlineArray2_Single = default(InlineArray2_InlineArray2_Single);
		double num5 = 0.0;
		double x2 = 0.0;
		int num6 = 0;
		InlineArray2_Double inlineArray2_Double = default(InlineArray2_Double);
		long num7 = 0L;
		long x3 = 0L;
		double num8 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		double num9 = 0.0;
		InlineArray4_Double inlineArray4_Double = default(InlineArray4_Double);
		double x4 = 0.0;
		double a2 = 0.0;
		double a_yc74sk2 = 0.0;
		double a_ijazrn2 = 0.0;
		double num10 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			int field_ = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_abs.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			int num11 = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2));
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			num = num11;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = InstructionHelper.Select(FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs)), 1, 0);
			float result;
			if (Details_expects_bool_condition_bool.Invoke((uint)num >= 1097859072u || (uint)num <= 1033895936u, Expected: false))
			{
				if ((uint)num <= 1033895936u)
				{
					if (Details_expects_bool_condition_bool.Invoke((uint)num <= 847249408u, Expected: false))
					{
						result = ((num == 0) ? X : ((float)Llvm_fmuladd_f64.Invoke(0.0 - 1.0 / 3.0 * (double)X * (double)X, X, X)));
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(40L, &inlineArray5_Double);
						Llvm_memset_p0_i64.Invoke(&inlineArray5_Double, 0, 40L, isVolatile: false);
						*(double*)(&inlineArray5_Double) = -1.0 / 3.0;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))) = 2.0 / 15.0;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * (nint)sizeof(double))) = -17.0 / 315.0;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * (nint)sizeof(double))) = 0.021869488536155203;
						Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * (nint)sizeof(double))) = -0.008863235529902197;
						Llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = X;
						Llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = num3 * num3;
						Llvm_lifetime_start_p0.Invoke(8L, &x);
						x = num4 * num4;
						Llvm_lifetime_start_p0.Invoke(8L, &a);
						a = num4 * *(double*)(&inlineArray5_Double);
						Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
						a_yc74sk = Fputil_multiply_add_double.Invoke(num4, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)2 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, sizeof(double))));
						Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
						a_ijazrn = Fputil_multiply_add_double.Invoke(num4, Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)4 * sizeof(double))), Unsafe.As<InlineArray5_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray5_Double, (nint)3 * sizeof(double))));
						Llvm_lifetime_start_p0.Invoke(8L, &y);
						y = Fputil_polyeval_double_double_double.Invoke(x, a, a_yc74sk, a_ijazrn);
						result = (float)Fputil_multiply_add_double.Invoke(num3, y, num3);
						Llvm_lifetime_end_p0.Invoke(8L, &y);
						Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
						Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
						Llvm_lifetime_end_p0.Invoke(8L, &a);
						Llvm_lifetime_end_p0.Invoke(8L, &x);
						Llvm_lifetime_end_p0.Invoke(8L, &num4);
						Llvm_lifetime_end_p0.Invoke(8L, &num3);
						Llvm_lifetime_end_p0.Invoke(40L, &inlineArray5_Double);
					}
				}
				else if (Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_nan.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs), Expected: false))
				{
					result = X + 1f;
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_InlineArray2_Single);
					InlineArray2_Single* ptr = (InlineArray2_Single*)(&inlineArray2_InlineArray2_Single);
					*(float*)ptr = 1f;
					((float*)ptr)[1] = -2.9802322E-08f;
					InlineArray2_Single* ptr2 = (InlineArray2_Single*)(&inlineArray2_InlineArray2_Single) + 1;
					*(float*)ptr2 = -1f;
					((float*)ptr2)[1] = 2.9802322E-08f;
					result = ((!Details_expects_bool_condition_bool.Invoke(FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs), Expected: false)) ? (Unsafe.As<InlineArray2_InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_Single, (nint)num2 * (nint)sizeof(InlineArray2_Single))) + Unsafe.As<InlineArray2_InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_Single, (nint)num2 * (nint)sizeof(InlineArray2_Single)), sizeof(float)))) : Unsafe.As<InlineArray2_InlineArray2_Single, float>(ref Unsafe.AddByteOffset(ref inlineArray2_InlineArray2_Single, (nint)num2 * (nint)sizeof(InlineArray2_Single))));
					Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_InlineArray2_Single);
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = X;
				Llvm_lifetime_start_p0.Invoke(8L, &x2);
				x2 = double.NaN;
				Llvm_lifetime_start_p0.Invoke(4L, &num6);
				num6 = -1431655766;
				Llvm_lifetime_start_p0.Invoke(16L, &inlineArray2_Double);
				*(double*)(&inlineArray2_Double) = -0.5;
				((double*)(&inlineArray2_Double))[1] = 0.5;
				num6 = (int)Fputil_multiply_add_double.Invoke(num5, -92.33248261689366, Unsafe.As<InlineArray2_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray2_Double, (nint)num2 * (nint)sizeof(double))));
				x2 = checked(-num6);
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = (long)(num6 >> 5) << 52;
				Llvm_lifetime_start_p0.Invoke(8L, &x3);
				long num12 = num6 & 0x1F;
				checked
				{
					x3 = unchecked((long*)Llvm_libc_20_1_2_ExpBase_EXP_2_MID.Pointer)[num12] + num7;
					Llvm_lifetime_start_p0.Invoke(8L, &num8);
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					FPBits_double_FPBits_unsigned_long.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, x3);
					double num13 = FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					num8 = num13;
					Llvm_lifetime_start_p0.Invoke(8L, &num9);
					num9 = Fputil_multiply_add_double.Invoke(x2, -2.572804622327669E-14, Fputil_multiply_add_double.Invoke(x2, -0.010830424696223417, num5));
					Llvm_lifetime_start_p0.Invoke(32L, &inlineArray4_Double);
				}
				*(double*)(&inlineArray4_Double) = 1.9999999999761133;
				((double*)(&inlineArray4_Double))[1] = 1.3333333333401585;
				((double*)(&inlineArray4_Double))[2L] = 0.6666699249419907;
				((double*)(&inlineArray4_Double))[3L] = 0.2666670390291849;
				Llvm_lifetime_start_p0.Invoke(8L, &x4);
				x4 = num9 * num9;
				Llvm_lifetime_start_p0.Invoke(8L, &a2);
				a2 = Fputil_multiply_add_double.Invoke(num9, 2.0, 1.0);
				Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk2);
				a_yc74sk2 = Fputil_multiply_add_double.Invoke(num9, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, sizeof(double))), *(double*)(&inlineArray4_Double));
				Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn2);
				a_ijazrn2 = Fputil_multiply_add_double.Invoke(num9, Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray4_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray4_Double, (nint)2 * sizeof(double))));
				Llvm_lifetime_start_p0.Invoke(8L, &num10);
				num10 = Fputil_polyeval_double_double_double.Invoke(x4, a2, a_yc74sk2, a_ijazrn2);
				result = (float)((num10 - num8) / (num10 + num8));
				Llvm_lifetime_end_p0.Invoke(8L, &num10);
				Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn2);
				Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk2);
				Llvm_lifetime_end_p0.Invoke(8L, &a2);
				Llvm_lifetime_end_p0.Invoke(8L, &x4);
				Llvm_lifetime_end_p0.Invoke(32L, &inlineArray4_Double);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &x3);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(16L, &inlineArray2_Double);
				Llvm_lifetime_end_p0.Invoke(4L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &x2);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
