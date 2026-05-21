using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_conjugate_float_complex
{
	[MangledName("_ZN19__llvm_libc_20_1_2_9conjugateICfEET_S2_")]
	[DemangledName("float complex __llvm_libc_20_1_2_::conjugate<float complex>(float complex)")]
	[return: NativeType("float complex")]
	public unsafe static InlineArray2_Single Invoke([MangledName("c.coerce")][NativeType("float complex")] InlineArray2_Single C)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		Struct_kh2xpj struct_kh2xpj2 = default(Struct_kh2xpj);
		Llvm_libc_20_1_2_ExpRangeReduction llvm_libc_20_1_2_ExpRangeReduction = default(Llvm_libc_20_1_2_ExpRangeReduction);
		Struct_kh2xpj struct_kh2xpj3 = default(Struct_kh2xpj);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj2) = C;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction);
			*(float*)(&llvm_libc_20_1_2_ExpRangeReduction) = float.NaN;
			((float*)(&llvm_libc_20_1_2_ExpRangeReduction))[1] = float.NaN;
			*(InlineArray2_Single*)(&llvm_libc_20_1_2_ExpRangeReduction) = Cpp_bit_cast_Complex_float_float_complex.Invoke(&struct_kh2xpj2);
			llvm_libc_20_1_2_ExpRangeReduction.Exp_lo = 0f - llvm_libc_20_1_2_ExpRangeReduction.Exp_lo;
			*(InlineArray2_Single*)(&struct_kh2xpj3) = Cpp_bit_cast_float_complex_Complex_float.Invoke(&llvm_libc_20_1_2_ExpRangeReduction);
			float field_ = struct_kh2xpj3.field_0;
			float field_2 = struct_kh2xpj3.field_1;
			float* ptr = &struct_kh2xpj.field_1;
			struct_kh2xpj.field_0 = field_;
			*ptr = field_2;
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction);
			return *(InlineArray2_Single*)(&struct_kh2xpj);
		}
	}
}
