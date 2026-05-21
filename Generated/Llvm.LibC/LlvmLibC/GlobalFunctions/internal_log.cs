using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_log
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal3logEd")]
	[DemangledName("__llvm_libc_20_1_2_::internal::log(double)")]
	public unsafe static float Invoke([NativeType("double")] double x)
	{
		double num = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		long num2 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num3 = 0.0;
		int num4 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		double num5 = 0.0;
		double a = 0.0;
		double num6 = 0.0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0.6931471805599453;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
			long num7 = num2;
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_max_normal.Invoke(anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			bool num8 = details_expects_bool_condition_bool.Invoke((ulong)num7 > (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)), expected: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			float result;
			if (num8)
			{
				if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) && !FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					fputil_set_errno_if_required.Invoke(33);
					fputil_raise_except_if_required.Invoke(1);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(anon_izyfb9.val, 0);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					result = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				}
				else
				{
					result = (float)x;
				}
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(4L, &num4);
				num4 = (int)(FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) >>> 45);
				FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), 1023L);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				*(long*)(&fputil_FPBits_wjhbrm4) = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm4, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4), FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm4)) & -35184372088832L);
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2) - FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm4);
				long num9 = num4;
				double num10 = ((double*)ONE_OVER_F.Pointer)[num9];
				num5 *= num10;
				llvm_lifetime_start_p0.Invoke(8L, &a);
				double x2 = num3;
				long num11 = num4;
				a = fputil_multiply_add_double.Invoke(x2, 0.6931471805599453, ((double*)LOG_F.Pointer)[num11]);
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = fputil_polyeval_double_double_double_double_double_double.Invoke(num5, a, 0.9999999999999907, -0.49999999994038113, 0.33333327224101483, -0.24997806824515623, 0.19678021117199124);
				result = (float)num6;
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &a);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				llvm_lifetime_end_p0.Invoke(4L, &num4);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
