using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7projectICeEET_S2_")]
[DemangledName("long double complex __llvm_libc_20_1_2_::project<long double complex>(long double complex)")]
internal static partial class long_double_complex_project_long_double_complex_long_double_complex
{
	public unsafe static Struct_29m54m Invoke(void* c)
	{
		Struct_29m54m result = default(Struct_29m54m);
		Complex_wk9una complex_wk9una = default(Complex_wk9una);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		Complex_wk9una complex_wk9una2 = default(Complex_wk9una);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(32L, &complex_wk9una);
		unchecked
		{
			*(double*)(&complex_wk9una) = double.NaN;
			((double*)(&complex_wk9una))[2] = double.NaN;
			cpp_enable_if_sizeof_Complex_long_double_sizeof_long_double_complex_cpp_is_trivially_constructible_Complex_long_double_value_cpp_is_trivially_copyable_Complex_long_double_value_cpp_is_trivially_copyable_long_double_complex_value_Complex_long_double_type_cpp_bit_cast_Complex_long_double_long_double_complex_long_double_complex_const.Invoke(&complex_wk9una, c);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi3, complex_wk9una.real);
			bool num = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi3);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				fputil_FPBits_long_double_FPBits_long_double_long_double.Invoke(&fputil_FPBits_ubgsi4, complex_wk9una.imag);
				num2 = (fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf_const.Invoke(&fputil_FPBits_ubgsi4) ? 1 : 0);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			if (num2 != 0)
			{
				llvm_lifetime_start_p0.Invoke(32L, &complex_wk9una2);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf_Sign.Invoke(anon_izyfb8.val);
				Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				complex_wk9una2.real = fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
				complex_wk9una2.imag = InstructionHelper.Select(complex_wk9una.imag > 0.0, 0.0, -0.0);
				Struct_29m54m struct_29m54m = cpp_enable_if_sizeof_long_double_complex_sizeof_Complex_long_double_cpp_is_trivially_constructible_long_double_complex_value_cpp_is_trivially_copyable_long_double_complex_value_cpp_is_trivially_copyable_Complex_long_double_value_long_double_complex_type_cpp_bit_cast_long_double_complex_Complex_long_double_Complex_long_double_const.Invoke(&complex_wk9una2);
				Struct_29m54m struct_29m54m2 = struct_29m54m;
				double field_ = struct_29m54m2.field_0;
				Struct_29m54m struct_29m54m3 = struct_29m54m;
				double field_2 = struct_29m54m3.field_1;
				double* ptr2 = &result.field_1;
				result.field_0 = field_;
				*ptr2 = field_2;
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				llvm_lifetime_end_p0.Invoke(32L, &complex_wk9una2);
			}
			else
			{
				double field_3 = ((Struct_29m54m*)c)->field_0;
				double field_4 = ((Struct_29m54m*)c)->field_1;
				double* ptr3 = &result.field_1;
				result.field_0 = field_3;
				*ptr3 = field_4;
			}
			llvm_lifetime_end_p0.Invoke(32L, &complex_wk9una);
			return result;
		}
	}
}
