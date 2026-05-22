using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_project_float128_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7projectICgEET_S2_")]
	[DemangledName("__float128 complex __llvm_libc_20_1_2_::project<__float128 complex>(__float128 complex)")]
	[return: NativeType("__float128 complex")]
	public unsafe static void Invoke([MangledName("agg.result")] Struct_unhbb7* Agg_result, [MangledName("c")][NativeType("__float128 complex")] void* C)
	{
		Llvm_libc_20_1_2_Complex_22i76p llvm_libc_20_1_2_Complex_22i76p = default(Llvm_libc_20_1_2_Complex_22i76p);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Llvm_libc_20_1_2_Complex_22i76p llvm_libc_20_1_2_Complex_22i76p2 = default(Llvm_libc_20_1_2_Complex_22i76p);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Struct_unhbb7 struct_unhbb = default(Struct_unhbb7);
		Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_Complex_22i76p);
		unchecked
		{
			*(double*)(&llvm_libc_20_1_2_Complex_22i76p) = double.NaN;
			((double*)(&llvm_libc_20_1_2_Complex_22i76p))[2] = double.NaN;
			Cpp_bit_cast_Complex_float128_float128_complex.Invoke(&llvm_libc_20_1_2_Complex_22i76p, C);
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, llvm_libc_20_1_2_Complex_22i76p.Real);
			bool num = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi));
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			int num2;
			if (num)
			{
				num2 = 1;
			}
			else
			{
				FPBits_float128_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2, llvm_libc_20_1_2_Complex_22i76p.Imag);
				num2 = (FPRepSem_fputil_FPType_3_fputil_FPBits_float128_is_inf.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_f94eua*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi2)) ? 1 : 0);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
			if (num2 != 0)
			{
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_Complex_22i76p2);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_3_fputil_FPBits_float128_inf.Invoke(anon_izyfb.Val);
				Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				llvm_libc_20_1_2_Complex_22i76p2.Real = FPBits_float128_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				llvm_libc_20_1_2_Complex_22i76p2.Imag = InstructionHelper.Select(llvm_libc_20_1_2_Complex_22i76p.Imag > 0.0, 0.0, -0.0);
				Cpp_bit_cast_float128_complex_Complex_float128.Invoke(&struct_unhbb, &llvm_libc_20_1_2_Complex_22i76p2);
				double field_ = struct_unhbb.field_0;
				double field_2 = struct_unhbb.field_1;
				double* field_3 = &Agg_result->field_1;
				Agg_result->field_0 = field_;
				*field_3 = field_2;
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_Complex_22i76p2);
			}
			else
			{
				double field_4 = ((Struct_unhbb7*)C)->field_0;
				double field_5 = ((Struct_unhbb7*)C)->field_1;
				double* field_6 = &Agg_result->field_1;
				Agg_result->field_0 = field_4;
				*field_6 = field_5;
			}
			Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_Complex_22i76p);
			double field_7 = Agg_result->field_0;
			double field_8 = Agg_result->field_1;
			double* field_9 = &Agg_result->field_1;
			Agg_result->field_0 = field_7;
			*field_9 = field_8;
		}
	}
}
