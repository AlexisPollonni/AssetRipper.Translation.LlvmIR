using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtonan_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIDF16_EENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<_Float16> __llvm_libc_20_1_2_::internal::strtonan<_Float16>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<_Float16>")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("arg")][NativeType("char const*")] void* Arg)
	{
		Llvm_libc_20_1_2_StrToNumResult_stcih6 llvm_libc_20_1_2_StrToNumResult_stcih = default(Llvm_libc_20_1_2_StrToNumResult_stcih6);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		int error = 0;
		short num = 0;
		long num2 = 0L;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		if (Details_expects_bool_condition_bool.Invoke(Arg == null, Expected: false))
		{
			Llvm_trap.Invoke();
		}
		Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
			Llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			Llvm_lifetime_start_p0.Invoke(2L, &num);
			num = 0;
			Llvm_lifetime_start_p0.Invoke(8L, &num2);
			for (num2 = 0L; Internal_isalnum_bz3wcr.Invoke(((sbyte*)Arg)[num2]) || ((sbyte*)Arg)[num2] == 95; num2 = checked(num2 + 1L))
			{
			}
			if (((sbyte*)Arg)[num2] == 0)
			{
				String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, Arg, num2);
				num = Internal_nan_mantissa_from_ncharseq_Float16.Invoke(*(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]);
			}
			Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: num, Sign: anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, &llvm_libc_20_1_2_fputil_FPBits_2fahva2, 2L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
			StrToNumResult_Float16_Constructor.Invoke(&llvm_libc_20_1_2_StrToNumResult_stcih, FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva), 0L, error);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			return *(Struct_fiz2nb*)(&llvm_libc_20_1_2_StrToNumResult_stcih);
		}
	}
}
