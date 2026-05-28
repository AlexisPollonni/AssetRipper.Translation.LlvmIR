using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Project_long_double_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7projectICeEET_S2_")]
	[DemangledName("long double complex __llvm_libc_20_1_2_::project<long double complex>(long double complex)")]
	[return: NativeType("long double complex")]
	public unsafe static Struct_29m54m Invoke([MangledName("c")][NativeType("long double complex")] void* C)
	{
		Struct_29m54m result = default(Struct_29m54m);
		Complex_p54sq8 complex_p54sq = default(Complex_p54sq8);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi = default(Fputil_FPBits_ubgsi2);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi2 = default(Fputil_FPBits_ubgsi2);
		Complex_p54sq8 complex_p54sq2 = default(Complex_p54sq8);
		Fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(Fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(32L, &complex_p54sq);
		unchecked
		{
			*(double*)(&complex_p54sq) = double.NaN;
			((double*)(&complex_p54sq))[2] = double.NaN;
			Cpp_bit_cast_Complex_long_double_long_double_complex.Invoke(&complex_p54sq, C);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi, complex_p54sq.Real);
			bool num = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi);
			Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			int num2;
			if (num)
			{
				num2 = 1;
			}
			else
			{
				FPBits_long_double_Constructor.Invoke(&fputil_FPBits_ubgsi2, complex_p54sq.Imag);
				num2 = (FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_is_inf.Invoke(&fputil_FPBits_ubgsi2) ? 1 : 0);
			}
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi2);
			Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi);
			if (num2 != 0)
			{
				Llvm_lifetime_start_p0.Invoke(32L, &complex_p54sq2);
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
				Struct_fiz2nb struct_fiz2nb = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf.Invoke(anon_izyfb.Val);
				Int128* ptr = &fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb2.field_0;
				Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
				((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb3.field_1;
				complex_p54sq2.Real = FPBits_long_double_get_val.Invoke(&fputil_FPBits_ubgsi3);
				complex_p54sq2.Imag = InstructionHelper.Select(complex_p54sq.Imag > 0.0, 0.0, -0.0);
				Struct_29m54m struct_29m54m = Cpp_bit_cast_long_double_complex_Complex_long_double.Invoke(&complex_p54sq2);
				Struct_29m54m struct_29m54m2 = struct_29m54m;
				double field_ = struct_29m54m2.field_0;
				Struct_29m54m struct_29m54m3 = struct_29m54m;
				double field_2 = struct_29m54m3.field_1;
				double* ptr2 = &result.field_1;
				result.field_0 = field_;
				*ptr2 = field_2;
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
				Llvm_lifetime_end_p0.Invoke(32L, &complex_p54sq2);
			}
			else
			{
				double field_3 = ((Struct_29m54m*)C)->field_0;
				double field_4 = ((Struct_29m54m*)C)->field_1;
				double* ptr3 = &result.field_1;
				result.field_0 = field_3;
				*ptr3 = field_4;
			}
			Llvm_lifetime_end_p0.Invoke(32L, &complex_p54sq);
			return result;
		}
	}
}
