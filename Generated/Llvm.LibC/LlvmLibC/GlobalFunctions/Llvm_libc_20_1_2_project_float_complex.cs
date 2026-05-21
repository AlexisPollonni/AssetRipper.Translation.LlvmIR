using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_project_float_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7projectICfEET_S2_")]
	[DemangledName("float complex __llvm_libc_20_1_2_::project<float complex>(float complex)")]
	[return: NativeType("float complex")]
	public unsafe static InlineArray2_Single Invoke([MangledName("c.coerce")][NativeType("float complex")] InlineArray2_Single C)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		Struct_kh2xpj struct_kh2xpj2 = default(Struct_kh2xpj);
		Llvm_libc_20_1_2_ExpRangeReduction llvm_libc_20_1_2_ExpRangeReduction = default(Llvm_libc_20_1_2_ExpRangeReduction);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs2 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Llvm_libc_20_1_2_ExpRangeReduction llvm_libc_20_1_2_ExpRangeReduction2 = default(Llvm_libc_20_1_2_ExpRangeReduction);
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs3 = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Struct_kh2xpj struct_kh2xpj3 = default(Struct_kh2xpj);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj2) = C;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction);
			*(float*)(&llvm_libc_20_1_2_ExpRangeReduction) = float.NaN;
			((float*)(&llvm_libc_20_1_2_ExpRangeReduction))[1] = float.NaN;
			*(InlineArray2_Single*)(&llvm_libc_20_1_2_ExpRangeReduction) = Cpp_bit_cast_Complex_float_float_complex.Invoke(&struct_kh2xpj2);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, llvm_libc_20_1_2_ExpRangeReduction.Exp_hi_mid);
			bool num = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				FPBits_float_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2, llvm_libc_20_1_2_ExpRangeReduction.Exp_lo);
				num2 = (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs2) ? 1 : 0);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs2);
			Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
			if (num2 != 0)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction2);
				Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb.Val);
				llvm_libc_20_1_2_fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				llvm_libc_20_1_2_ExpRangeReduction2.Exp_hi_mid = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				llvm_libc_20_1_2_ExpRangeReduction2.Exp_lo = (float)InstructionHelper.Select(llvm_libc_20_1_2_ExpRangeReduction.Exp_lo > 0f, 0.0, -0.0);
				*(InlineArray2_Single*)(&struct_kh2xpj3) = Cpp_bit_cast_float_complex_Complex_float.Invoke(&llvm_libc_20_1_2_ExpRangeReduction2);
				float field_2 = struct_kh2xpj3.field_0;
				float field_3 = struct_kh2xpj3.field_1;
				float* ptr = &struct_kh2xpj.field_1;
				struct_kh2xpj.field_0 = field_2;
				*ptr = field_3;
				Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs3);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction2);
			}
			else
			{
				float field_4 = struct_kh2xpj2.field_0;
				float field_5 = struct_kh2xpj2.field_1;
				float* ptr2 = &struct_kh2xpj.field_1;
				struct_kh2xpj.field_0 = field_4;
				*ptr2 = field_5;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction);
			return *(InlineArray2_Single*)(&struct_kh2xpj);
		}
	}
}
