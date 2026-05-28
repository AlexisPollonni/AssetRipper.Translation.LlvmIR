using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtonan_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal8strtonanIeEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double> __llvm_libc_20_1_2_::internal::strtonan<long double>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<long double>")]
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_uytq62* Agg_result, [MangledName("arg")][NativeType("char const*")] void* Arg)
	{
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		int error = 0;
		Int128 @int = default(Int128);
		long num = 0L;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Int128 int2 = default(Int128);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Int128 int3 = default(Int128);
		if (Details_expects_bool_condition_bool.Invoke(Arg == null, Expected: false))
		{
			Llvm_trap.Invoke();
		}
		Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi) = -6148914691236517206L;
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi);
			Llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			Llvm_lifetime_start_p0.Invoke(16L, &@int);
			@int = 0L;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; Internal_isalnum_5t2f5r.Invoke(((sbyte*)Arg)[num]) || ((sbyte*)Arg)[num] == 95; num = checked(num + 1L))
			{
			}
			if (((sbyte*)Arg)[num] == 0)
			{
				String_view_Constructor.Invoke(&cpp_string_view, Arg, num);
				Struct_fiz2nb struct_fiz2nb = Internal_nan_mantissa_from_ncharseq_long_double.Invoke(*(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
				Int128* num2 = &int2;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				*(long*)num2 = struct_fiz2nb2.field_0;
				byte* num3 = (byte*)(&int2) + 8u;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				*(long*)num3 = struct_fiz2nb3.field_1;
				@int = int2;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			Int128 int4 = @int;
			sbyte val = anon_izyfb.Val;
			int3 = int4;
			Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&int3), ((long*)(&int3))[1]);
			Int128* ptr = &fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
			Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
			Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
			((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi, &fputil_FPBits_ubgsi2, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			StrToNumResult_long_double_Constructor.Invoke(Agg_result, FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi), 0L, error);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
		}
	}
}
