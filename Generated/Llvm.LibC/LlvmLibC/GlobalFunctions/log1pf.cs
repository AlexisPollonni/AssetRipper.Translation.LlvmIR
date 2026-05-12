using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class log1pf
{
	public unsafe static float Invoke(float x)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		InlineArray7_Double inlineArray7_Double = default(InlineArray7_Double);
		double x2 = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num4 = 0.0;
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs2, x);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2));
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = x;
			float result;
			if ((uint)num2 > 1015021568u)
			{
				switch (num)
				{
				case 1091014635:
					result = float_fputil_round_result_slightly_up_float_float.Invoke(2.2484071f);
					break;
				case 1557569160:
					result = float_fputil_round_result_slightly_up_float_float.Invoke(40.71937f);
					break;
				case 1708691667:
					result = float_fputil_round_result_slightly_down_float_float.Invoke(53.20505f);
					break;
				case 1865525484:
					result = float_fputil_round_result_slightly_down_float_float.Invoke(66.17683f);
					break;
				case 2048389898:
					result = float_fputil_round_result_slightly_up_float_float.Invoke(81.26974f);
					break;
				case -1122164561:
					result = float_fputil_round_result_slightly_up_float_float.Invoke(-0.039116416f);
					break;
				case -1082130432:
				{
					fputil_set_errno_if_required_int.Invoke(34);
					fputil_raise_except_if_required_int.Invoke(4);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb8.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					break;
				}
				default:
					result = internal_log_double.Invoke(num3 + 1.0);
					break;
				}
			}
			else
			{
				switch (num)
				{
				case 893386755:
					result = float_fputil_round_result_slightly_down_float_float.Invoke(7.152557E-07f);
					break;
				case 923795483:
					result = float_fputil_round_result_slightly_down_float_float.Invoke(8.583057E-06f);
					break;
				case -1254096899:
					result = float_fputil_round_result_slightly_down_float_float.Invoke(-7.152558E-07f);
					break;
				case -1223688219:
					result = float_fputil_round_result_slightly_down_float_float.Invoke(-8.583081E-06f);
					break;
				case -1156659004:
					result = float_fputil_round_result_slightly_up_float_float.Invoke(-0.0021810916f);
					break;
				default:
					llvm_lifetime_start_p0.Invoke(56L, &inlineArray7_Double);
					*(double*)(&inlineArray7_Double) = -0.5;
					((double*)(&inlineArray7_Double))[1] = 0.33333333333363663;
					((double*)(&inlineArray7_Double))[2L] = -0.2500000000003425;
					((double*)(&inlineArray7_Double))[3L] = 0.19999999254663908;
					((double*)(&inlineArray7_Double))[4L] = -0.16666665914483877;
					((double*)(&inlineArray7_Double))[5L] = 0.14290947321258793;
					((double*)(&inlineArray7_Double))[6L] = -0.12504931962382268;
					llvm_lifetime_start_p0.Invoke(8L, &x2);
					x2 = num3 * num3;
					llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, sizeof(double))), *(double*)(&inlineArray7_Double));
					llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)2 * sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
					a_889uw = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)4 * sizeof(double))));
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double_double_double.Invoke(x2, num3, a_yc74sk, a_ijazrn, a_889uw, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)6 * sizeof(double))));
					result = (float)num4;
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
					llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					llvm_lifetime_end_p0.Invoke(8L, &x2);
					llvm_lifetime_end_p0.Invoke(56L, &inlineArray7_Double);
					break;
				}
			}
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return result;
		}
	}
}
