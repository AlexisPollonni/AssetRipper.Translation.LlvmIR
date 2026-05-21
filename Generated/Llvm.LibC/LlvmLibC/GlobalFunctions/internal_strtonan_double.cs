using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_strtonan_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIdEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double> __llvm_libc_20_1_2_::internal::strtonan<double>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<double>")]
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_k826n6* agg_result, [NativeType("char const*")] void* arg)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		int error = 0;
		long num = 0L;
		long num2 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		if (details_expects_bool_condition_bool.Invoke(arg == null, expected: false))
		{
			llvm_trap.Invoke();
		}
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (!internal_isalnum_8q3d39.Invoke(((sbyte*)arg)[num2])) ? (((sbyte*)arg)[num2] == 95) : true; num2 = checked(num2 + 1L))
			{
			}
			if (((sbyte*)arg)[num2] == 0)
			{
				string_view_Constructor.Invoke(&cpp_string_view2, arg, num2);
				num = internal_nan_mantissa_from_ncharseq_double.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			}
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: num, sign: anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			StrToNumResult_double_Constructor.Invoke(agg_result, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2), 0L, error);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		}
	}
}
