using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIgEENS_14StrToNumResultIT_EEPKc")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<__float128> __llvm_libc_20_1_2_::internal::strtonan<__float128>(char const*)")]
internal static partial class StrToNumResult_float128_internal_strtonan_float128_char_const
{
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_c5b6ms* agg_result, void* arg)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		int error = 0;
		Int128 @int = default(Int128);
		long num = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		Int128 int2 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Int128 int3 = default(Int128);
		if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(arg == null, expected: false))
		{
			llvm_trap.Invoke();
		}
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			fputil_FPBits_float128_FPBits.Invoke(&fputil_FPBits_ubgsi3);
			llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = 0L;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (!internal_isalnum_int.Invoke(((sbyte*)arg)[num])) ? (((sbyte*)arg)[num] == 95) : true; num = checked(num + 1L))
			{
			}
			if (((sbyte*)arg)[num] == 0)
			{
				cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, arg, num);
				Struct_fiz2nb struct_fiz2nb = fputil_FPBits_float128_StorageType_internal_nan_mantissa_from_ncharseq_float128_cpp_string_view.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
				Int128* num2 = &int2;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				@int = int2;
			}
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			Int128 int4 = @int;
			sbyte val = anon_izyfb8.val;
			int3 = int4;
			Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_quiet_nan_Sign_unsigned_int128.Invoke(val, *(long*)(&int3), ((long*)(&int3))[1]);
			Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			StrToNumResult_float128_StrToNumResult_float128_long_int.Invoke(agg_result, fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi3), 0L, error);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(16L, &@int);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		}
	}
}
