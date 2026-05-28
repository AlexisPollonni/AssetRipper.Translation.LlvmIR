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
		ExpRangeReduction expRangeReduction = default(ExpRangeReduction);
		unchecked
		{
			*(InlineArray2_Single*)(&struct_kh2xpj) = X;
			Llvm_lifetime_start_p0.Invoke(8L, &expRangeReduction);
			*(float*)(&expRangeReduction) = float.NaN;
			((float*)(&expRangeReduction))[1] = float.NaN;
			*(InlineArray2_Single*)(&expRangeReduction) = Cpp_bit_cast_Complex_float_float_complex.Invoke(&struct_kh2xpj);
			float exp_hi_mid = expRangeReduction.Exp_hi_mid;
			Llvm_lifetime_end_p0.Invoke(8L, &expRangeReduction);
			return exp_hi_mid;
		}
	}
}
