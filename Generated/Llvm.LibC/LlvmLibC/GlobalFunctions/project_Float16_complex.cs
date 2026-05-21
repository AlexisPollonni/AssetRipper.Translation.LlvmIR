using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class project_Float16_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7projectICDF16_EET_S2_")]
	[DemangledName("_Float16 complex __llvm_libc_20_1_2_::project<_Float16 complex>(_Float16 complex)")]
	[return: NativeType("_Float16 complex")]
	public unsafe static InlineArray2_Half Invoke([MangledName("c.coerce")][NativeType("_Float16 complex")] InlineArray2_Half c)
	{
		Struct_zwcg27 struct_zwcg = default(Struct_zwcg27);
		Struct_zwcg27 struct_zwcg2 = default(Struct_zwcg27);
		Complex_mify6x complex_mify6x = default(Complex_mify6x);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		Complex_mify6x complex_mify6x2 = default(Complex_mify6x);
		fputil_FPBits_2fahva fputil_FPBits_2fahva4 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Struct_zwcg27 struct_zwcg3 = default(Struct_zwcg27);
		unchecked
		{
			*(InlineArray2_Half*)(&struct_zwcg2) = c;
			llvm_lifetime_start_p0.Invoke(4L, &complex_mify6x);
			*(Half*)(&complex_mify6x) = default(Half);
			*(Half*)((byte*)(&complex_mify6x) + 2) = default(Half);
			*(InlineArray2_Half*)(&complex_mify6x) = cpp_bit_cast_Complex_Float16_Float16_complex.Invoke(&struct_zwcg2);
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva2, complex_mify6x.real);
			bool num = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva2));
			llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva3, complex_mify6x.imag);
				num2 = (FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_is_inf.Invoke((fputil_internal_FPRepSem_i7nz4h*)(&fputil_FPBits_2fahva3)) ? 1 : 0);
			}
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			if (num2 != 0)
			{
				llvm_lifetime_start_p0.Invoke(4L, &complex_mify6x2);
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb8.val);
				fputil_FPBits_2fahva4.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				complex_mify6x2.real = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva4);
				complex_mify6x2.imag = (Half)InstructionHelper.Select(NumericHelper.FcmpOgt(complex_mify6x.imag, default(Half)), 0.0, -0.0);
				*(InlineArray2_Half*)(&struct_zwcg3) = cpp_bit_cast_Float16_complex_Complex_Float16.Invoke(&complex_mify6x2);
				Half field_2 = struct_zwcg3.field_0;
				Half field_3 = struct_zwcg3.field_1;
				Half* ptr = &struct_zwcg.field_1;
				struct_zwcg.field_0 = field_2;
				*ptr = field_3;
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva4);
				llvm_lifetime_end_p0.Invoke(4L, &complex_mify6x2);
			}
			else
			{
				Half field_4 = struct_zwcg2.field_0;
				Half field_5 = struct_zwcg2.field_1;
				Half* ptr2 = &struct_zwcg.field_1;
				struct_zwcg.field_0 = field_4;
				*ptr2 = field_5;
			}
			llvm_lifetime_end_p0.Invoke(4L, &complex_mify6x);
			return *(InlineArray2_Half*)(&struct_zwcg);
		}
	}
}
