using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtonan_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIfEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float> __llvm_libc_20_1_2_::internal::strtonan<float>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<float>")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("arg")][NativeType("char const*")] void* Arg)
	{
		StrToNumResult_cqc3yy strToNumResult_cqc3yy = default(StrToNumResult_cqc3yy);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		int error = 0;
		int num = 0;
		long num2 = 0L;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		if (Details_expects_bool_condition_bool.Invoke(Arg == null, Expected: false))
		{
			Llvm_trap.Invoke();
		}
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs);
			Llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = 0;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; Internal_isalnum_sgcu77.Invoke(((sbyte*)Arg)[num2]) || ((sbyte*)Arg)[num2] == 95; num2 = checked(num2 + 1L))
			{
			}
			if (((sbyte*)Arg)[num2] == 0)
			{
				String_view_Constructor.Invoke(&cpp_string_view, Arg, num2);
				num = Internal_nan_mantissa_from_ncharseq_float.Invoke(*(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
			}
			Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(V: num, Sign: anon_izyfb.Val);
			fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			StrToNumResult_float_Constructor.Invoke(&strToNumResult_cqc3yy, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs), 0L, error);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return *(Struct_fiz2nb*)(&strToNumResult_cqc3yy);
		}
	}
}
