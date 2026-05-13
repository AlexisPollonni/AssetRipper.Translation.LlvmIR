using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_7projectICgEET_S2_")]
[DemangledName("__float128 complex __llvm_libc_20_1_2_::project<__float128 complex>(__float128 complex)")]
internal static partial class float128_complex_project_float128_complex_float128_complex
{
	public unsafe static void Invoke([MangledName("agg.result")] Struct_unhbb7* agg_result, void* c)
	{
		Complex_22i76p complex_22i76p = default(Complex_22i76p);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		Complex_22i76p complex_22i76p2 = default(Complex_22i76p);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Struct_unhbb7 struct_unhbb = default(Struct_unhbb7);
		llvm_lifetime_start_p0.Invoke(32L, &complex_22i76p);
		unchecked
		{
			*(double*)(&complex_22i76p) = double.NaN;
			((double*)(&complex_22i76p))[2] = double.NaN;
			cpp_enable_if_sizeof_Complex_float128_sizeof_float128_complex_cpp_is_trivially_constructible_Complex_float128_value_cpp_is_trivially_copyable_Complex_float128_value_cpp_is_trivially_copyable_float128_complex_value_Complex_float128_type_cpp_bit_cast_Complex_float128_float128_complex_float128_complex_const.Invoke(&complex_22i76p, c);
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi3, complex_22i76p.real);
			bool num = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi3));
			llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				fputil_FPBits_float128_FPBits_float128_float128.Invoke(&fputil_FPBits_ubgsi4, complex_22i76p.imag);
				num2 = (fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf_const.Invoke((fputil_internal_FPRepSem_f94eua*)(&fputil_FPBits_ubgsi4)) ? 1 : 0);
			}
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
			if (num2 != 0)
			{
				llvm_lifetime_start_p0.Invoke(32L, &complex_22i76p2);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = fputil_internal_FPRepSem_fputil_FPType_3_fputil_FPBits_float128_inf_Sign.Invoke(anon_izyfb8.val);
				Int128* ptr = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				complex_22i76p2.real = fputil_FPBits_float128_get_val_const.Invoke(&fputil_FPBits_ubgsi5);
				complex_22i76p2.imag = InstructionHelper.Select(complex_22i76p.imag > 0.0, 0.0, -0.0);
				cpp_enable_if_sizeof_float128_complex_sizeof_Complex_float128_cpp_is_trivially_constructible_float128_complex_value_cpp_is_trivially_copyable_float128_complex_value_cpp_is_trivially_copyable_Complex_float128_value_float128_complex_type_cpp_bit_cast_float128_complex_Complex_float128_Complex_float128_const.Invoke(&struct_unhbb, &complex_22i76p2);
				double field_ = struct_unhbb.field_0;
				double field_2 = struct_unhbb.field_1;
				double* field_3 = &agg_result->field_1;
				agg_result->field_0 = field_;
				*field_3 = field_2;
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				llvm_lifetime_end_p0.Invoke(32L, &complex_22i76p2);
			}
			else
			{
				double field_4 = ((Struct_unhbb7*)c)->field_0;
				double field_5 = ((Struct_unhbb7*)c)->field_1;
				double* field_6 = &agg_result->field_1;
				agg_result->field_0 = field_4;
				*field_6 = field_5;
			}
			llvm_lifetime_end_p0.Invoke(32L, &complex_22i76p);
			double field_7 = agg_result->field_0;
			double field_8 = agg_result->field_1;
			double* field_9 = &agg_result->field_1;
			agg_result->field_0 = field_7;
			*field_9 = field_8;
		}
	}
}
