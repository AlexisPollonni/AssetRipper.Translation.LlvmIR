using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Log1pf
{
	[MangledName("log1pf")]
	[DemangledName("log1pf")]
	public unsafe static float Invoke([MangledName("x")] float X)
	{
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		int num = 0;
		int num2 = 0;
		double num3 = 0.0;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		InlineArray7_Double inlineArray7_Double = default(InlineArray7_Double);
		double x = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num4 = 0.0;
		Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, X);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = FPRepImpl_fputil_FPType_1_fputil_FPBits_float_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_vhj4tm*)(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs));
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = num & 0x7FFFFFFF;
			Llvm_lifetime_start_p0.Invoke(8L, &num3);
			num3 = X;
			float result;
			if ((uint)num2 > 1015021568u)
			{
				switch (num)
				{
				case 1091014635:
					result = Fputil_round_result_slightly_up_float.Invoke(2.2484071f);
					break;
				case 1557569160:
					result = Fputil_round_result_slightly_up_float.Invoke(40.71937f);
					break;
				case 1708691667:
					result = Fputil_round_result_slightly_down_float.Invoke(53.20505f);
					break;
				case 1865525484:
					result = Fputil_round_result_slightly_down_float.Invoke(66.17683f);
					break;
				case 2048389898:
					result = Fputil_round_result_slightly_up_float.Invoke(81.26974f);
					break;
				case -1122164561:
					result = Fputil_round_result_slightly_up_float.Invoke(-0.039116416f);
					break;
				case -1082130432:
				{
					Fputil_set_errno_if_required.Invoke(34);
					Fputil_raise_except_if_required.Invoke(4);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
					break;
				}
				case 1287768075:
					result = Fputil_round_result_slightly_down_float.Invoke(18.436527f);
					break;
				case 1592301646:
					result = Fputil_round_result_slightly_up_float.Invoke(43.57239f);
					break;
				case 1717468326:
					result = Fputil_round_result_slightly_up_float.Invoke(53.92517f);
					break;
				case 2045242423:
					result = Fputil_round_result_slightly_up_float.Invoke(80.99944f);
					break;
				default:
					result = Internal_log.Invoke(num3 + 1.0);
					break;
				}
			}
			else
			{
				switch (num)
				{
				case 893386755:
					result = Fputil_round_result_slightly_down_float.Invoke(7.152557E-07f);
					break;
				case 923795483:
					result = Fputil_round_result_slightly_down_float.Invoke(8.583057E-06f);
					break;
				case -1254096899:
					result = Fputil_round_result_slightly_down_float.Invoke(-7.152558E-07f);
					break;
				case -1223688219:
					result = Fputil_round_result_slightly_down_float.Invoke(-8.583081E-06f);
					break;
				case -1156659004:
					result = Fputil_round_result_slightly_up_float.Invoke(-0.0021810916f);
					break;
				default:
					Llvm_lifetime_start_p0.Invoke(56L, &inlineArray7_Double);
					*(double*)(&inlineArray7_Double) = -0.5;
					((double*)(&inlineArray7_Double))[1] = 0.33333333333363663;
					((double*)(&inlineArray7_Double))[2L] = -0.2500000000003425;
					((double*)(&inlineArray7_Double))[3L] = 0.19999999254663908;
					((double*)(&inlineArray7_Double))[4L] = -0.16666665914483877;
					((double*)(&inlineArray7_Double))[5L] = 0.14290947321258793;
					((double*)(&inlineArray7_Double))[6L] = -0.12504931962382268;
					Llvm_lifetime_start_p0.Invoke(8L, &x);
					x = num3 * num3;
					Llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
					a_yc74sk = Fputil_multiply_add_double.Invoke(num3, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, sizeof(double))), *(double*)(&inlineArray7_Double));
					Llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
					a_ijazrn = Fputil_multiply_add_double.Invoke(num3, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)2 * sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
					a_889uw = Fputil_multiply_add_double.Invoke(num3, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)4 * sizeof(double))));
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = Fputil_polyeval_double_double_double_double_double.Invoke(x, num3, a_yc74sk, a_ijazrn, a_889uw, Unsafe.As<InlineArray7_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray7_Double, (nint)6 * sizeof(double))));
					result = (float)num4;
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					Llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
					Llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
					Llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
					Llvm_lifetime_end_p0.Invoke(8L, &x);
					Llvm_lifetime_end_p0.Invoke(56L, &inlineArray7_Double);
					break;
				}
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			return result;
		}
	}
}
