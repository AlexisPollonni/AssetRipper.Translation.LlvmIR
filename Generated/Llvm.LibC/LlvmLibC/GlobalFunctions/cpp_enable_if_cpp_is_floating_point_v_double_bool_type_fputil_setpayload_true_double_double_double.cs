using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil10setpayloadILb1EdEENS_3cpp9enable_ifIXsr3cppE19is_floating_point_vIT0_EEbE4typeERS4_S4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<double>, bool>::type __llvm_libc_20_1_2_::fputil::setpayload<true, double>(double&, double)")]
internal static partial class cpp_enable_if_cpp_is_floating_point_v_double_bool_type_fputil_setpayload_true_double_double_double
{
	public unsafe static bool Invoke(void* res, double pl)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int num = 0;
		long num2 = 0L;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm2, pl);
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent_const.Invoke(&fputil_FPBits_wjhbrm2);
			bool result;
			if (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg_const.Invoke(&fputil_FPBits_wjhbrm2) || num < 0 || num >= 51 || ((fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2) << (int)(uint)num) & 0xFFFFFFFFFFFFFL) != 0L)
			{
				*(double*)res = 0.0;
				result = true;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa_const.Invoke(&fputil_FPBits_wjhbrm2) >>> (int)(uint)checked(52 - num);
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_signaling_nan_Sign_unsigned_long.Invoke(v: num2, sign: anon_izyfb8.val);
				fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
				*(double*)res = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				result = false;
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			return result;
		}
	}
}
