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
		StrToNumResult_stcih6 strToNumResult_stcih = default(StrToNumResult_stcih6);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		int error = 0;
		short num = 0;
		long num2 = 0L;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(Fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		if (Details_expects_bool_condition_bool.Invoke(Arg == null, Expected: false))
		{
			Llvm_trap.Invoke();
		}
		Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
		unchecked
		{
			*(short*)(&fputil_FPBits_2fahva) = -21846;
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva);
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
				String_view_Constructor.Invoke(&cpp_string_view, Arg, num2);
				num = Internal_nan_mantissa_from_ncharseq_Float16.Invoke(*(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
			}
			Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_quiet_nan.Invoke(V: num, Sign: anon_izyfb.Val);
			fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_2fahva, &fputil_FPBits_2fahva2, 2L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			StrToNumResult_Float16_Constructor.Invoke(&strToNumResult_stcih, FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva), 0L, error);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(2L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
			return *(Struct_fiz2nb*)(&strToNumResult_stcih);
		}
	}
}
