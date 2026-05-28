using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtonan_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIdEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double> __llvm_libc_20_1_2_::internal::strtonan<double>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<double>")]
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_k826n6* Agg_result, [MangledName("arg")][NativeType("char const*")] void* Arg)
	{
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		int error = 0;
		long num = 0L;
		long num2 = 0L;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		if (Details_expects_bool_condition_bool.Invoke(Arg == null, Expected: false))
		{
			Llvm_trap.Invoke();
		}
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm);
			Llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = 0L;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; Internal_isalnum_8q3d39.Invoke(((sbyte*)Arg)[num2]) || ((sbyte*)Arg)[num2] == 95; num2 = checked(num2 + 1L))
			{
			}
			if (((sbyte*)Arg)[num2] == 0)
			{
				String_view_Constructor.Invoke(&cpp_string_view, Arg, num2);
				num = Internal_nan_mantissa_from_ncharseq_double.Invoke(*(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
			}
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: num, Sign: anon_izyfb.Val);
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			StrToNumResult_double_Constructor.Invoke(Agg_result, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm), 0L, error);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		}
	}
}
