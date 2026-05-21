using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_strtonan_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIfEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float> __llvm_libc_20_1_2_::internal::strtonan<float>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<float>")]
	public unsafe static Struct_fiz2nb Invoke([NativeType("char const*")] void* arg)
	{
		StrToNumResult_cqc3yy strToNumResult_cqc3yy = default(StrToNumResult_cqc3yy);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		int error = 0;
		int num = 0;
		long num2 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		if (details_expects_bool_condition_bool.Invoke(arg == null, expected: false))
		{
			llvm_trap.Invoke();
		}
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (!internal_isalnum_sgcu77.Invoke(((sbyte*)arg)[num2])) ? (((sbyte*)arg)[num2] == 95) : true; num2 = checked(num2 + 1L))
			{
			}
			if (((sbyte*)arg)[num2] == 0)
			{
				string_view_Constructor.Invoke(&cpp_string_view2, arg, num2);
				num = internal_nan_mantissa_from_ncharseq_float.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			}
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(v: num, sign: anon_izyfb8.val);
			fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			StrToNumResult_float_Constructor.Invoke(&strToNumResult_cqc3yy, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2), 0L, error);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return *(Struct_fiz2nb*)(&strToNumResult_cqc3yy);
		}
	}
}
