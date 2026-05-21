using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_strtonan_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIDF16_EENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<_Float16> __llvm_libc_20_1_2_::internal::strtonan<_Float16>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<_Float16>")]
	public unsafe static Struct_fiz2nb Invoke([NativeType("char const*")] void* arg)
	{
		StrToNumResult_stcih6 strToNumResult_stcih = default(StrToNumResult_stcih6);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		int error = 0;
		short num = 0;
		long num2 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		if (details_expects_bool_condition_bool.Invoke(arg == null, expected: false))
		{
			llvm_trap.Invoke();
		}
		llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva2) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2);
			llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			llvm_lifetime_start_p0.Invoke(2L, &num);
			num = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; (!internal_isalnum_bz3wcr.Invoke(((sbyte*)arg)[num2])) ? (((sbyte*)arg)[num2] == 95) : true; num2 = checked(num2 + 1L))
			{
			}
			if (((sbyte*)arg)[num2] == 0)
			{
				string_view_Constructor.Invoke(&cpp_string_view2, arg, num2);
				num = internal_nan_mantissa_from_ncharseq_Float16.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
			}
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(v: num, sign: anon_izyfb8.val);
			fputil_FPBits_2fahva3.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva2, &fputil_FPBits_2fahva3, 2L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			StrToNumResult_Float16_Constructor.Invoke(&strToNumResult_stcih, FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2), 0L, error);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(2L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			return *(Struct_fiz2nb*)(&strToNumResult_stcih);
		}
	}
}
