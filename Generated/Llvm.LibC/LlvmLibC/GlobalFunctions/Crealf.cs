using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Crealf
{
	[MangledName("crealf")]
	[DemangledName("crealf")]
	public unsafe static float Invoke([MangledName("x.coerce")] InlineArray2_Single X)
	{
		Struct_kh2xpj struct_kh2xpj = default(Struct_kh2xpj);
		Llvm_libc_20_1_2_ExpRangeReduction llvm_libc_20_1_2_ExpRangeReduction = default(Llvm_libc_20_1_2_ExpRangeReduction);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj) = X;
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction);
			*(float*)(&llvm_libc_20_1_2_ExpRangeReduction) = float.NaN;
			((float*)(&llvm_libc_20_1_2_ExpRangeReduction))[1] = float.NaN;
			*(InlineArray2_Single*)(&llvm_libc_20_1_2_ExpRangeReduction) = Cpp_bit_cast_Complex_float_float_complex.Invoke(&struct_kh2xpj);
			float exp_hi_mid = llvm_libc_20_1_2_ExpRangeReduction.Exp_hi_mid;
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_ExpRangeReduction);
			return exp_hi_mid;
		}
	}
}
