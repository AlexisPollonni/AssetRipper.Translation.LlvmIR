using System.Runtime.CompilerServices;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L8log_evalEd.64")]
[DemangledName("__llvm_libc_20_1_2_::log_eval(double) (.64)")]
internal static partial class log_eval_double_64
{
	public unsafe static double Invoke(double x)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		double num = 0.0;
		int num2 = 0;
		double num3 = 0.0;
		InlineArray6_Double inlineArray6_Double = default(InlineArray6_Double);
		double x2 = 0.0;
		double a_yc74sk = 0.0;
		double a_ijazrn = 0.0;
		double a_889uw = 0.0;
		double num4 = 0.0;
		double num5 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent_const.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = (int)(fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2) >>> 45);
			fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval_const.Invoke(&fputil_FPBits_wjhbrm2) & 0x1FFFFFFFFFFFL);
			fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent_unsigned_long.Invoke(&fputil_FPBits_wjhbrm2, 1023L);
			llvm_lifetime_start_p0.Invoke(8L, &num3);
			double num6 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2) - 1.0;
			long num7 = num2;
			num3 = num6 * ((double*)ONE_OVER_F.Pointer)[num7];
			llvm_lifetime_start_p0.Invoke(48L, &inlineArray6_Double);
			llvm_memset_p0_i64.Invoke(&inlineArray6_Double, 0, 48L, isVolatile: false);
			*(double*)(&inlineArray6_Double) = -0.4999999999999998;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))) = 0.3333333333327725;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * (nint)sizeof(double))) = -0.24999999953131305;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * (nint)sizeof(double))) = 0.1999998203603259;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * (nint)sizeof(double))) = -0.1666318752093591;
			Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * (nint)sizeof(double))) = 0.13953736698133024;
			llvm_lifetime_start_p0.Invoke(8L, &x2);
			x2 = num3 * num3;
			llvm_lifetime_start_p0.Invoke(8L, &a_yc74sk);
			a_yc74sk = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, sizeof(double))), *(double*)(&inlineArray6_Double));
			llvm_lifetime_start_p0.Invoke(8L, &a_ijazrn);
			a_ijazrn = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)3 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)2 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &a_889uw);
			a_889uw = fputil_multiply_add_double_double_double.Invoke(num3, Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)5 * sizeof(double))), Unsafe.As<InlineArray6_Double, double>(ref Unsafe.AddByteOffset(ref inlineArray6_Double, (nint)4 * sizeof(double))));
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = cpp_enable_if_sizeof_double_8ul_double_type_fputil_polyeval_double_double_double_double_double_double_double_double_double.Invoke(x2, num3, a_yc74sk, a_ijazrn, a_889uw);
			llvm_lifetime_start_p0.Invoke(8L, &num5);
			double x3 = num;
			long num8 = num2;
			num5 = fputil_multiply_add_double_double_double.Invoke(x3, 0.6931471805599453, ((double*)LOG_F.Pointer)[num8] + num4);
			double result = num5;
			llvm_lifetime_end_p0.Invoke(8L, &num5);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(8L, &a_889uw);
			llvm_lifetime_end_p0.Invoke(8L, &a_ijazrn);
			llvm_lifetime_end_p0.Invoke(8L, &a_yc74sk);
			llvm_lifetime_end_p0.Invoke(8L, &x2);
			llvm_lifetime_end_p0.Invoke(48L, &inlineArray6_Double);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
