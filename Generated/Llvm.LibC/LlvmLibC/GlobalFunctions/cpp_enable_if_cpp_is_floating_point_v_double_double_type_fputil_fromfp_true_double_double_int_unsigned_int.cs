using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil6fromfpILb1EdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EES4_E4typeES4_ij")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, double>::type __llvm_libc_20_1_2_::fputil::fromfp<true, double>(double, int, unsigned int)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_fromfp_true_double_double_int_unsigned_int
{
	public unsafe static double Invoke(double x, int rnd, int width)
	{
		long num = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		double num2 = 0.0;
		long num3 = 0L;
		double num4 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm5 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm6 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb11 = default(anon_izyfb7);
		double num5 = 0.0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm7 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb12 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm8 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb13 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			double result;
			if (width == 0)
			{
				fputil_raise_except_if_required_int.Invoke(1);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb8.val, 0L);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
				result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, x);
				if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_inf_or_nan_const.Invoke(&fputil_FPBits_wjhbrm3))
				{
					fputil_raise_except_if_required_int.Invoke(1);
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
					llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
					long val2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb9.val, 0L);
					fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm4);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = cpp_enable_if_cpp_is_floating_point_v_double_double_type_fputil_round_using_specific_rounding_mode_double_double_int.Invoke(x, rnd);
					if ((uint)(width - 1) > 1023u)
					{
						result = num2;
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = (uint)(width - 1 + 1023);
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb10, Sign_NEG.Pointer, 1L, isVolatile: false);
						long val3 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: num3, sign: anon_izyfb10.val, mantissa: 0L);
						fputil_FPBits_wjhbrm5.FPRepImpl.FPRepSem.FPStorage.val = val3;
						double num6 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm5);
						llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm5);
						num4 = num6;
						if (num2 < num4)
						{
							fputil_raise_except_if_required_int.Invoke(1);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb11, Sign_POS.Pointer, 1L, isVolatile: false);
							long val4 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb11.val, 0L);
							fputil_FPBits_wjhbrm6.FPRepImpl.FPRepSem.FPStorage.val = val4;
							result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm6);
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm6);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(8L, &num5);
							llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb12, Sign_POS.Pointer, 1L, isVolatile: false);
							long val5 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_create_value_Sign_unsigned_long_unsigned_long.Invoke(biased_exp: num3, sign: anon_izyfb12.val, mantissa: 0L);
							fputil_FPBits_wjhbrm7.FPRepImpl.FPRepSem.FPStorage.val = val5;
							double num7 = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm7) - 1.0;
							llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm7);
							num5 = num7;
							if (num2 > num5)
							{
								fputil_raise_except_if_required_int.Invoke(1);
								llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
								llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb13, Sign_POS.Pointer, 1L, isVolatile: false);
								long val6 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(anon_izyfb13.val, 0L);
								fputil_FPBits_wjhbrm8.FPRepImpl.FPRepSem.FPStorage.val = val6;
								result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm8);
								llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm8);
							}
							else
							{
								result = num2;
							}
							llvm_lifetime_end_p0.Invoke(8L, &num5);
						}
						llvm_lifetime_end_p0.Invoke(8L, &num4);
						llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
