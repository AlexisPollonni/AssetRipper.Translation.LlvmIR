using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIdEENS_14StrToNumResultIT_EEPKc")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double> __llvm_libc_20_1_2_::internal::strtonan<double>(char const*)")]
internal static partial class StrToNumResult_double_internal_strtonan_double_char_const
{
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_r53a3q* agg_result, void* arg)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int error = 0;
		long num = 0L;
		long num2 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(arg == null, expected: false))
		{
			llvm_trap.Invoke();
		}
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			fputil_FPBits_double_FPBits.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (!internal_isalnum_int_27.Invoke(((sbyte*)arg)[num2])) ? (((sbyte*)arg)[num2] == 95) : true; num2 = checked(num2 + 1L))
			{
			}
			if (((sbyte*)arg)[num2] == 0)
			{
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, arg, num2);
				num = fputil_FPBits_double_StorageType_internal_nan_mantissa_from_ncharseq_double_cpp_string_view.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			}
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan_Sign_unsigned_long.Invoke(v: num, sign: anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			StrToNumResult_double_StrToNumResult_double_long_int.Invoke(agg_result, fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2), 0L, error);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		}
	}
}
