using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class project_float_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7projectICfEET_S2_")]
	[DemangledName("float complex __llvm_libc_20_1_2_::project<float complex>(float complex)")]
	[return: NativeType("float complex")]
	public unsafe static InlineArray2_Single Invoke([MangledName("c.coerce")][NativeType("float complex")] InlineArray2_Single c)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		Struct_kh2xpj struct_kh2xpj2 = default(Struct_kh2xpj);
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		ExpRangeReduction expRangeReduction2 = default(ExpRangeReduction);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		Struct_kh2xpj struct_kh2xpj3 = default(Struct_kh2xpj);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj2) = c;
			llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction);
			*(float*)(&expRangeReduction) = float.NaN;
			((float*)(&expRangeReduction))[1] = float.NaN;
			*(InlineArray2_Single*)(&expRangeReduction) = cpp_bit_cast_Complex_float_float_complex.Invoke(&struct_kh2xpj2);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs2, expRangeReduction.exp_hi_mid);
			bool num = FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			int num2;
			if (num)
			{
				num2 = -1;
			}
			else
			{
				FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs3, expRangeReduction.exp_lo);
				num2 = (FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_inf.Invoke(&fputil_FPBits_5nkvcs3) ? 1 : 0);
			}
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			if (num2 != 0)
			{
				llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction2);
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
				int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb8.val);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				expRangeReduction2.exp_hi_mid = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs4);
				expRangeReduction2.exp_lo = (float)InstructionHelper.Select(expRangeReduction.exp_lo > 0f, 0.0, -0.0);
				*(InlineArray2_Single*)(&struct_kh2xpj3) = cpp_bit_cast_float_complex_Complex_float.Invoke(&expRangeReduction2);
				float field_2 = struct_kh2xpj3.field_0;
				float field_3 = struct_kh2xpj3.field_1;
				float* ptr = &struct_kh2xpj.field_1;
				struct_kh2xpj.field_0 = field_2;
				*ptr = field_3;
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction2);
			}
			else
			{
				float field_4 = struct_kh2xpj2.field_0;
				float field_5 = struct_kh2xpj2.field_1;
				float* ptr2 = &struct_kh2xpj.field_1;
				struct_kh2xpj.field_0 = field_4;
				*ptr2 = field_5;
			}
			llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction);
			return *(InlineArray2_Single*)(&struct_kh2xpj);
		}
	}
}
